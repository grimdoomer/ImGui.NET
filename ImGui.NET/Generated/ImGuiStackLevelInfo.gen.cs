using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiStackLevelInfo
    {
        public uint ID;
        public sbyte QueryFrameCount;
        public byte QuerySuccess;
        public sbyte DataType;
        public int DescOffset;
    }
    public unsafe partial struct ImGuiStackLevelInfoPtr
    {
        public ImGuiStackLevelInfo* NativePtr { get; }
        public ImGuiStackLevelInfoPtr(ImGuiStackLevelInfo* nativePtr) => NativePtr = nativePtr;
        public ImGuiStackLevelInfoPtr(IntPtr nativePtr) => NativePtr = (ImGuiStackLevelInfo*)nativePtr;
        public static implicit operator ImGuiStackLevelInfoPtr(ImGuiStackLevelInfo* nativePtr) => new ImGuiStackLevelInfoPtr(nativePtr);
        public static implicit operator ImGuiStackLevelInfo* (ImGuiStackLevelInfoPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiStackLevelInfoPtr(IntPtr nativePtr) => new ImGuiStackLevelInfoPtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref sbyte QueryFrameCount => ref Unsafe.AsRef<sbyte>(&NativePtr->QueryFrameCount);
        public ref bool QuerySuccess => ref Unsafe.AsRef<bool>(&NativePtr->QuerySuccess);
        public ref sbyte DataType => ref Unsafe.AsRef<sbyte>(&NativePtr->DataType);
        public ref int DescOffset => ref Unsafe.AsRef<int>(&NativePtr->DescOffset);
        public void Destroy()
        {
            ImGuiNative.ImGuiStackLevelInfo_destroy((ImGuiStackLevelInfo*)(NativePtr));
        }
    }
}
