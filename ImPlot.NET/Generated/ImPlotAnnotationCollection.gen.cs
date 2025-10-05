using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotAnnotationCollection
    {
        public ImVector Annotations;
        public ImGuiTextBuffer TextBuffer;
        public int Size;
    }
    public unsafe partial struct ImPlotAnnotationCollectionPtr
    {
        public ImPlotAnnotationCollection* NativePtr { get; }
        public ImPlotAnnotationCollectionPtr(ImPlotAnnotationCollection* nativePtr) => NativePtr = nativePtr;
        public ImPlotAnnotationCollectionPtr(IntPtr nativePtr) => NativePtr = (ImPlotAnnotationCollection*)nativePtr;
        public static implicit operator ImPlotAnnotationCollectionPtr(ImPlotAnnotationCollection* nativePtr) => new ImPlotAnnotationCollectionPtr(nativePtr);
        public static implicit operator ImPlotAnnotationCollection* (ImPlotAnnotationCollectionPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotAnnotationCollectionPtr(IntPtr nativePtr) => new ImPlotAnnotationCollectionPtr(nativePtr);
        public ImPtrVector<ImPlotAnnotationPtr> Annotations => new ImPtrVector<ImPlotAnnotationPtr>(NativePtr->Annotations, Unsafe.SizeOf<ImPlotAnnotation>());
        public ref ImGuiTextBuffer TextBuffer => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->TextBuffer);
        public ref int Size => ref Unsafe.AsRef<int>(&NativePtr->Size);
        public void Append(Vector2 pos, Vector2 off, uint bg, uint fg, bool clamp, string fmt)
        {
            byte native_clamp = clamp ? (byte)1 : (byte)0;
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
            ImPlotNative.ImPlotAnnotationCollection_Append((ImPlotAnnotationCollection*)(NativePtr), pos, off, bg, fg, native_clamp, native_fmt);
            if (fmt_byteCount > NativeUtilities.StackAllocationSizeLimit)
            {
                NativeUtilities.FreeNativeBuffer(native_fmt);
            }
        }
        public void Destroy()
        {
            ImPlotNative.ImPlotAnnotationCollection_destroy((ImPlotAnnotationCollection*)(NativePtr));
        }
        public string GetText(int idx)
        {
            byte* ret = ImPlotNative.ImPlotAnnotationCollection_GetText((ImPlotAnnotationCollection*)(NativePtr), idx);
            return NativeUtilities.StringFromPtr(ret);
        }
        public void Reset()
        {
            ImPlotNative.ImPlotAnnotationCollection_Reset((ImPlotAnnotationCollection*)(NativePtr));
        }
    }
}
