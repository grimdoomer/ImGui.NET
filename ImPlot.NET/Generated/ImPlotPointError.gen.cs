using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotPointError
    {
        public double X;
        public double Y;
        public double Neg;
        public double Pos;
    }
    public unsafe partial struct ImPlotPointErrorPtr
    {
        public ImPlotPointError* NativePtr { get; }
        public ImPlotPointErrorPtr(ImPlotPointError* nativePtr) => NativePtr = nativePtr;
        public ImPlotPointErrorPtr(IntPtr nativePtr) => NativePtr = (ImPlotPointError*)nativePtr;
        public static implicit operator ImPlotPointErrorPtr(ImPlotPointError* nativePtr) => new ImPlotPointErrorPtr(nativePtr);
        public static implicit operator ImPlotPointError* (ImPlotPointErrorPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotPointErrorPtr(IntPtr nativePtr) => new ImPlotPointErrorPtr(nativePtr);
        public ref double X => ref Unsafe.AsRef<double>(&NativePtr->X);
        public ref double Y => ref Unsafe.AsRef<double>(&NativePtr->Y);
        public ref double Neg => ref Unsafe.AsRef<double>(&NativePtr->Neg);
        public ref double Pos => ref Unsafe.AsRef<double>(&NativePtr->Pos);
        public void Destroy()
        {
            ImPlotNative.ImPlotPointError_destroy((ImPlotPointError*)(NativePtr));
        }
    }
}
