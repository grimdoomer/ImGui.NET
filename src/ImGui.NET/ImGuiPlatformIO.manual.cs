using SharpDX;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ImGuiNET
{
    #region Delegates types

    public unsafe delegate void Platform_CreateWindowFunc(ImGuiViewport* vp);

    public unsafe delegate void Platform_DestroyWindowFunc(ImGuiViewport* vp);

    public unsafe delegate void Platform_ShowWindowFunc(ImGuiViewport* vp);

    public unsafe delegate void Platform_SetWindowPosFunc(ImGuiViewport* vp, Vector2 pos);

    public unsafe delegate void Platform_GetWindowPosFunc(ImGuiViewport* vp, Vector2* pos);

    public unsafe delegate void Platform_SetWindowSizeFunc(ImGuiViewport* vp, Vector2 size);

    public unsafe delegate void Platform_GetWindowSizeFunc(ImGuiViewport* vp, Vector2* size);

    public unsafe delegate void Platform_SetWindowFocusFunc(ImGuiViewport* vp);

    public unsafe delegate bool Platform_GetWindowFocusFunc(ImGuiViewport* vp);

    public unsafe delegate bool Platform_GetWindowMinimizedFunc(ImGuiViewport* vp);

    public unsafe delegate void Platform_SetWindowTitleFunc(ImGuiViewport* vp, byte* str);

    public unsafe delegate void Platform_SetWindowAlphaFunc(ImGuiViewport* vp, float alpha);

    public unsafe delegate void Platform_UpdateWindowFunc(ImGuiViewport* vp);

    public unsafe delegate void Platform_RenderWindowFunc(ImGuiViewport* vp, void* render_arg);

    public unsafe delegate void Platform_SwapBuffersFunc(ImGuiViewport* vp, void* render_arg);

    public unsafe delegate float Platform_GetWindowDpiScaleFunc(ImGuiViewport* vp);

    public unsafe delegate void Platform_OnChangedViewportFunc(ImGuiViewport* vp);

    public unsafe delegate int Platform_CreateVkSurfaceFunc(ImGuiViewport* vp, ulong vk_inst, void* vk_allocators, ulong* out_vk_surface);

    public unsafe delegate void Renderer_CreateWindowFunc(ImGuiViewport* vp);

    public unsafe delegate void Renderer_DestroyWindowFunc(ImGuiViewport* vp);

    public unsafe delegate void Renderer_SetWindowSizeFunc(ImGuiViewport* vp, Vector2 size);

    public unsafe delegate void Renderer_RenderWindowFunc(ImGuiViewport* vp, void* render_arg);

    public unsafe delegate void Renderer_SwapBuffersFunc(ImGuiViewport* vp, void* render_arg);

    #endregion

    public unsafe partial struct ImGuiPlatformIO
    {
        public IntPtr Platform_CreateWindow;
        public IntPtr Platform_DestroyWindow;
        public IntPtr Platform_ShowWindow;
        public IntPtr Platform_SetWindowPos;
        public IntPtr Platform_GetWindowPos;
        public IntPtr Platform_SetWindowSize;
        public IntPtr Platform_GetWindowSize;
        public IntPtr Platform_SetWindowFocus;
        public IntPtr Platform_GetWindowFocus;
        public IntPtr Platform_GetWindowMinimized;
        public IntPtr Platform_SetWindowTitle;
        public IntPtr Platform_SetWindowAlpha;
        public IntPtr Platform_UpdateWindow;
        public IntPtr Platform_RenderWindow;
        public IntPtr Platform_SwapBuffers;
        public IntPtr Platform_GetWindowDpiScale;
        public IntPtr Platform_OnChangedViewport;
        public IntPtr Platform_CreateVkSurface;
        public IntPtr Renderer_CreateWindow;
        public IntPtr Renderer_DestroyWindow;
        public IntPtr Renderer_SetWindowSize;
        public IntPtr Renderer_RenderWindow;
        public IntPtr Renderer_SwapBuffers;
        public ImVector Monitors;
        public ImVector Viewports;
    }

    public unsafe partial struct ImGuiPlatformIOPtr
    {
        public ImGuiPlatformIO* NativePtr { get; }
        public ImGuiPlatformIOPtr(ImGuiPlatformIO* nativePtr) => NativePtr = nativePtr;
        public ImGuiPlatformIOPtr(IntPtr nativePtr) => NativePtr = (ImGuiPlatformIO*)nativePtr;
        public static implicit operator ImGuiPlatformIOPtr(ImGuiPlatformIO* nativePtr) => new ImGuiPlatformIOPtr(nativePtr);
        public static implicit operator ImGuiPlatformIO*(ImGuiPlatformIOPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiPlatformIOPtr(IntPtr nativePtr) => new ImGuiPlatformIOPtr(nativePtr);

        #region Function delegates

        public Platform_CreateWindowFunc Platform_CreateWindow { set { ImGuiNative.ImGuiPlatformIO_SetCallback(0, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Platform_DestroyWindowFunc Platform_DestroyWindow { set { ImGuiNative.ImGuiPlatformIO_SetCallback(1, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Platform_ShowWindowFunc Platform_ShowWindow { set { ImGuiNative.ImGuiPlatformIO_SetCallback(2, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Platform_SetWindowPosFunc Platform_SetWindowPos { set { ImGuiNative.ImGuiPlatformIO_SetCallback(3, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Platform_GetWindowPosFunc Platform_GetWindowPos { set { ImGuiNative.ImGuiPlatformIO_SetCallback(4, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Platform_SetWindowSizeFunc Platform_SetWindowSize { set { ImGuiNative.ImGuiPlatformIO_SetCallback(5, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Platform_GetWindowSizeFunc Platform_GetWindowSize { set { ImGuiNative.ImGuiPlatformIO_SetCallback(6, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Platform_SetWindowFocusFunc Platform_SetWindowFocus { set { ImGuiNative.ImGuiPlatformIO_SetCallback(7, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Platform_GetWindowFocusFunc Platform_GetWindowFocus { set { ImGuiNative.ImGuiPlatformIO_SetCallback(8, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Platform_GetWindowMinimizedFunc Platform_GetWindowMinimized { set { ImGuiNative.ImGuiPlatformIO_SetCallback(9, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Platform_SetWindowTitleFunc Platform_SetWindowTitle { set { ImGuiNative.ImGuiPlatformIO_SetCallback(10, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Platform_SetWindowAlphaFunc Platform_SetWindowAlpha { set { ImGuiNative.ImGuiPlatformIO_SetCallback(11, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Platform_UpdateWindowFunc Platform_UpdateWindow { set { ImGuiNative.ImGuiPlatformIO_SetCallback(12, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Platform_RenderWindowFunc Platform_RenderWindow { set { ImGuiNative.ImGuiPlatformIO_SetCallback(13, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Platform_SwapBuffersFunc Platform_SwapBuffers { set { ImGuiNative.ImGuiPlatformIO_SetCallback(14, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Platform_GetWindowDpiScaleFunc Platform_GetWindowDpiScale { set { ImGuiNative.ImGuiPlatformIO_SetCallback(15, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Platform_OnChangedViewportFunc Platform_OnChangedViewport { set { ImGuiNative.ImGuiPlatformIO_SetCallback(16, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Platform_CreateVkSurfaceFunc Platform_CreateVkSurface { set { ImGuiNative.ImGuiPlatformIO_SetCallback(17, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Renderer_CreateWindowFunc Renderer_CreateWindow { set { ImGuiNative.ImGuiPlatformIO_SetCallback(18, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Renderer_DestroyWindowFunc Renderer_DestroyWindow { set { ImGuiNative.ImGuiPlatformIO_SetCallback(19, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Renderer_SetWindowSizeFunc Renderer_SetWindowSize { set { ImGuiNative.ImGuiPlatformIO_SetCallback(20, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Renderer_RenderWindowFunc Renderer_RenderWindow { set { ImGuiNative.ImGuiPlatformIO_SetCallback(21, Marshal.GetFunctionPointerForDelegate(value)); } }
        public Renderer_SwapBuffersFunc Renderer_SwapBuffers { set { ImGuiNative.ImGuiPlatformIO_SetCallback(22, Marshal.GetFunctionPointerForDelegate(value)); } }

        #endregion


        public ImPtrVector<ImGuiPlatformMonitorPtr> Monitors => new ImPtrVector<ImGuiPlatformMonitorPtr>(NativePtr->Monitors, Unsafe.SizeOf<ImGuiPlatformMonitor>());
        public ImVector<ImGuiViewportPtr> Viewports => new ImVector<ImGuiViewportPtr>(NativePtr->Viewports);
        public void Destroy()
        {
            ImGuiNative.ImGuiPlatformIO_destroy((ImGuiPlatformIO*)(NativePtr));
        }
    }
}
