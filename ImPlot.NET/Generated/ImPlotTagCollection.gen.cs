using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotTagCollection
    {
        public ImVector Tags;
        public ImGuiTextBuffer TextBuffer;
        public int Size;
    }
    public unsafe partial struct ImPlotTagCollectionPtr
    {
        public ImPlotTagCollection* NativePtr { get; }
        public ImPlotTagCollectionPtr(ImPlotTagCollection* nativePtr) => NativePtr = nativePtr;
        public ImPlotTagCollectionPtr(IntPtr nativePtr) => NativePtr = (ImPlotTagCollection*)nativePtr;
        public static implicit operator ImPlotTagCollectionPtr(ImPlotTagCollection* nativePtr) => new ImPlotTagCollectionPtr(nativePtr);
        public static implicit operator ImPlotTagCollection* (ImPlotTagCollectionPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotTagCollectionPtr(IntPtr nativePtr) => new ImPlotTagCollectionPtr(nativePtr);
        public ImPtrVector<ImPlotTagPtr> Tags => new ImPtrVector<ImPlotTagPtr>(NativePtr->Tags, Unsafe.SizeOf<ImPlotTag>());
        public ref ImGuiTextBuffer TextBuffer => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->TextBuffer);
        public ref int Size => ref Unsafe.AsRef<int>(&NativePtr->Size);
        public void Append(ImAxis axis, double value, uint bg, uint fg, string fmt)
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > NativeUtilities.StackAllocationSizeLimit)
                {
                    native_fmt = NativeUtilities.AllocateNativeBuffer(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = NativeUtilities.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImPlotNative.ImPlotTagCollection_Append((ImPlotTagCollection*)(NativePtr), axis, value, bg, fg, native_fmt);
            if (fmt_byteCount > NativeUtilities.StackAllocationSizeLimit)
            {
                NativeUtilities.FreeNativeBuffer(native_fmt);
            }
        }
        public void Destroy()
        {
            ImPlotNative.ImPlotTagCollection_destroy((ImPlotTagCollection*)(NativePtr));
        }
        public string GetText(int idx)
        {
            byte* ret = ImPlotNative.ImPlotTagCollection_GetText((ImPlotTagCollection*)(NativePtr), idx);
            return NativeUtilities.StringFromPtr(ret);
        }
        public void Reset()
        {
            ImPlotNative.ImPlotTagCollection_Reset((ImPlotTagCollection*)(NativePtr));
        }
    }
}
