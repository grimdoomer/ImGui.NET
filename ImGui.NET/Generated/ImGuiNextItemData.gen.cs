using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiNextItemData
    {
        public ImGuiNextItemDataFlags HasFlags;
        public ImGuiItemFlags ItemFlags;
        public uint FocusScopeId;
        public long SelectionUserData;
        public float Width;
        public int Shortcut;
        public ImGuiInputFlags ShortcutFlags;
        public byte OpenVal;
        public byte OpenCond;
        public ImGuiDataTypeStorage RefVal;
        public uint StorageId;
    }
    public unsafe partial struct ImGuiNextItemDataPtr
    {
        public ImGuiNextItemData* NativePtr { get; }
        public ImGuiNextItemDataPtr(ImGuiNextItemData* nativePtr) => NativePtr = nativePtr;
        public ImGuiNextItemDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiNextItemData*)nativePtr;
        public static implicit operator ImGuiNextItemDataPtr(ImGuiNextItemData* nativePtr) => new ImGuiNextItemDataPtr(nativePtr);
        public static implicit operator ImGuiNextItemData* (ImGuiNextItemDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiNextItemDataPtr(IntPtr nativePtr) => new ImGuiNextItemDataPtr(nativePtr);
        public ref ImGuiNextItemDataFlags HasFlags => ref Unsafe.AsRef<ImGuiNextItemDataFlags>(&NativePtr->HasFlags);
        public ref ImGuiItemFlags ItemFlags => ref Unsafe.AsRef<ImGuiItemFlags>(&NativePtr->ItemFlags);
        public ref uint FocusScopeId => ref Unsafe.AsRef<uint>(&NativePtr->FocusScopeId);
        public ref long SelectionUserData => ref Unsafe.AsRef<long>(&NativePtr->SelectionUserData);
        public ref float Width => ref Unsafe.AsRef<float>(&NativePtr->Width);
        public ref int Shortcut => ref Unsafe.AsRef<int>(&NativePtr->Shortcut);
        public ref ImGuiInputFlags ShortcutFlags => ref Unsafe.AsRef<ImGuiInputFlags>(&NativePtr->ShortcutFlags);
        public ref bool OpenVal => ref Unsafe.AsRef<bool>(&NativePtr->OpenVal);
        public ref byte OpenCond => ref Unsafe.AsRef<byte>(&NativePtr->OpenCond);
        public ref ImGuiDataTypeStorage RefVal => ref Unsafe.AsRef<ImGuiDataTypeStorage>(&NativePtr->RefVal);
        public ref uint StorageId => ref Unsafe.AsRef<uint>(&NativePtr->StorageId);
        public void ClearFlags()
        {
            ImGuiNative.ImGuiNextItemData_ClearFlags((ImGuiNextItemData*)(NativePtr));
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiNextItemData_destroy((ImGuiNextItemData*)(NativePtr));
        }
    }
}
