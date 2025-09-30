using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiDataTypeStorage
    {
        public fixed byte Data[8];
    }
    public unsafe partial struct ImGuiDataTypeStoragePtr
    {
        public ImGuiDataTypeStorage* NativePtr { get; }
        public ImGuiDataTypeStoragePtr(ImGuiDataTypeStorage* nativePtr) => NativePtr = nativePtr;
        public ImGuiDataTypeStoragePtr(IntPtr nativePtr) => NativePtr = (ImGuiDataTypeStorage*)nativePtr;
        public static implicit operator ImGuiDataTypeStoragePtr(ImGuiDataTypeStorage* nativePtr) => new ImGuiDataTypeStoragePtr(nativePtr);
        public static implicit operator ImGuiDataTypeStorage* (ImGuiDataTypeStoragePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiDataTypeStoragePtr(IntPtr nativePtr) => new ImGuiDataTypeStoragePtr(nativePtr);
        public RangeAccessor<byte> Data => new RangeAccessor<byte>(NativePtr->Data, 8);
    }
}
