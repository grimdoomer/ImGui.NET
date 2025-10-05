
#include "cimgui.manual.h"

CIMGUI_API void ImGuiPlatformIO_Monitors_Resize(int size)
{
    ImGui::GetPlatformIO().Monitors.resize(size);
}

CIMGUI_API void ImGuiPlatformIO_Monitors_PushBack(ImGuiPlatformMonitor monitor)
{
    ImGui::GetPlatformIO().Monitors.push_back(monitor);
}

CIMGUI_API void ImGuiPlatformIO_Monitors_PushFront(ImGuiPlatformMonitor monitor)
{
    ImGui::GetPlatformIO().Monitors.push_front(monitor);
}

// CImgui sets the default calling convention to __cdecl but this makes it hard to pass delegate functions from C# that can
// be called correctly. To work around this we create a PlatformIO structure that has __stdcall function pointers that match
// the calling convention of the C# delegates we assign. Then we tie this structure to the ImGui context struct (since the real ImGui
// PlatformIO structure is part of ImGuiContext) and when a C# delegate is assigned we hook in a __cdecl shim function that can
// handle the calling convention switch.

#include <map>

struct ImGuiPlatformIOStdCall
{
    // Platform function --------------------------------------------------- Called by -----
    void(__stdcall* Platform_CreateWindow)(ImGuiViewport* vp);                    // . . U . .  // Create a new platform window for the given viewport
    void(__stdcall* Platform_DestroyWindow)(ImGuiViewport* vp);                   // N . U . D  //
    void(__stdcall* Platform_ShowWindow)(ImGuiViewport* vp);                      // . . U . .  // Newly created windows are initially hidden so SetWindowPos/Size/Title can be called on them before showing the window
    void(__stdcall* Platform_SetWindowPos)(ImGuiViewport* vp, ImVec2 pos);        // . . U . .  // Set platform window position (given the upper-left corner of client area)
    void(__stdcall* Platform_GetWindowPos)(ImGuiViewport* vp, ImVec2* pos);                    // N . . . .  //
    void(__stdcall* Platform_SetWindowSize)(ImGuiViewport* vp, ImVec2 size);      // . . U . .  // Set platform window client area size (ignoring OS decorations such as OS title bar etc.)
    void(__stdcall* Platform_GetWindowSize)(ImGuiViewport* vp, ImVec2* size);                   // N . . . .  // Get platform window client area size
    void(__stdcall* Platform_GetWindowFramebufferScale)(ImGuiViewport* vp, ImVec2* density);       // N . . . .  // Return viewport density. Always 1,1 on Windows, often 2,2 on Retina display on macOS/iOS. MUST BE INTEGER VALUES.
    void(__stdcall* Platform_SetWindowFocus)(ImGuiViewport* vp);                  // N . . . .  // Move window to front and set input focus
    bool(__stdcall* Platform_GetWindowFocus)(ImGuiViewport* vp);                  // . . U . .  //
    bool(__stdcall* Platform_GetWindowMinimized)(ImGuiViewport* vp);              // N . . . .  // Get platform window minimized state. When minimized, we generally won't attempt to get/set size and contents will be culled more easily
    void(__stdcall* Platform_SetWindowTitle)(ImGuiViewport* vp, const char* str); // . . U . .  // Set platform window title (given an UTF-8 string)
    void(__stdcall* Platform_SetWindowAlpha)(ImGuiViewport* vp, float alpha);     // . . U . .  // (Optional) Setup global transparency (not per-pixel transparency)
    void(__stdcall* Platform_UpdateWindow)(ImGuiViewport* vp);                    // . . U . .  // (Optional) Called by UpdatePlatformWindows(). Optional hook to allow the platform backend from doing general book-keeping every frame.
    void(__stdcall* Platform_RenderWindow)(ImGuiViewport* vp, void* render_arg);  // . . . R .  // (Optional) Main rendering (platform side! This is often unused, or just setting a "current" context for OpenGL bindings). 'render_arg' is the value passed to RenderPlatformWindowsDefault().
    void(__stdcall* Platform_SwapBuffers)(ImGuiViewport* vp, void* render_arg);   // . . . R .  // (Optional) Call Present/SwapBuffers (platform side! This is often unused!). 'render_arg' is the value passed to RenderPlatformWindowsDefault().
    float(__stdcall* Platform_GetWindowDpiScale)(ImGuiViewport* vp);               // N . . . .  // (Optional) [BETA] FIXME-DPI: DPI handling: Return DPI scale for this viewport. 1.0f = 96 DPI.
    void(__stdcall* Platform_OnChangedViewport)(ImGuiViewport* vp);               // . F . . .  // (Optional) [BETA] FIXME-DPI: DPI handling: Called during Begin() every time the viewport we are outputting into changes, so backend has a chance to swap fonts to adjust style.
    //ImVec4(*Platform_GetWindowWorkAreaInsets)(ImGuiViewport* vp);         // N . . . .  // (Optional) [BETA] Get initial work area inset for the viewport (won't be covered by main menu bar, dockspace over viewport etc.). Default to (0,0),(0,0). 'safeAreaInsets' in iOS land, 'DisplayCutout' in Android land.
    int(__stdcall* Platform_CreateVkSurface)(ImGuiViewport* vp, ImU64 vk_inst, const void* vk_allocators, ImU64* out_vk_surface); // (Optional) For a Vulkan Renderer to call into Platform code (since the surface creation needs to tie them both).

