using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotSubplot
    {
        public uint ID;
        public ImPlotSubplotFlags Flags;
        public ImPlotSubplotFlags PreviousFlags;
        public ImPlotItemGroup Items;
        public int Rows;
        public int Cols;
        public int CurrentIdx;
        public ImRect FrameRect;
        public ImRect GridRect;
        public Vector2 CellSize;
        public ImVector RowAlignmentData;
        public ImVector ColAlignmentData;
        public ImVector RowRatios;
        public ImVector ColRatios;
        public ImVector RowLinkData;
        public ImVector ColLinkData;
        public fixed float TempSizes[2];
        public byte FrameHovered;
        public byte HasTitle;
    }
    public unsafe partial struct ImPlotSubplotPtr
    {
        public ImPlotSubplot* NativePtr { get; }
        public ImPlotSubplotPtr(ImPlotSubplot* nativePtr) => NativePtr = nativePtr;
        public ImPlotSubplotPtr(IntPtr nativePtr) => NativePtr = (ImPlotSubplot*)nativePtr;
        public static implicit operator ImPlotSubplotPtr(ImPlotSubplot* nativePtr) => new ImPlotSubplotPtr(nativePtr);
        public static implicit operator ImPlotSubplot* (ImPlotSubplotPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotSubplotPtr(IntPtr nativePtr) => new ImPlotSubplotPtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref ImPlotSubplotFlags Flags => ref Unsafe.AsRef<ImPlotSubplotFlags>(&NativePtr->Flags);
        public ref ImPlotSubplotFlags PreviousFlags => ref Unsafe.AsRef<ImPlotSubplotFlags>(&NativePtr->PreviousFlags);
        public ref ImPlotItemGroup Items => ref Unsafe.AsRef<ImPlotItemGroup>(&NativePtr->Items);
        public ref int Rows => ref Unsafe.AsRef<int>(&NativePtr->Rows);
        public ref int Cols => ref Unsafe.AsRef<int>(&NativePtr->Cols);
        public ref int CurrentIdx => ref Unsafe.AsRef<int>(&NativePtr->CurrentIdx);
        public ref ImRect FrameRect => ref Unsafe.AsRef<ImRect>(&NativePtr->FrameRect);
        public ref ImRect GridRect => ref Unsafe.AsRef<ImRect>(&NativePtr->GridRect);
        public ref Vector2 CellSize => ref Unsafe.AsRef<Vector2>(&NativePtr->CellSize);
        public ImPtrVector<ImPlotAlignmentDataPtr> RowAlignmentData => new ImPtrVector<ImPlotAlignmentDataPtr>(NativePtr->RowAlignmentData, Unsafe.SizeOf<ImPlotAlignmentData>());
        public ImPtrVector<ImPlotAlignmentDataPtr> ColAlignmentData => new ImPtrVector<ImPlotAlignmentDataPtr>(NativePtr->ColAlignmentData, Unsafe.SizeOf<ImPlotAlignmentData>());
        public ImVector<float> RowRatios => new ImVector<float>(NativePtr->RowRatios);
        public ImVector<float> ColRatios => new ImVector<float>(NativePtr->ColRatios);
        public ImPtrVector<ImPlotRangePtr> RowLinkData => new ImPtrVector<ImPlotRangePtr>(NativePtr->RowLinkData, Unsafe.SizeOf<ImPlotRange>());
        public ImPtrVector<ImPlotRangePtr> ColLinkData => new ImPtrVector<ImPlotRangePtr>(NativePtr->ColLinkData, Unsafe.SizeOf<ImPlotRange>());
        public RangeAccessor<float> TempSizes => new RangeAccessor<float>(NativePtr->TempSizes, 2);
        public ref bool FrameHovered => ref Unsafe.AsRef<bool>(&NativePtr->FrameHovered);
        public ref bool HasTitle => ref Unsafe.AsRef<bool>(&NativePtr->HasTitle);
        public void Destroy()
        {
            ImPlotNative.ImPlotSubplot_destroy((ImPlotSubplot*)(NativePtr));
        }
    }
}
