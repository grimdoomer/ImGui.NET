using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotTicker
    {
        public ImVector Ticks;
        public ImGuiTextBuffer TextBuffer;
        public Vector2 MaxSize;
        public Vector2 LateSize;
        public int Levels;
    }
    public unsafe partial struct ImPlotTickerPtr
    {
        public ImPlotTicker* NativePtr { get; }
        public ImPlotTickerPtr(ImPlotTicker* nativePtr) => NativePtr = nativePtr;
        public ImPlotTickerPtr(IntPtr nativePtr) => NativePtr = (ImPlotTicker*)nativePtr;
        public static implicit operator ImPlotTickerPtr(ImPlotTicker* nativePtr) => new ImPlotTickerPtr(nativePtr);
        public static implicit operator ImPlotTicker* (ImPlotTickerPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotTickerPtr(IntPtr nativePtr) => new ImPlotTickerPtr(nativePtr);
        public ImPtrVector<ImPlotTickPtr> Ticks => new ImPtrVector<ImPlotTickPtr>(NativePtr->Ticks, Unsafe.SizeOf<ImPlotTick>());
        public ref ImGuiTextBuffer TextBuffer => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->TextBuffer);
        public ref Vector2 MaxSize => ref Unsafe.AsRef<Vector2>(&NativePtr->MaxSize);
        public ref Vector2 LateSize => ref Unsafe.AsRef<Vector2>(&NativePtr->LateSize);
        public ref int Levels => ref Unsafe.AsRef<int>(&NativePtr->Levels);
        public ImPlotTickPtr AddTick(double value, bool major, int level, bool show_label, string label)
        {
            byte native_major = major ? (byte)1 : (byte)0;
            byte native_show_label = show_label ? (byte)1 : (byte)0;
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
            ImPlotTick* ret = ImPlotNative.ImPlotTicker_AddTick_doubleStr((ImPlotTicker*)(NativePtr), value, native_major, level, native_show_label, native_label);
            if (label_byteCount > NativeUtilities.StackAllocationSizeLimit)
            {
                NativeUtilities.FreeNativeBuffer(native_label);
            }
            return new ImPlotTickPtr(ret);
        }
        public ImPlotTickPtr AddTick(double value, bool major, int level, bool show_label, IntPtr formatter, IntPtr data)
        {
            byte native_major = major ? (byte)1 : (byte)0;
            byte native_show_label = show_label ? (byte)1 : (byte)0;
            void* native_data = (void*)data.ToPointer();
            ImPlotTick* ret = ImPlotNative.ImPlotTicker_AddTick_doublePlotFormatter((ImPlotTicker*)(NativePtr), value, native_major, level, native_show_label, formatter, native_data);
            return new ImPlotTickPtr(ret);
        }
        public ImPlotTickPtr AddTick(ImPlotTick tick)
        {
            ImPlotTick* ret = ImPlotNative.ImPlotTicker_AddTick_PlotTick((ImPlotTicker*)(NativePtr), tick);
            return new ImPlotTickPtr(ret);
        }
        public void Destroy()
        {
            ImPlotNative.ImPlotTicker_destroy((ImPlotTicker*)(NativePtr));
        }
        public string GetText(int idx)
        {
            byte* ret = ImPlotNative.ImPlotTicker_GetText_Int((ImPlotTicker*)(NativePtr), idx);
            return NativeUtilities.StringFromPtr(ret);
        }
        public string GetText(ImPlotTick tick)
        {
            byte* ret = ImPlotNative.ImPlotTicker_GetText_PlotTick((ImPlotTicker*)(NativePtr), tick);
            return NativeUtilities.StringFromPtr(ret);
        }
        public void OverrideSizeLate(Vector2 size)
        {
            ImPlotNative.ImPlotTicker_OverrideSizeLate((ImPlotTicker*)(NativePtr), size);
        }
        public void Reset()
        {
            ImPlotNative.ImPlotTicker_Reset((ImPlotTicker*)(NativePtr));
        }
        public int TickCount()
        {
            int ret = ImPlotNative.ImPlotTicker_TickCount((ImPlotTicker*)(NativePtr));
            return ret;
        }
    }
}
