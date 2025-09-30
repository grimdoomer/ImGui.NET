using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiDebugAllocInfo
    {
        public int TotalAllocCount;
        public int TotalFreeCount;
        public short LastEntriesIdx;
        public ImGuiDebugAllocEntry LastEntriesBuf_0;
        public ImGuiDebugAllocEntry LastEntriesBuf_1;
        public ImGuiDebugAllocEntry LastEntriesBuf_2;
        public ImGuiDebugAllocEntry LastEntriesBuf_3;
        public ImGuiDebugAllocEntry LastEntriesBuf_4;
        public ImGuiDebugAllocEntry LastEntriesBuf_5;
    }
    public unsafe partial struct ImGuiDebugAllocInfoPtr
    {
        public ImGuiDebugAllocInfo* NativePtr { get; }
        public ImGuiDebugAllocInfoPtr(ImGuiDebugAllocInfo* nativePtr) => NativePtr = nativePtr;
        public ImGuiDebugAllocInfoPtr(IntPtr nativePtr) => NativePtr = (ImGuiDebugAllocInfo*)nativePtr;
        public static implicit operator ImGuiDebugAllocInfoPtr(ImGuiDebugAllocInfo* nativePtr) => new ImGuiDebugAllocInfoPtr(nativePtr);
        public static implicit operator ImGuiDebugAllocInfo* (ImGuiDebugAllocInfoPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiDebugAllocInfoPtr(IntPtr nativePtr) => new ImGuiDebugAllocInfoPtr(nativePtr);
        public ref int TotalAllocCount => ref Unsafe.AsRef<int>(&NativePtr->TotalAllocCount);
        public ref int TotalFreeCount => ref Unsafe.AsRef<int>(&NativePtr->TotalFreeCount);
        public ref short LastEntriesIdx => ref Unsafe.AsRef<short>(&NativePtr->LastEntriesIdx);
        public RangeAccessor<ImGuiDebugAllocEntry> LastEntriesBuf => new RangeAccessor<ImGuiDebugAllocEntry>(&NativePtr->LastEntriesBuf_0, 6);
        public void Destroy()
        {
            ImGuiNative.ImGuiDebugAllocInfo_destroy((ImGuiDebugAllocInfo*)(NativePtr));
        }
    }
}
