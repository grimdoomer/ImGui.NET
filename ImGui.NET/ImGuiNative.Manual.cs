using SharpDX;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ImGuiNET
{
    public enum ImGuiPlatformAPICallIndex : int
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
    }

    public static unsafe partial class ImGuiNative
    {
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollToBringRectIntoView();


        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformIO_Monitors_Resize(int size);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformIO_Monitors_PushBack(ImGuiPlatformMonitor monitor);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformIO_Monitors_PushFront(ImGuiPlatformMonitor monitor);


        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformIO_SetCallback(ImGuiPlatformAPICallIndex callback, IntPtr funcptr);
    }
}
