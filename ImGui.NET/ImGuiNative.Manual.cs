using SharpDX;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ImGuiNET
{
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
        public static extern void ImGuiPlatformIO_SetCallback(int callback, IntPtr funcptr);
    }
}
