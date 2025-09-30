using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTableHeaderData
    {
        public sbyte Index;
        public uint TextColor;
        public uint BgColor0;
        public uint BgColor1;
    }
    public unsafe partial struct ImGuiTableHeaderDataPtr
    {
        public ImGuiTableHeaderData* NativePtr { get; }
        public ImGuiTableHeaderDataPtr(ImGuiTableHeaderData* nativePtr) => NativePtr = nativePtr;
        public ImGuiTableHeaderDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableHeaderData*)nativePtr;
        public static implicit operator ImGuiTableHeaderDataPtr(ImGuiTableHeaderData* nativePtr) => new ImGuiTableHeaderDataPtr(nativePtr);
        public static implicit operator ImGuiTableHeaderData* (ImGuiTableHeaderDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTableHeaderDataPtr(IntPtr nativePtr) => new ImGuiTableHeaderDataPtr(nativePtr);
        public ref sbyte Index => ref Unsafe.AsRef<sbyte>(&NativePtr->Index);
        public ref uint TextColor => ref Unsafe.AsRef<uint>(&NativePtr->TextColor);
        public ref uint BgColor0 => ref Unsafe.AsRef<uint>(&NativePtr->BgColor0);
        public ref uint BgColor1 => ref Unsafe.AsRef<uint>(&NativePtr->BgColor1);
    }
}
