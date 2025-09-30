using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotItem
    {
        public uint ID;
        public uint Color;
        public ImRect LegendHoverRect;
        public int NameOffset;
        public byte Show;
        public byte LegendHovered;
        public byte SeenThisFrame;
    }
    public unsafe partial struct ImPlotItemPtr
    {
        public ImPlotItem* NativePtr { get; }
        public ImPlotItemPtr(ImPlotItem* nativePtr) => NativePtr = nativePtr;
        public ImPlotItemPtr(IntPtr nativePtr) => NativePtr = (ImPlotItem*)nativePtr;
        public static implicit operator ImPlotItemPtr(ImPlotItem* nativePtr) => new ImPlotItemPtr(nativePtr);
        public static implicit operator ImPlotItem* (ImPlotItemPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotItemPtr(IntPtr nativePtr) => new ImPlotItemPtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref uint Color => ref Unsafe.AsRef<uint>(&NativePtr->Color);
        public ref ImRect LegendHoverRect => ref Unsafe.AsRef<ImRect>(&NativePtr->LegendHoverRect);
        public ref int NameOffset => ref Unsafe.AsRef<int>(&NativePtr->NameOffset);
        public ref bool Show => ref Unsafe.AsRef<bool>(&NativePtr->Show);
        public ref bool LegendHovered => ref Unsafe.AsRef<bool>(&NativePtr->LegendHovered);
        public ref bool SeenThisFrame => ref Unsafe.AsRef<bool>(&NativePtr->SeenThisFrame);
        public void Destroy()
        {
            ImPlotNative.ImPlotItem_destroy((ImPlotItem*)(NativePtr));
        }
    }
}
