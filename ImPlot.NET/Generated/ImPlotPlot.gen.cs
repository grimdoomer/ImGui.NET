using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotPlot
    {
        public uint ID;
        public ImPlotFlags Flags;
        public ImPlotFlags PreviousFlags;
        public ImPlotLocation MouseTextLocation;
        public ImPlotMouseTextFlags MouseTextFlags;
        public ImPlotAxis Axes_0;
        public ImPlotAxis Axes_1;
        public ImPlotAxis Axes_2;
        public ImPlotAxis Axes_3;
        public ImPlotAxis Axes_4;
        public ImPlotAxis Axes_5;
        public ImGuiTextBuffer TextBuffer;
        public ImPlotItemGroup Items;
        public ImAxis CurrentX;
        public ImAxis CurrentY;
        public ImRect FrameRect;
        public ImRect CanvasRect;
        public ImRect PlotRect;
        public ImRect AxesRect;
        public ImRect SelectRect;
        public Vector2 SelectStart;
        public int TitleOffset;
        public byte JustCreated;
        public byte Initialized;
        public byte SetupLocked;
        public byte FitThisFrame;
        public byte Hovered;
        public byte Held;
        public byte Selecting;
        public byte Selected;
        public byte ContextLocked;
    }
    public unsafe partial struct ImPlotPlotPtr
    {
        public ImPlotPlot* NativePtr { get; }
        public ImPlotPlotPtr(ImPlotPlot* nativePtr) => NativePtr = nativePtr;
        public ImPlotPlotPtr(IntPtr nativePtr) => NativePtr = (ImPlotPlot*)nativePtr;
        public static implicit operator ImPlotPlotPtr(ImPlotPlot* nativePtr) => new ImPlotPlotPtr(nativePtr);
        public static implicit operator ImPlotPlot* (ImPlotPlotPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotPlotPtr(IntPtr nativePtr) => new ImPlotPlotPtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref ImPlotFlags Flags => ref Unsafe.AsRef<ImPlotFlags>(&NativePtr->Flags);
        public ref ImPlotFlags PreviousFlags => ref Unsafe.AsRef<ImPlotFlags>(&NativePtr->PreviousFlags);
        public ref ImPlotLocation MouseTextLocation => ref Unsafe.AsRef<ImPlotLocation>(&NativePtr->MouseTextLocation);
        public ref ImPlotMouseTextFlags MouseTextFlags => ref Unsafe.AsRef<ImPlotMouseTextFlags>(&NativePtr->MouseTextFlags);
        public RangeAccessor<ImPlotAxis> Axes => new RangeAccessor<ImPlotAxis>(&NativePtr->Axes_0, 6);
        public ref ImGuiTextBuffer TextBuffer => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->TextBuffer);
        public ref ImPlotItemGroup Items => ref Unsafe.AsRef<ImPlotItemGroup>(&NativePtr->Items);
        public ref ImAxis CurrentX => ref Unsafe.AsRef<ImAxis>(&NativePtr->CurrentX);
        public ref ImAxis CurrentY => ref Unsafe.AsRef<ImAxis>(&NativePtr->CurrentY);
        public ref ImRect FrameRect => ref Unsafe.AsRef<ImRect>(&NativePtr->FrameRect);
        public ref ImRect CanvasRect => ref Unsafe.AsRef<ImRect>(&NativePtr->CanvasRect);
        public ref ImRect PlotRect => ref Unsafe.AsRef<ImRect>(&NativePtr->PlotRect);
        public ref ImRect AxesRect => ref Unsafe.AsRef<ImRect>(&NativePtr->AxesRect);
        public ref ImRect SelectRect => ref Unsafe.AsRef<ImRect>(&NativePtr->SelectRect);
        public ref Vector2 SelectStart => ref Unsafe.AsRef<Vector2>(&NativePtr->SelectStart);
        public ref int TitleOffset => ref Unsafe.AsRef<int>(&NativePtr->TitleOffset);
        public ref bool JustCreated => ref Unsafe.AsRef<bool>(&NativePtr->JustCreated);
        public ref bool Initialized => ref Unsafe.AsRef<bool>(&NativePtr->Initialized);
        public ref bool SetupLocked => ref Unsafe.AsRef<bool>(&NativePtr->SetupLocked);
        public ref bool FitThisFrame => ref Unsafe.AsRef<bool>(&NativePtr->FitThisFrame);
        public ref bool Hovered => ref Unsafe.AsRef<bool>(&NativePtr->Hovered);
        public ref bool Held => ref Unsafe.AsRef<bool>(&NativePtr->Held);
        public ref bool Selecting => ref Unsafe.AsRef<bool>(&NativePtr->Selecting);
        public ref bool Selected => ref Unsafe.AsRef<bool>(&NativePtr->Selected);
        public ref bool ContextLocked => ref Unsafe.AsRef<bool>(&NativePtr->ContextLocked);
        public void ClearTextBuffer()
        {
            ImPlotNative.ImPlotPlot_ClearTextBuffer((ImPlotPlot*)(NativePtr));
        }
        public void Destroy()
        {
            ImPlotNative.ImPlotPlot_destroy((ImPlotPlot*)(NativePtr));
        }
        public int EnabledAxesX()
        {
            int ret = ImPlotNative.ImPlotPlot_EnabledAxesX((ImPlotPlot*)(NativePtr));
            return ret;
        }
        public int EnabledAxesY()
        {
            int ret = ImPlotNative.ImPlotPlot_EnabledAxesY((ImPlotPlot*)(NativePtr));
            return ret;
        }
        public string GetAxisLabel(ImPlotAxis axis)
        {
            byte* ret = ImPlotNative.ImPlotPlot_GetAxisLabel((ImPlotPlot*)(NativePtr), axis);
            return NativeUtilities.StringFromPtr(ret);
        }
        public string GetTitle()
        {
            byte* ret = ImPlotNative.ImPlotPlot_GetTitle((ImPlotPlot*)(NativePtr));
            return NativeUtilities.StringFromPtr(ret);
        }
        public bool HasTitle()
        {
            byte ret = ImPlotNative.ImPlotPlot_HasTitle((ImPlotPlot*)(NativePtr));
            return ret != 0;
        }
        public bool IsInputLocked()
        {
            byte ret = ImPlotNative.ImPlotPlot_IsInputLocked((ImPlotPlot*)(NativePtr));
            return ret != 0;
        }
        public void SetAxisLabel(ImPlotAxisPtr axis, string label)
        {
            ImPlotAxis* native_axis = axis.NativePtr;
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > NativeUtilities.StackAllocationSizeLimit)
                {
                    native_label = NativeUtilities.AllocateNativeBuffer(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = NativeUtilities.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImPlotNative.ImPlotPlot_SetAxisLabel((ImPlotPlot*)(NativePtr), native_axis, native_label);
            if (label_byteCount > NativeUtilities.StackAllocationSizeLimit)
            {
                NativeUtilities.FreeNativeBuffer(native_label);
            }
        }
        public void SetTitle(string title)
        {
            byte* native_title;
            int title_byteCount = 0;
            if (title != null)
            {
                title_byteCount = Encoding.UTF8.GetByteCount(title);
                if (title_byteCount > NativeUtilities.StackAllocationSizeLimit)
                {
                    native_title = NativeUtilities.AllocateNativeBuffer(title_byteCount + 1);
                }
                else
                {
                    byte* native_title_stackBytes = stackalloc byte[title_byteCount + 1];
                    native_title = native_title_stackBytes;
                }
                int native_title_offset = NativeUtilities.GetUtf8(title, native_title, title_byteCount);
                native_title[native_title_offset] = 0;
            }
            else { native_title = null; }
            ImPlotNative.ImPlotPlot_SetTitle((ImPlotPlot*)(NativePtr), native_title);
            if (title_byteCount > NativeUtilities.StackAllocationSizeLimit)
            {
                NativeUtilities.FreeNativeBuffer(native_title);
            }
        }
        public ImPlotAxisPtr XAxis(int i)
        {
            ImPlotAxis* ret = ImPlotNative.ImPlotPlot_XAxis_Nil((ImPlotPlot*)(NativePtr), i);
            return new ImPlotAxisPtr(ret);
        }
        public ImPlotAxisPtr YAxis(int i)
        {
            ImPlotAxis* ret = ImPlotNative.ImPlotPlot_YAxis_Nil((ImPlotPlot*)(NativePtr), i);
            return new ImPlotAxisPtr(ret);
        }
    }
}