    // (Optional) Renderer functions (e.g. DirectX, OpenGL, Vulkan)
    void(__stdcall* Renderer_CreateWindow)(ImGuiViewport* vp);                    // . . U . .  // Create swap chain, frame buffers etc. (called after Platform_CreateWindow)
    void(__stdcall* Renderer_DestroyWindow)(ImGuiViewport* vp);                   // N . U . D  // Destroy swap chain, frame buffers etc. (called before Platform_DestroyWindow)
    void(__stdcall* Renderer_SetWindowSize)(ImGuiViewport* vp, ImVec2 size);      // . . U . .  // Resize swap chain, frame buffers etc. (called after Platform_SetWindowSize)
    void(__stdcall* Renderer_RenderWindow)(ImGuiViewport* vp, void* render_arg);  // . . . R .  // (Optional) Clear framebuffer, setup render target, then render the viewport->DrawData. 'render_arg' is the value passed to RenderPlatformWindowsDefault().
    void(__stdcall* Renderer_SwapBuffers)(ImGuiViewport* vp, void* render_arg);   // . . . R .  // (Optional) Call Present/SwapBuffers. 'render_arg' is the value passed to RenderPlatformWindowsDefault().

    ImGuiPlatformIOStdCall() { memset(this, 0, sizeof(*this)); }     // Zero clear
};

std::map<ImGuiContext*, ImGuiPlatformIOStdCall> imGuiManagedPlatformIO;


// Shim functions to handle going from __cdecl to __stdcall calling convention.

void Shim_Platform_CreateWindow(ImGuiViewport* vp)
{
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_CreateWindow(vp);
}

void Shim_Platform_DestroyWindow(ImGuiViewport* vp)
{
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_DestroyWindow(vp);
}

void Shim_Platform_ShowWindow(ImGuiViewport* vp)
{
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_ShowWindow(vp);
}

void Shim_Platform_SetWindowPos(ImGuiViewport* vp, ImVec2 pos)
{
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_SetWindowPos(vp, pos);
}

ImVec2 Shim_Platform_GetWindowPos(ImGuiViewport* vp)
{
    ImVec2 pos;
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_GetWindowPos(vp, &pos);

    return pos;
}

void Shim_Platform_SetWindowSize(ImGuiViewport* vp, ImVec2 size)
{
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_SetWindowSize(vp, size);
}

ImVec2 Shim_Platform_GetWindowSize(ImGuiViewport* vp)
{
    ImVec2 size;
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_GetWindowSize(vp, &size);

    return size;
}

ImVec2 Shim_Platform_GetWindowFramebufferScale(ImGuiViewport* vp)
{
    ImVec2 density;
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_GetWindowFramebufferScale(vp, &density);

    return density;
}

