using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFontAtlasRectEntry
    {
        public int TargetIndex;
        public uint Generation;
        public uint IsUsed;
    }
    public unsafe partial struct ImFontAtlasRectEntryPtr
    {
        public ImFontAtlasRectEntry* NativePtr { get; }
        public ImFontAtlasRectEntryPtr(ImFontAtlasRectEntry* nativePtr) => NativePtr = nativePtr;
        public ImFontAtlasRectEntryPtr(IntPtr nativePtr) => NativePtr = (ImFontAtlasRectEntry*)nativePtr;
        public static implicit operator ImFontAtlasRectEntryPtr(ImFontAtlasRectEntry* nativePtr) => new ImFontAtlasRectEntryPtr(nativePtr);
        public static implicit operator ImFontAtlasRectEntry* (ImFontAtlasRectEntryPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImFontAtlasRectEntryPtr(IntPtr nativePtr) => new ImFontAtlasRectEntryPtr(nativePtr);
        public ref int TargetIndex => ref Unsafe.AsRef<int>(&NativePtr->TargetIndex);
        public ref uint Generation => ref Unsafe.AsRef<uint>(&NativePtr->Generation);
        public ref uint IsUsed => ref Unsafe.AsRef<uint>(&NativePtr->IsUsed);
    }
}
