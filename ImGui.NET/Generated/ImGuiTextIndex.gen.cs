using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTextIndex
    {
        public ImVector Offsets;
        public int EndOffset;
    }
    public unsafe partial struct ImGuiTextIndexPtr
    {
        public ImGuiTextIndex* NativePtr { get; }
        public ImGuiTextIndexPtr(ImGuiTextIndex* nativePtr) => NativePtr = nativePtr;
        public ImGuiTextIndexPtr(IntPtr nativePtr) => NativePtr = (ImGuiTextIndex*)nativePtr;
        public static implicit operator ImGuiTextIndexPtr(ImGuiTextIndex* nativePtr) => new ImGuiTextIndexPtr(nativePtr);
        public static implicit operator ImGuiTextIndex* (ImGuiTextIndexPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTextIndexPtr(IntPtr nativePtr) => new ImGuiTextIndexPtr(nativePtr);
        public ImVector<int> Offsets => new ImVector<int>(NativePtr->Offsets);
        public ref int EndOffset => ref Unsafe.AsRef<int>(&NativePtr->EndOffset);
        public void append(string @base, int old_size, int new_size)
        {
            byte* native_base;
            int @base_byteCount = 0;
            if (@base != null)
            {
                @base_byteCount = Encoding.UTF8.GetByteCount(@base);
                if (@base_byteCount > NativeUtilities.StackAllocationSizeLimit)
                {
                    native_base = NativeUtilities.AllocateNativeBuffer(@base_byteCount + 1);
                }
                else
                {
                    byte* native_base_stackBytes = stackalloc byte[@base_byteCount + 1];
                    native_base = native_base_stackBytes;
                }
                int native_base_offset = NativeUtilities.GetUtf8(@base, native_base, @base_byteCount);
                native_base[native_base_offset] = 0;
            }
            else { native_base = null; }
            ImGuiNative.ImGuiTextIndex_append((ImGuiTextIndex*)(NativePtr), native_base, old_size, new_size);
            if (@base_byteCount > NativeUtilities.StackAllocationSizeLimit)
            {
                NativeUtilities.FreeNativeBuffer(native_base);
            }
        }
        public void clear()
        {
            ImGuiNative.ImGuiTextIndex_clear((ImGuiTextIndex*)(NativePtr));
        }
        public string get_line_begin(string @base, int n)
        {
            byte* native_base;
            int @base_byteCount = 0;
            if (@base != null)
            {
                @base_byteCount = Encoding.UTF8.GetByteCount(@base);
                if (@base_byteCount > NativeUtilities.StackAllocationSizeLimit)
                {
                    native_base = NativeUtilities.AllocateNativeBuffer(@base_byteCount + 1);
                }
                else
                {
                    byte* native_base_stackBytes = stackalloc byte[@base_byteCount + 1];
                    native_base = native_base_stackBytes;
                }
                int native_base_offset = NativeUtilities.GetUtf8(@base, native_base, @base_byteCount);
                native_base[native_base_offset] = 0;
            }
            else { native_base = null; }
            byte* ret = ImGuiNative.ImGuiTextIndex_get_line_begin((ImGuiTextIndex*)(NativePtr), native_base, n);
            if (@base_byteCount > NativeUtilities.StackAllocationSizeLimit)
            {
                NativeUtilities.FreeNativeBuffer(native_base);
            }
            return NativeUtilities.StringFromPtr(ret);
        }
        public string get_line_end(string @base, int n)
        {
            byte* native_base;
            int @base_byteCount = 0;
            if (@base != null)
            {
                @base_byteCount = Encoding.UTF8.GetByteCount(@base);
                if (@base_byteCount > NativeUtilities.StackAllocationSizeLimit)
                {
                    native_base = NativeUtilities.AllocateNativeBuffer(@base_byteCount + 1);
                }
                else
                {
                    byte* native_base_stackBytes = stackalloc byte[@base_byteCount + 1];
                    native_base = native_base_stackBytes;
                }
                int native_base_offset = NativeUtilities.GetUtf8(@base, native_base, @base_byteCount);
                native_base[native_base_offset] = 0;
            }
            else { native_base = null; }
            byte* ret = ImGuiNative.ImGuiTextIndex_get_line_end((ImGuiTextIndex*)(NativePtr), native_base, n);
            if (@base_byteCount > NativeUtilities.StackAllocationSizeLimit)
            {
                NativeUtilities.FreeNativeBuffer(native_base);
            }
            return NativeUtilities.StringFromPtr(ret);
        }
        public int size()
        {
            int ret = ImGuiNative.ImGuiTextIndex_size((ImGuiTextIndex*)(NativePtr));
            return ret;
        }
    }
}
