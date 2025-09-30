using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotTick
    {
        public double PlotPos;
        public float PixelPos;
        public Vector2 LabelSize;
        public int TextOffset;
        public byte Major;
        public byte ShowLabel;
        public int Level;
        public int Idx;
    }
    public unsafe partial struct ImPlotTickPtr
    {
        public ImPlotTick* NativePtr { get; }
        public ImPlotTickPtr(ImPlotTick* nativePtr) => NativePtr = nativePtr;
        public ImPlotTickPtr(IntPtr nativePtr) => NativePtr = (ImPlotTick*)nativePtr;
        public static implicit operator ImPlotTickPtr(ImPlotTick* nativePtr) => new ImPlotTickPtr(nativePtr);
        public static implicit operator ImPlotTick* (ImPlotTickPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotTickPtr(IntPtr nativePtr) => new ImPlotTickPtr(nativePtr);
        public ref double PlotPos => ref Unsafe.AsRef<double>(&NativePtr->PlotPos);
        public ref float PixelPos => ref Unsafe.AsRef<float>(&NativePtr->PixelPos);
        public ref Vector2 LabelSize => ref Unsafe.AsRef<Vector2>(&NativePtr->LabelSize);
        public ref int TextOffset => ref Unsafe.AsRef<int>(&NativePtr->TextOffset);
        public ref bool Major => ref Unsafe.AsRef<bool>(&NativePtr->Major);
        public ref bool ShowLabel => ref Unsafe.AsRef<bool>(&NativePtr->ShowLabel);
        public ref int Level => ref Unsafe.AsRef<int>(&NativePtr->Level);
        public ref int Idx => ref Unsafe.AsRef<int>(&NativePtr->Idx);
        public void Destroy()
        {
            ImPlotNative.ImPlotTick_destroy((ImPlotTick*)(NativePtr));
        }
    }
}