void Shim_Platform_SetWindowFocus(ImGuiViewport* vp)
{
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_SetWindowFocus(vp);
}

bool Shim_Platform_GetWindowFocus(ImGuiViewport* vp)
{
    return imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_GetWindowFocus(vp);
}

bool Shim_Platform_GetWindowMinimized(ImGuiViewport* vp)
{
    return imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_GetWindowMinimized(vp);
}

void Shim_Platform_SetWindowTitle(ImGuiViewport* vp, const char* str)
{
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_SetWindowTitle(vp, str);
}

void Shim_Platform_SetWindowAlpha(ImGuiViewport* vp, float alpha)
{
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_SetWindowAlpha(vp, alpha);
}

void Shim_Platform_UpdateWindow(ImGuiViewport* vp)
{
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_UpdateWindow(vp);
}

void Shim_Platform_RenderWindow(ImGuiViewport* vp, void* render_arg)
{
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_RenderWindow(vp, render_arg);
}

void Shim_Platform_SwapBuffers(ImGuiViewport* vp, void* render_arg)
{
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_SwapBuffers(vp, render_arg);
}

float Shim_Platform_GetWindowDpiScale(ImGuiViewport* vp)
{
    return imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_GetWindowDpiScale(vp);
}

void Shim_Platform_OnChangedViewport(ImGuiViewport* vp)
{
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_OnChangedViewport(vp);
}

int Shim_Platform_CreateVkSurface(ImGuiViewport* vp, ImU64 vk_inst, const void* vk_allocators, ImU64* out_vk_surface)
{
    return imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_CreateVkSurface(vp, vk_inst, vk_allocators, out_vk_surface);
}

void Shim_Renderer_CreateWindow(ImGuiViewport* vp)
{
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Renderer_CreateWindow(vp);
}

void Shim_Renderer_DestroyWindow(ImGuiViewport* vp)
{
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Renderer_DestroyWindow(vp);
}

void Shim_Renderer_SetWindowSize(ImGuiViewport* vp, ImVec2 size)
{
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Renderer_SetWindowSize(vp, size);
}

void Shim_Renderer_RenderWindow(ImGuiViewport* vp, void* render_arg)
{
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Renderer_RenderWindow(vp, render_arg);
}

void Shim_Renderer_SwapBuffers(ImGuiViewport* vp, void* render_arg)
{
    imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Renderer_SwapBuffers(vp, render_arg);
}


