using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotContext
    {
        public ImPool Plots;
        public ImPool Subplots;
        public ImPlotPlot* CurrentPlot;
        public ImPlotSubplot* CurrentSubplot;
        public ImPlotItemGroup* CurrentItems;
        public ImPlotItem* CurrentItem;
        public ImPlotItem* PreviousItem;
        public ImPlotTicker CTicker;
        public ImPlotAnnotationCollection Annotations;
        public ImPlotTagCollection Tags;
        public ImPlotStyle Style;
        public ImVector ColorModifiers;
        public ImVector StyleModifiers;
        public ImPlotColormapData ColormapData;
        public ImVector ColormapModifiers;
        public Time Tm;
        public ImVector TempDouble1;
        public ImVector TempDouble2;
        public ImVector TempInt1;
        public int DigitalPlotItemCnt;
        public int DigitalPlotOffset;
        public ImPlotNextPlotData NextPlotData;
        public ImPlotNextItemData NextItemData;
        public ImPlotInputMap InputMap;
        public byte OpenContextThisFrame;
        public ImGuiTextBuffer MousePosStringBuilder;
        public ImPlotItemGroup* SortItems;
        public ImPool AlignmentData;
        public ImPlotAlignmentData* CurrentAlignmentH;
        public ImPlotAlignmentData* CurrentAlignmentV;
    }
    public unsafe partial struct ImPlotContextPtr
    {
        public ImPlotContext* NativePtr { get; }
        public ImPlotContextPtr(ImPlotContext* nativePtr) => NativePtr = nativePtr;
        public ImPlotContextPtr(IntPtr nativePtr) => NativePtr = (ImPlotContext*)nativePtr;
        public static implicit operator ImPlotContextPtr(ImPlotContext* nativePtr) => new ImPlotContextPtr(nativePtr);
        public static implicit operator ImPlotContext* (ImPlotContextPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotContextPtr(IntPtr nativePtr) => new ImPlotContextPtr(nativePtr);
        public ImPool<ImPlotPlotPtr> Plots => new ImPool<ImPlotPlotPtr>(NativePtr->Plots);
        public ImPool<ImPlotSubplotPtr> Subplots => new ImPool<ImPlotSubplotPtr>(NativePtr->Subplots);
        public ImPlotPlotPtr CurrentPlot => new ImPlotPlotPtr(NativePtr->CurrentPlot);
        public ImPlotSubplotPtr CurrentSubplot => new ImPlotSubplotPtr(NativePtr->CurrentSubplot);
        public ImPlotItemGroupPtr CurrentItems => new ImPlotItemGroupPtr(NativePtr->CurrentItems);
        public ImPlotItemPtr CurrentItem => new ImPlotItemPtr(NativePtr->CurrentItem);
        public ImPlotItemPtr PreviousItem => new ImPlotItemPtr(NativePtr->PreviousItem);
        public ref ImPlotTicker CTicker => ref Unsafe.AsRef<ImPlotTicker>(&NativePtr->CTicker);
        public ref ImPlotAnnotationCollection Annotations => ref Unsafe.AsRef<ImPlotAnnotationCollection>(&NativePtr->Annotations);
        public ref ImPlotTagCollection Tags => ref Unsafe.AsRef<ImPlotTagCollection>(&NativePtr->Tags);
        public ref ImPlotStyle Style => ref Unsafe.AsRef<ImPlotStyle>(&NativePtr->Style);
        public ImPtrVector<ImGuiColorModPtr> ColorModifiers => new ImPtrVector<ImGuiColorModPtr>(NativePtr->ColorModifiers, Unsafe.SizeOf<ImGuiColorMod>());
        public ImPtrVector<ImGuiStyleModPtr> StyleModifiers => new ImPtrVector<ImGuiStyleModPtr>(NativePtr->StyleModifiers, Unsafe.SizeOf<ImGuiStyleMod>());
        public ref ImPlotColormapData ColormapData => ref Unsafe.AsRef<ImPlotColormapData>(&NativePtr->ColormapData);
        public ImVector<ImPlotColormap> ColormapModifiers => new ImVector<ImPlotColormap>(NativePtr->ColormapModifiers);
        public ref Time Tm => ref Unsafe.AsRef<Time>(&NativePtr->Tm);
        public ImVector<double> TempDouble1 => new ImVector<double>(NativePtr->TempDouble1);
        public ImVector<double> TempDouble2 => new ImVector<double>(NativePtr->TempDouble2);
        public ImVector<int> TempInt1 => new ImVector<int>(NativePtr->TempInt1);
        public ref int DigitalPlotItemCnt => ref Unsafe.AsRef<int>(&NativePtr->DigitalPlotItemCnt);
        public ref int DigitalPlotOffset => ref Unsafe.AsRef<int>(&NativePtr->DigitalPlotOffset);
        public ref ImPlotNextPlotData NextPlotData => ref Unsafe.AsRef<ImPlotNextPlotData>(&NativePtr->NextPlotData);
        public ref ImPlotNextItemData NextItemData => ref Unsafe.AsRef<ImPlotNextItemData>(&NativePtr->NextItemData);
        public ref ImPlotInputMap InputMap => ref Unsafe.AsRef<ImPlotInputMap>(&NativePtr->InputMap);
        public ref bool OpenContextThisFrame => ref Unsafe.AsRef<bool>(&NativePtr->OpenContextThisFrame);
        public ref ImGuiTextBuffer MousePosStringBuilder => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->MousePosStringBuilder);
        public ImPlotItemGroupPtr SortItems => new ImPlotItemGroupPtr(NativePtr->SortItems);
        public ImPool<ImPlotAlignmentDataPtr> AlignmentData => new ImPool<ImPlotAlignmentDataPtr>(NativePtr->AlignmentData);
        public ImPlotAlignmentDataPtr CurrentAlignmentH => new ImPlotAlignmentDataPtr(NativePtr->CurrentAlignmentH);
        public ImPlotAlignmentDataPtr CurrentAlignmentV => new ImPlotAlignmentDataPtr(NativePtr->CurrentAlignmentV);
    }
}
