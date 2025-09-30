using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotNextPlotData
    {
        public ImPlotCond RangeCond_0;
        public ImPlotCond RangeCond_1;
        public ImPlotCond RangeCond_2;
        public ImPlotCond RangeCond_3;
        public ImPlotCond RangeCond_4;
        public ImPlotCond RangeCond_5;
        public ImPlotRange Range_0;
        public ImPlotRange Range_1;
        public ImPlotRange Range_2;
        public ImPlotRange Range_3;
        public ImPlotRange Range_4;
        public ImPlotRange Range_5;
        public fixed byte HasRange[6];
        public fixed byte Fit[6];
        public double* LinkedMin_0;
        public double* LinkedMin_1;
        public double* LinkedMin_2;
        public double* LinkedMin_3;
        public double* LinkedMin_4;
        public double* LinkedMin_5;
        public double* LinkedMax_0;
        public double* LinkedMax_1;
        public double* LinkedMax_2;
        public double* LinkedMax_3;
        public double* LinkedMax_4;
        public double* LinkedMax_5;
    }
    public unsafe partial struct ImPlotNextPlotDataPtr
    {
        public ImPlotNextPlotData* NativePtr { get; }
        public ImPlotNextPlotDataPtr(ImPlotNextPlotData* nativePtr) => NativePtr = nativePtr;
        public ImPlotNextPlotDataPtr(IntPtr nativePtr) => NativePtr = (ImPlotNextPlotData*)nativePtr;
        public static implicit operator ImPlotNextPlotDataPtr(ImPlotNextPlotData* nativePtr) => new ImPlotNextPlotDataPtr(nativePtr);
        public static implicit operator ImPlotNextPlotData* (ImPlotNextPlotDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotNextPlotDataPtr(IntPtr nativePtr) => new ImPlotNextPlotDataPtr(nativePtr);
        public RangeAccessor<ImPlotCond> RangeCond => new RangeAccessor<ImPlotCond>(&NativePtr->RangeCond_0, 6);
        public RangeAccessor<ImPlotRange> Range => new RangeAccessor<ImPlotRange>(&NativePtr->Range_0, 6);
        public RangeAccessor<bool> HasRange => new RangeAccessor<bool>(NativePtr->HasRange, 6);
        public RangeAccessor<bool> Fit => new RangeAccessor<bool>(NativePtr->Fit, 6);
        public RangeAccessor<IntPtr> LinkedMin => new RangeAccessor<IntPtr>(&NativePtr->LinkedMin_0, 6);
        public RangeAccessor<IntPtr> LinkedMax => new RangeAccessor<IntPtr>(&NativePtr->LinkedMax_0, 6);
        public void Destroy()
        {
            ImPlotNative.ImPlotNextPlotData_destroy((ImPlotNextPlotData*)(NativePtr));
        }
        public void Reset()
        {
            ImPlotNative.ImPlotNextPlotData_Reset((ImPlotNextPlotData*)(NativePtr));
        }
    }
}
