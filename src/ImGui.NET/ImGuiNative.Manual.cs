using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ImGuiNET
{
    public static unsafe partial class ImGuiNative
    {
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat2(byte* label, SharpDX.Vector2* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat3(byte* label, SharpDX.Vector3* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat4(byte* label, SharpDX.Vector4* v, byte* format, ImGuiInputTextFlags flags);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushItemFlag(ImGuiItemFlags option, bool enabled);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopItemFlag();

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollToBringRectIntoView();
    }
}
