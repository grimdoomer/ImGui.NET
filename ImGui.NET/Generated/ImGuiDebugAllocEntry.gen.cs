using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiDebugAllocEntry
    {
        public int FrameCount;
        public short AllocCount;
        public short FreeCount;
    }
    public unsafe partial struct ImGuiDebugAllocEntryPtr
    {
        public ImGuiDebugAllocEntry* NativePtr { get; }
        public ImGuiDebugAllocEntryPtr(ImGuiDebugAllocEntry* nativePtr) => NativePtr = nativePtr;
        public ImGuiDebugAllocEntryPtr(IntPtr nativePtr) => NativePtr = (ImGuiDebugAllocEntry*)nativePtr;
        public static implicit operator ImGuiDebugAllocEntryPtr(ImGuiDebugAllocEntry* nativePtr) => new ImGuiDebugAllocEntryPtr(nativePtr);
        public static implicit operator ImGuiDebugAllocEntry* (ImGuiDebugAllocEntryPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiDebugAllocEntryPtr(IntPtr nativePtr) => new ImGuiDebugAllocEntryPtr(nativePtr);
        public ref int FrameCount => ref Unsafe.AsRef<int>(&NativePtr->FrameCount);
        public ref short AllocCount => ref Unsafe.AsRef<short>(&NativePtr->AllocCount);
        public ref short FreeCount => ref Unsafe.AsRef<short>(&NativePtr->FreeCount);
    }
}
