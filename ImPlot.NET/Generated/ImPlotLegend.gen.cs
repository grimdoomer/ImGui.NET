using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotLegend
    {
        public ImPlotLegendFlags Flags;
        public ImPlotLegendFlags PreviousFlags;
        public ImPlotLocation Location;
        public ImPlotLocation PreviousLocation;
        public Vector2 Scroll;
        public ImVector Indices;
        public ImGuiTextBuffer Labels;
        public ImRect Rect;
        public ImRect RectClamped;
        public byte Hovered;
        public byte Held;
        public byte CanGoInside;
    }
    public unsafe partial struct ImPlotLegendPtr
    {
        public ImPlotLegend* NativePtr { get; }
        public ImPlotLegendPtr(ImPlotLegend* nativePtr) => NativePtr = nativePtr;
        public ImPlotLegendPtr(IntPtr nativePtr) => NativePtr = (ImPlotLegend*)nativePtr;
        public static implicit operator ImPlotLegendPtr(ImPlotLegend* nativePtr) => new ImPlotLegendPtr(nativePtr);
        public static implicit operator ImPlotLegend* (ImPlotLegendPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotLegendPtr(IntPtr nativePtr) => new ImPlotLegendPtr(nativePtr);
        public ref ImPlotLegendFlags Flags => ref Unsafe.AsRef<ImPlotLegendFlags>(&NativePtr->Flags);
        public ref ImPlotLegendFlags PreviousFlags => ref Unsafe.AsRef<ImPlotLegendFlags>(&NativePtr->PreviousFlags);
        public ref ImPlotLocation Location => ref Unsafe.AsRef<ImPlotLocation>(&NativePtr->Location);
        public ref ImPlotLocation PreviousLocation => ref Unsafe.AsRef<ImPlotLocation>(&NativePtr->PreviousLocation);
        public ref Vector2 Scroll => ref Unsafe.AsRef<Vector2>(&NativePtr->Scroll);
        public ImVector<int> Indices => new ImVector<int>(NativePtr->Indices);
        public ref ImGuiTextBuffer Labels => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->Labels);
        public ref ImRect Rect => ref Unsafe.AsRef<ImRect>(&NativePtr->Rect);
        public ref ImRect RectClamped => ref Unsafe.AsRef<ImRect>(&NativePtr->RectClamped);
        public ref bool Hovered => ref Unsafe.AsRef<bool>(&NativePtr->Hovered);
        public ref bool Held => ref Unsafe.AsRef<bool>(&NativePtr->Held);
        public ref bool CanGoInside => ref Unsafe.AsRef<bool>(&NativePtr->CanGoInside);
        public void Destroy()
        {
            ImPlotNative.ImPlotLegend_destroy((ImPlotLegend*)(NativePtr));
        }
        public void Reset()
        {
            ImPlotNative.ImPlotLegend_Reset((ImPlotLegend*)(NativePtr));
        }
    }
}