CIMGUI_API void ImGuiPlatformIO_SetCallback(ImGuiPlatformAPICallIndex callback, void* funcptr)
{
    // Make sure there is a platform io structure for the current imgui context.
    if (imGuiManagedPlatformIO.find(ImGui::GetCurrentContext()) == imGuiManagedPlatformIO.end())
        imGuiManagedPlatformIO.emplace(ImGui::GetCurrentContext(), ImGuiPlatformIOStdCall());

    // Check the callback type and handle accordingly.
    void** ppPlatformIOManaged = nullptr;
    switch (callback)
    {
    case Platform_CreateWindow:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_CreateWindow;
        ImGui::GetPlatformIO().Platform_CreateWindow = Shim_Platform_CreateWindow;
        break;
    }
    case Platform_DestroyWindow:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_DestroyWindow;
        ImGui::GetPlatformIO().Platform_DestroyWindow = Shim_Platform_DestroyWindow;
        break;
    }
    case Platform_ShowWindow:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_ShowWindow;
        ImGui::GetPlatformIO().Platform_ShowWindow = Shim_Platform_ShowWindow;
        break;
    }
    case Platform_SetWindowPos:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_SetWindowPos;
        ImGui::GetPlatformIO().Platform_SetWindowPos = Shim_Platform_SetWindowPos;
        break;
    }
    case Platform_GetWindowPos:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_GetWindowPos;
        ImGui::GetPlatformIO().Platform_GetWindowPos = Shim_Platform_GetWindowPos;
        break;
    }
    case Platform_SetWindowSize:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_SetWindowSize;
        ImGui::GetPlatformIO().Platform_SetWindowSize = Shim_Platform_SetWindowSize;
        break;
    }
    case Platform_GetWindowSize:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_GetWindowSize;
        ImGui::GetPlatformIO().Platform_GetWindowSize = Shim_Platform_GetWindowSize;
        break;
    }
    case Platform_GetWindowFramebufferScale:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_GetWindowFramebufferScale;
        ImGui::GetPlatformIO().Platform_GetWindowFramebufferScale = Shim_Platform_GetWindowFramebufferScale;
        break;
    }
    case Platform_SetWindowFocus:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_SetWindowFocus;
        ImGui::GetPlatformIO().Platform_SetWindowFocus = Shim_Platform_SetWindowFocus;
        break;
    }
    case Platform_GetWindowFocus:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_GetWindowFocus;
        ImGui::GetPlatformIO().Platform_GetWindowFocus = Shim_Platform_GetWindowFocus;
        break;
    }
    case Platform_GetWindowMinimized:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_GetWindowMinimized;
        ImGui::GetPlatformIO().Platform_GetWindowMinimized = Shim_Platform_GetWindowMinimized;
        break;
    }
    case Platform_SetWindowTitle:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_SetWindowTitle;
        ImGui::GetPlatformIO().Platform_SetWindowTitle = Shim_Platform_SetWindowTitle;
        break;
    }
    case Platform_SetWindowAlpha:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_SetWindowAlpha;
        ImGui::GetPlatformIO().Platform_SetWindowAlpha = Shim_Platform_SetWindowAlpha;
        break;
    }
    case Platform_UpdateWindow:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_UpdateWindow;
        ImGui::GetPlatformIO().Platform_UpdateWindow = Shim_Platform_UpdateWindow;
        break;
    }
    case Platform_RenderWindow:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_RenderWindow;
        ImGui::GetPlatformIO().Platform_RenderWindow = Shim_Platform_RenderWindow;
        break;
    }
    case Platform_SwapBuffers:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_SwapBuffers;
        ImGui::GetPlatformIO().Platform_SwapBuffers = Shim_Platform_SwapBuffers;
        break;
    }
    case Platform_GetWindowDpiScale:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_GetWindowDpiScale;
        ImGui::GetPlatformIO().Platform_GetWindowDpiScale = Shim_Platform_GetWindowDpiScale;
        break;
    }
    case Platform_OnChangedViewport:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_OnChangedViewport;
        ImGui::GetPlatformIO().Platform_OnChangedViewport = Shim_Platform_OnChangedViewport;
        break;
    }
    case Platform_CreateVkSurface:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Platform_CreateVkSurface;
        ImGui::GetPlatformIO().Platform_CreateVkSurface = Shim_Platform_CreateVkSurface;
        break;
    }
    case Renderer_CreateWindow:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Renderer_CreateWindow;
        ImGui::GetPlatformIO().Renderer_CreateWindow = Shim_Renderer_CreateWindow;
        break;
    }
    case Renderer_DestroyWindow:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Renderer_DestroyWindow;
        ImGui::GetPlatformIO().Renderer_DestroyWindow = Shim_Renderer_DestroyWindow;
        break;
    }
    case Renderer_SetWindowSize:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Renderer_SetWindowSize;
        ImGui::GetPlatformIO().Renderer_SetWindowSize = Shim_Renderer_SetWindowSize;
        break;
    }
    case Renderer_RenderWindow:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Renderer_RenderWindow;
        ImGui::GetPlatformIO().Renderer_RenderWindow = Shim_Renderer_RenderWindow;
        break;
    }
    case Renderer_SwapBuffers:
    {
        ppPlatformIOManaged = (void**)&imGuiManagedPlatformIO[ImGui::GetCurrentContext()].Renderer_SwapBuffers;
        ImGui::GetPlatformIO().Renderer_SwapBuffers = Shim_Renderer_SwapBuffers;
        break;
    }
    }

    // Set the managed function ptr.
    *ppPlatformIOManaged = funcptr;
}