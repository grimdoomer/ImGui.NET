using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotTag
    {
        public ImAxis Axis;
        public double Value;
        public uint ColorBg;
        public uint ColorFg;
        public int TextOffset;
    }
    public unsafe partial struct ImPlotTagPtr
    {
        public ImPlotTag* NativePtr { get; }
        public ImPlotTagPtr(ImPlotTag* nativePtr) => NativePtr = nativePtr;
        public ImPlotTagPtr(IntPtr nativePtr) => NativePtr = (ImPlotTag*)nativePtr;
        public static implicit operator ImPlotTagPtr(ImPlotTag* nativePtr) => new ImPlotTagPtr(nativePtr);
        public static implicit operator ImPlotTag* (ImPlotTagPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotTagPtr(IntPtr nativePtr) => new ImPlotTagPtr(nativePtr);
        public ref ImAxis Axis => ref Unsafe.AsRef<ImAxis>(&NativePtr->Axis);
        public ref double Value => ref Unsafe.AsRef<double>(&NativePtr->Value);
        public ref uint ColorBg => ref Unsafe.AsRef<uint>(&NativePtr->ColorBg);
        public ref uint ColorFg => ref Unsafe.AsRef<uint>(&NativePtr->ColorFg);
        public ref int TextOffset => ref Unsafe.AsRef<int>(&NativePtr->TextOffset);
    }
}
