using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotDateTimeSpec
    {
        public ImPlotDateFmt Date;
        public ImPlotTimeFmt Time;
        public byte UseISO8601;
        public byte Use24HourClock;
    }
    public unsafe partial struct ImPlotDateTimeSpecPtr
    {
        public ImPlotDateTimeSpec* NativePtr { get; }
        public ImPlotDateTimeSpecPtr(ImPlotDateTimeSpec* nativePtr) => NativePtr = nativePtr;
        public ImPlotDateTimeSpecPtr(IntPtr nativePtr) => NativePtr = (ImPlotDateTimeSpec*)nativePtr;
        public static implicit operator ImPlotDateTimeSpecPtr(ImPlotDateTimeSpec* nativePtr) => new ImPlotDateTimeSpecPtr(nativePtr);
        public static implicit operator ImPlotDateTimeSpec* (ImPlotDateTimeSpecPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotDateTimeSpecPtr(IntPtr nativePtr) => new ImPlotDateTimeSpecPtr(nativePtr);
        public ref ImPlotDateFmt Date => ref Unsafe.AsRef<ImPlotDateFmt>(&NativePtr->Date);
        public ref ImPlotTimeFmt Time => ref Unsafe.AsRef<ImPlotTimeFmt>(&NativePtr->Time);
        public ref bool UseISO8601 => ref Unsafe.AsRef<bool>(&NativePtr->UseISO8601);
        public ref bool Use24HourClock => ref Unsafe.AsRef<bool>(&NativePtr->Use24HourClock);
        public void Destroy()
        {
            ImPlotNative.ImPlotDateTimeSpec_destroy((ImPlotDateTimeSpec*)(NativePtr));
        }
    }
}
