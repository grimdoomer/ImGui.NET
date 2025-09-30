using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotAnnotation
    {
        public Vector2 Pos;
        public Vector2 Offset;
        public uint ColorBg;
        public uint ColorFg;
        public int TextOffset;
        public byte Clamp;
    }
    public unsafe partial struct ImPlotAnnotationPtr
    {
        public ImPlotAnnotation* NativePtr { get; }
        public ImPlotAnnotationPtr(ImPlotAnnotation* nativePtr) => NativePtr = nativePtr;
        public ImPlotAnnotationPtr(IntPtr nativePtr) => NativePtr = (ImPlotAnnotation*)nativePtr;
        public static implicit operator ImPlotAnnotationPtr(ImPlotAnnotation* nativePtr) => new ImPlotAnnotationPtr(nativePtr);
        public static implicit operator ImPlotAnnotation* (ImPlotAnnotationPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotAnnotationPtr(IntPtr nativePtr) => new ImPlotAnnotationPtr(nativePtr);
        public ref Vector2 Pos => ref Unsafe.AsRef<Vector2>(&NativePtr->Pos);
        public ref Vector2 Offset => ref Unsafe.AsRef<Vector2>(&NativePtr->Offset);
        public ref uint ColorBg => ref Unsafe.AsRef<uint>(&NativePtr->ColorBg);
        public ref uint ColorFg => ref Unsafe.AsRef<uint>(&NativePtr->ColorFg);
        public ref int TextOffset => ref Unsafe.AsRef<int>(&NativePtr->TextOffset);
        public ref bool Clamp => ref Unsafe.AsRef<bool>(&NativePtr->Clamp);
        public void Destroy()
        {
            ImPlotNative.ImPlotAnnotation_destroy((ImPlotAnnotation*)(NativePtr));
        }
    }
}
