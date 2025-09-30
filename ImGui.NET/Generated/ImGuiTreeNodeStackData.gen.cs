using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTreeNodeStackData
    {
        public uint ID;
        public ImGuiTreeNodeFlags TreeFlags;
        public ImGuiItemFlags ItemFlags;
        public ImRect NavRect;
        public float DrawLinesX1;
        public float DrawLinesToNodesY2;
        public sbyte DrawLinesTableColumn;
    }
    public unsafe partial struct ImGuiTreeNodeStackDataPtr
    {
        public ImGuiTreeNodeStackData* NativePtr { get; }
        public ImGuiTreeNodeStackDataPtr(ImGuiTreeNodeStackData* nativePtr) => NativePtr = nativePtr;
        public ImGuiTreeNodeStackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiTreeNodeStackData*)nativePtr;
        public static implicit operator ImGuiTreeNodeStackDataPtr(ImGuiTreeNodeStackData* nativePtr) => new ImGuiTreeNodeStackDataPtr(nativePtr);
        public static implicit operator ImGuiTreeNodeStackData* (ImGuiTreeNodeStackDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTreeNodeStackDataPtr(IntPtr nativePtr) => new ImGuiTreeNodeStackDataPtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref ImGuiTreeNodeFlags TreeFlags => ref Unsafe.AsRef<ImGuiTreeNodeFlags>(&NativePtr->TreeFlags);
        public ref ImGuiItemFlags ItemFlags => ref Unsafe.AsRef<ImGuiItemFlags>(&NativePtr->ItemFlags);
        public ref ImRect NavRect => ref Unsafe.AsRef<ImRect>(&NativePtr->NavRect);
        public ref float DrawLinesX1 => ref Unsafe.AsRef<float>(&NativePtr->DrawLinesX1);
        public ref float DrawLinesToNodesY2 => ref Unsafe.AsRef<float>(&NativePtr->DrawLinesToNodesY2);
        public ref sbyte DrawLinesTableColumn => ref Unsafe.AsRef<sbyte>(&NativePtr->DrawLinesTableColumn);
    }
}
