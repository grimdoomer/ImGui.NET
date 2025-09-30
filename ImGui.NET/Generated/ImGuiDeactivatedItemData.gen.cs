using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiDeactivatedItemData
    {
        public uint ID;
        public int ElapseFrame;
        public byte HasBeenEditedBefore;
        public byte IsAlive;
    }
    public unsafe partial struct ImGuiDeactivatedItemDataPtr
    {
        public ImGuiDeactivatedItemData* NativePtr { get; }
        public ImGuiDeactivatedItemDataPtr(ImGuiDeactivatedItemData* nativePtr) => NativePtr = nativePtr;
        public ImGuiDeactivatedItemDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiDeactivatedItemData*)nativePtr;
        public static implicit operator ImGuiDeactivatedItemDataPtr(ImGuiDeactivatedItemData* nativePtr) => new ImGuiDeactivatedItemDataPtr(nativePtr);
        public static implicit operator ImGuiDeactivatedItemData* (ImGuiDeactivatedItemDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiDeactivatedItemDataPtr(IntPtr nativePtr) => new ImGuiDeactivatedItemDataPtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref int ElapseFrame => ref Unsafe.AsRef<int>(&NativePtr->ElapseFrame);
        public ref bool HasBeenEditedBefore => ref Unsafe.AsRef<bool>(&NativePtr->HasBeenEditedBefore);
        public ref bool IsAlive => ref Unsafe.AsRef<bool>(&NativePtr->IsAlive);
    }
}
