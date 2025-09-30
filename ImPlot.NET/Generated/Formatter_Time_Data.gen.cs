using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct Formatter_Time_Data
    {
        public ImPlotTime Time;
        public ImPlotDateTimeSpec Spec;
        public ImPlotFormatter UserFormatter;
        public void* UserFormatterData;
    }
    public unsafe partial struct Formatter_Time_DataPtr
    {
        public Formatter_Time_Data* NativePtr { get; }
        public Formatter_Time_DataPtr(Formatter_Time_Data* nativePtr) => NativePtr = nativePtr;
        public Formatter_Time_DataPtr(IntPtr nativePtr) => NativePtr = (Formatter_Time_Data*)nativePtr;
        public static implicit operator Formatter_Time_DataPtr(Formatter_Time_Data* nativePtr) => new Formatter_Time_DataPtr(nativePtr);
        public static implicit operator Formatter_Time_Data* (Formatter_Time_DataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator Formatter_Time_DataPtr(IntPtr nativePtr) => new Formatter_Time_DataPtr(nativePtr);
        public ref ImPlotTime Time => ref Unsafe.AsRef<ImPlotTime>(&NativePtr->Time);
        public ref ImPlotDateTimeSpec Spec => ref Unsafe.AsRef<ImPlotDateTimeSpec>(&NativePtr->Spec);
        public ref ImPlotFormatter UserFormatter => ref Unsafe.AsRef<ImPlotFormatter>(&NativePtr->UserFormatter);
        public IntPtr UserFormatterData { get => (IntPtr)NativePtr->UserFormatterData; set => NativePtr->UserFormatterData = (void*)value; }
    }
}
