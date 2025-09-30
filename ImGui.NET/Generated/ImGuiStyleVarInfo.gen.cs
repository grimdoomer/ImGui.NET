using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiStyleVarInfo
    {
        public uint Count;
        public ImGuiDataType DataType;
        public uint Offset;
    }
    public unsafe partial struct ImGuiStyleVarInfoPtr
    {
        public ImGuiStyleVarInfo* NativePtr { get; }
        public ImGuiStyleVarInfoPtr(ImGuiStyleVarInfo* nativePtr) => NativePtr = nativePtr;
        public ImGuiStyleVarInfoPtr(IntPtr nativePtr) => NativePtr = (ImGuiStyleVarInfo*)nativePtr;
        public static implicit operator ImGuiStyleVarInfoPtr(ImGuiStyleVarInfo* nativePtr) => new ImGuiStyleVarInfoPtr(nativePtr);
        public static implicit operator ImGuiStyleVarInfo* (ImGuiStyleVarInfoPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiStyleVarInfoPtr(IntPtr nativePtr) => new ImGuiStyleVarInfoPtr(nativePtr);
        public ref uint Count => ref Unsafe.AsRef<uint>(&NativePtr->Count);
        public ref ImGuiDataType DataType => ref Unsafe.AsRef<ImGuiDataType>(&NativePtr->DataType);
        public ref uint Offset => ref Unsafe.AsRef<uint>(&NativePtr->Offset);
        public IntPtr GetVarPtr(IntPtr parent)
        {
            void* native_parent = (void*)parent.ToPointer();
            void* ret = ImGuiNative.ImGuiStyleVarInfo_GetVarPtr((ImGuiStyleVarInfo*)(NativePtr), native_parent);
            return (IntPtr)ret;
        }
    }
}
