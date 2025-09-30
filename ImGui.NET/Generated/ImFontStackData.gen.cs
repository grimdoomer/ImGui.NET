using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFontStackData
    {
        public ImFont* Font;
        public float FontSizeBeforeScaling;
        public float FontSizeAfterScaling;
    }
    public unsafe partial struct ImFontStackDataPtr
    {
        public ImFontStackData* NativePtr { get; }
        public ImFontStackDataPtr(ImFontStackData* nativePtr) => NativePtr = nativePtr;
        public ImFontStackDataPtr(IntPtr nativePtr) => NativePtr = (ImFontStackData*)nativePtr;
        public static implicit operator ImFontStackDataPtr(ImFontStackData* nativePtr) => new ImFontStackDataPtr(nativePtr);
        public static implicit operator ImFontStackData* (ImFontStackDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImFontStackDataPtr(IntPtr nativePtr) => new ImFontStackDataPtr(nativePtr);
        public ImFontPtr Font => new ImFontPtr(NativePtr->Font);
        public ref float FontSizeBeforeScaling => ref Unsafe.AsRef<float>(&NativePtr->FontSizeBeforeScaling);
        public ref float FontSizeAfterScaling => ref Unsafe.AsRef<float>(&NativePtr->FontSizeAfterScaling);
    }
}
