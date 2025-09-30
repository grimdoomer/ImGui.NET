using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotAxis
    {
        public uint ID;
        public ImPlotAxisFlags Flags;
        public ImPlotAxisFlags PreviousFlags;
        public ImPlotRange Range;
        public ImPlotCond RangeCond;
        public ImPlotScale Scale;
        public ImPlotRange FitExtents;
        public ImPlotAxis* OrthoAxis;
        public ImPlotRange ConstraintRange;
        public ImPlotRange ConstraintZoom;
        public ImPlotTicker Ticker;
        public ImPlotFormatter Formatter;
        public void* FormatterData;
        public fixed byte FormatSpec[16];
        public ImPlotLocator Locator;
        public double* LinkedMin;
        public double* LinkedMax;
        public int PickerLevel;
        public ImPlotTime PickerTimeMin;
        public ImPlotTime PickerTimeMax;
        public ImPlotTransform TransformForward;
        public ImPlotTransform TransformInverse;
        public void* TransformData;
        public float PixelMin;
        public float PixelMax;
        public double ScaleMin;
        public double ScaleMax;
        public double ScaleToPixel;
        public float Datum1;
        public float Datum2;
        public ImRect HoverRect;
        public int LabelOffset;
        public uint ColorMaj;
        public uint ColorMin;
        public uint ColorTick;
        public uint ColorTxt;
        public uint ColorBg;
        public uint ColorHov;
        public uint ColorAct;
        public uint ColorHiLi;
        public byte Enabled;
        public byte Vertical;
        public byte FitThisFrame;
        public byte HasRange;
        public byte HasFormatSpec;
        public byte ShowDefaultTicks;
        public byte Hovered;
        public byte Held;
    }
    public unsafe partial struct ImPlotAxisPtr
    {
        public ImPlotAxis* NativePtr { get; }
        public ImPlotAxisPtr(ImPlotAxis* nativePtr) => NativePtr = nativePtr;
        public ImPlotAxisPtr(IntPtr nativePtr) => NativePtr = (ImPlotAxis*)nativePtr;
        public static implicit operator ImPlotAxisPtr(ImPlotAxis* nativePtr) => new ImPlotAxisPtr(nativePtr);
        public static implicit operator ImPlotAxis* (ImPlotAxisPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotAxisPtr(IntPtr nativePtr) => new ImPlotAxisPtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref ImPlotAxisFlags Flags => ref Unsafe.AsRef<ImPlotAxisFlags>(&NativePtr->Flags);
        public ref ImPlotAxisFlags PreviousFlags => ref Unsafe.AsRef<ImPlotAxisFlags>(&NativePtr->PreviousFlags);
        public ref ImPlotRange Range => ref Unsafe.AsRef<ImPlotRange>(&NativePtr->Range);
        public ref ImPlotCond RangeCond => ref Unsafe.AsRef<ImPlotCond>(&NativePtr->RangeCond);
        public ref ImPlotScale Scale => ref Unsafe.AsRef<ImPlotScale>(&NativePtr->Scale);
        public ref ImPlotRange FitExtents => ref Unsafe.AsRef<ImPlotRange>(&NativePtr->FitExtents);
        public ImPlotAxisPtr OrthoAxis => new ImPlotAxisPtr(NativePtr->OrthoAxis);
        public ref ImPlotRange ConstraintRange => ref Unsafe.AsRef<ImPlotRange>(&NativePtr->ConstraintRange);
        public ref ImPlotRange ConstraintZoom => ref Unsafe.AsRef<ImPlotRange>(&NativePtr->ConstraintZoom);
        public ref ImPlotTicker Ticker => ref Unsafe.AsRef<ImPlotTicker>(&NativePtr->Ticker);
        public ref ImPlotFormatter Formatter => ref Unsafe.AsRef<ImPlotFormatter>(&NativePtr->Formatter);
        public IntPtr FormatterData { get => (IntPtr)NativePtr->FormatterData; set => NativePtr->FormatterData = (void*)value; }
        public RangeAccessor<byte> FormatSpec => new RangeAccessor<byte>(NativePtr->FormatSpec, 16);
        public ref ImPlotLocator Locator => ref Unsafe.AsRef<ImPlotLocator>(&NativePtr->Locator);
        public IntPtr LinkedMin { get => (IntPtr)NativePtr->LinkedMin; set => NativePtr->LinkedMin = (double*)value; }
        public IntPtr LinkedMax { get => (IntPtr)NativePtr->LinkedMax; set => NativePtr->LinkedMax = (double*)value; }
        public ref int PickerLevel => ref Unsafe.AsRef<int>(&NativePtr->PickerLevel);
        public ref ImPlotTime PickerTimeMin => ref Unsafe.AsRef<ImPlotTime>(&NativePtr->PickerTimeMin);
        public ref ImPlotTime PickerTimeMax => ref Unsafe.AsRef<ImPlotTime>(&NativePtr->PickerTimeMax);
        public ref ImPlotTransform TransformForward => ref Unsafe.AsRef<ImPlotTransform>(&NativePtr->TransformForward);
        public ref ImPlotTransform TransformInverse => ref Unsafe.AsRef<ImPlotTransform>(&NativePtr->TransformInverse);
        public IntPtr TransformData { get => (IntPtr)NativePtr->TransformData; set => NativePtr->TransformData = (void*)value; }
        public ref float PixelMin => ref Unsafe.AsRef<float>(&NativePtr->PixelMin);
        public ref float PixelMax => ref Unsafe.AsRef<float>(&NativePtr->PixelMax);
        public ref double ScaleMin => ref Unsafe.AsRef<double>(&NativePtr->ScaleMin);
        public ref double ScaleMax => ref Unsafe.AsRef<double>(&NativePtr->ScaleMax);
        public ref double ScaleToPixel => ref Unsafe.AsRef<double>(&NativePtr->ScaleToPixel);
        public ref float Datum1 => ref Unsafe.AsRef<float>(&NativePtr->Datum1);
        public ref float Datum2 => ref Unsafe.AsRef<float>(&NativePtr->Datum2);
        public ref ImRect HoverRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HoverRect);
        public ref int LabelOffset => ref Unsafe.AsRef<int>(&NativePtr->LabelOffset);
        public ref uint ColorMaj => ref Unsafe.AsRef<uint>(&NativePtr->ColorMaj);
        public ref uint ColorMin => ref Unsafe.AsRef<uint>(&NativePtr->ColorMin);
        public ref uint ColorTick => ref Unsafe.AsRef<uint>(&NativePtr->ColorTick);
        public ref uint ColorTxt => ref Unsafe.AsRef<uint>(&NativePtr->ColorTxt);
        public ref uint ColorBg => ref Unsafe.AsRef<uint>(&NativePtr->ColorBg);
        public ref uint ColorHov => ref Unsafe.AsRef<uint>(&NativePtr->ColorHov);
        public ref uint ColorAct => ref Unsafe.AsRef<uint>(&NativePtr->ColorAct);
        public ref uint ColorHiLi => ref Unsafe.AsRef<uint>(&NativePtr->ColorHiLi);
        public ref bool Enabled => ref Unsafe.AsRef<bool>(&NativePtr->Enabled);
        public ref bool Vertical => ref Unsafe.AsRef<bool>(&NativePtr->Vertical);
        public ref bool FitThisFrame => ref Unsafe.AsRef<bool>(&NativePtr->FitThisFrame);
        public ref bool HasRange => ref Unsafe.AsRef<bool>(&NativePtr->HasRange);
        public ref bool HasFormatSpec => ref Unsafe.AsRef<bool>(&NativePtr->HasFormatSpec);
        public ref bool ShowDefaultTicks => ref Unsafe.AsRef<bool>(&NativePtr->ShowDefaultTicks);
        public ref bool Hovered => ref Unsafe.AsRef<bool>(&NativePtr->Hovered);
        public ref bool Held => ref Unsafe.AsRef<bool>(&NativePtr->Held);
        public void ApplyFit(float padding)
        {
            ImPlotNative.ImPlotAxis_ApplyFit((ImPlotAxis*)(NativePtr), padding);
        }
        public bool CanInitFit()
        {
            byte ret = ImPlotNative.ImPlotAxis_CanInitFit((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public void Constrain()
        {
            ImPlotNative.ImPlotAxis_Constrain((ImPlotAxis*)(NativePtr));
        }
        public void Destroy()
        {
            ImPlotNative.ImPlotAxis_destroy((ImPlotAxis*)(NativePtr));
        }
        public void ExtendFit(double v)
        {
            ImPlotNative.ImPlotAxis_ExtendFit((ImPlotAxis*)(NativePtr), v);
        }
        public void ExtendFitWith(ImPlotAxisPtr alt, double v, double v_alt)
        {
            ImPlotAxis* native_alt = alt.NativePtr;
            ImPlotNative.ImPlotAxis_ExtendFitWith((ImPlotAxis*)(NativePtr), native_alt, v, v_alt);
        }
        public double GetAspect()
        {
            double ret = ImPlotNative.ImPlotAxis_GetAspect((ImPlotAxis*)(NativePtr));
            return ret;
        }
        public bool HasGridLines()
        {
            byte ret = ImPlotNative.ImPlotAxis_HasGridLines((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool HasLabel()
        {
            byte ret = ImPlotNative.ImPlotAxis_HasLabel((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool HasMenus()
        {
            byte ret = ImPlotNative.ImPlotAxis_HasMenus((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool HasTickLabels()
        {
            byte ret = ImPlotNative.ImPlotAxis_HasTickLabels((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool HasTickMarks()
        {
            byte ret = ImPlotNative.ImPlotAxis_HasTickMarks((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool IsAutoFitting()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsAutoFitting((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool IsForeground()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsForeground((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool IsInputLocked()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsInputLocked((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool IsInputLockedMax()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsInputLockedMax((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool IsInputLockedMin()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsInputLockedMin((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool IsInverted()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsInverted((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool IsLocked()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsLocked((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool IsLockedMax()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsLockedMax((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool IsLockedMin()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsLockedMin((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool IsOpposite()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsOpposite((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool IsPanLocked(bool increasing)
        {
            byte native_increasing = increasing ? (byte)1 : (byte)0;
            byte ret = ImPlotNative.ImPlotAxis_IsPanLocked((ImPlotAxis*)(NativePtr), native_increasing);
            return ret != 0;
        }
        public bool IsRangeLocked()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsRangeLocked((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public float PixelSize()
        {
            float ret = ImPlotNative.ImPlotAxis_PixelSize((ImPlotAxis*)(NativePtr));
            return ret;
        }
        public double PixelsToPlot(float pix)
        {
            double ret = ImPlotNative.ImPlotAxis_PixelsToPlot((ImPlotAxis*)(NativePtr), pix);
            return ret;
        }
        public float PlotToPixels(double plt)
        {
            float ret = ImPlotNative.ImPlotAxis_PlotToPixels((ImPlotAxis*)(NativePtr), plt);
            return ret;
        }
        public void PullLinks()
        {
            ImPlotNative.ImPlotAxis_PullLinks((ImPlotAxis*)(NativePtr));
        }
        public void PushLinks()
        {
            ImPlotNative.ImPlotAxis_PushLinks((ImPlotAxis*)(NativePtr));
        }
        public void Reset()
        {
            ImPlotNative.ImPlotAxis_Reset((ImPlotAxis*)(NativePtr));
        }
        public void SetAspect(double unit_per_pix)
        {
            ImPlotNative.ImPlotAxis_SetAspect((ImPlotAxis*)(NativePtr), unit_per_pix);
        }
        public bool SetMax(double _max)
        {
            byte force = 0;
            byte ret = ImPlotNative.ImPlotAxis_SetMax((ImPlotAxis*)(NativePtr), _max, force);
            return ret != 0;
        }
        public bool SetMax(double _max, bool force)
        {
            byte native_force = force ? (byte)1 : (byte)0;
            byte ret = ImPlotNative.ImPlotAxis_SetMax((ImPlotAxis*)(NativePtr), _max, native_force);
            return ret != 0;
        }
        public bool SetMin(double _min)
        {
            byte force = 0;
            byte ret = ImPlotNative.ImPlotAxis_SetMin((ImPlotAxis*)(NativePtr), _min, force);
            return ret != 0;
        }
        public bool SetMin(double _min, bool force)
        {
            byte native_force = force ? (byte)1 : (byte)0;
            byte ret = ImPlotNative.ImPlotAxis_SetMin((ImPlotAxis*)(NativePtr), _min, native_force);
            return ret != 0;
        }
        public void SetRange(double v1, double v2)
        {
            ImPlotNative.ImPlotAxis_SetRange_double((ImPlotAxis*)(NativePtr), v1, v2);
        }
        public void SetRange(ImPlotRange range)
        {
            ImPlotNative.ImPlotAxis_SetRange_PlotRange((ImPlotAxis*)(NativePtr), range);
        }
        public void UpdateTransformCache()
        {
            ImPlotNative.ImPlotAxis_UpdateTransformCache((ImPlotAxis*)(NativePtr));
        }
        public bool WillRender()
        {
            byte ret = ImPlotNative.ImPlotAxis_WillRender((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
    }
}
