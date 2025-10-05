
#pragma once
#include "./imgui/imgui.h"
#include "./imgui/imgui_internal.h"
#include <cimgui.h>

enum ImGuiPlatformAPICallIndex : int
{
    Platform_CreateWindow,
    Platform_DestroyWindow,
    Platform_ShowWindow,
    Platform_SetWindowPos,
    Platform_GetWindowPos,
    Platform_SetWindowSize,
    Platform_GetWindowSize,
    Platform_GetWindowFramebufferScale,
    Platform_SetWindowFocus,
    Platform_GetWindowFocus,
    Platform_GetWindowMinimized,
    Platform_SetWindowTitle,
    Platform_SetWindowAlpha,
    Platform_UpdateWindow,
    Platform_RenderWindow,
    Platform_SwapBuffers,
    Platform_GetWindowDpiScale,
    Platform_OnChangedViewport,
    //Platform_GetWindowWorkAreaInsets,
    Platform_CreateVkSurface,

    Renderer_CreateWindow,
    Renderer_DestroyWindow,
    Renderer_SetWindowSize,
    Renderer_RenderWindow,
    Renderer_SwapBuffers
};

CIMGUI_API void ImGuiPlatformIO_Monitors_Resize(int size);
CIMGUI_API void ImGuiPlatformIO_Monitors_PushBack(ImGuiPlatformMonitor monitor);
CIMGUI_API void ImGuiPlatformIO_Monitors_PushFront(ImGuiPlatformMonitor monitor);

CIMGUI_API void ImGuiPlatformIO_SetCallback(ImGuiPlatformAPICallIndex callback, void* funcptr);