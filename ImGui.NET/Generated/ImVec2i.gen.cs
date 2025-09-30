using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImVec2i
    {
        public int x;
        public int y;
    }
    public unsafe partial struct ImVec2iPtr
    {
        public ImVec2i* NativePtr { get; }
        public ImVec2iPtr(ImVec2i* nativePtr) => NativePtr = nativePtr;
        public ImVec2iPtr(IntPtr nativePtr) => NativePtr = (ImVec2i*)nativePtr;
        public static implicit operator ImVec2iPtr(ImVec2i* nativePtr) => new ImVec2iPtr(nativePtr);
        public static implicit operator ImVec2i* (ImVec2iPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImVec2iPtr(IntPtr nativePtr) => new ImVec2iPtr(nativePtr);
        public ref int x => ref Unsafe.AsRef<int>(&NativePtr->x);
        public ref int y => ref Unsafe.AsRef<int>(&NativePtr->y);
        public void Destroy()
        {
            ImGuiNative.ImVec2i_destroy((ImVec2i*)(NativePtr));
        }
    }
}
