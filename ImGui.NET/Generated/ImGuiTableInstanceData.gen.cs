using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTableInstanceData
    {
        public float LastOuterHeight;
        public float LastFirstRowHeight;
    }
    public unsafe partial struct ImGuiTableInstanceDataPtr
    {
        public ImGuiTableInstanceData* NativePtr { get; }
        public ImGuiTableInstanceDataPtr(ImGuiTableInstanceData* nativePtr) => NativePtr = nativePtr;
        public ImGuiTableInstanceDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableInstanceData*)nativePtr;
        public static implicit operator ImGuiTableInstanceDataPtr(ImGuiTableInstanceData* nativePtr) => new ImGuiTableInstanceDataPtr(nativePtr);
        public static implicit operator ImGuiTableInstanceData* (ImGuiTableInstanceDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTableInstanceDataPtr(IntPtr nativePtr) => new ImGuiTableInstanceDataPtr(nativePtr);
        public ref float LastOuterHeight => ref Unsafe.AsRef<float>(&NativePtr->LastOuterHeight);
        public ref float LastFirstRowHeight => ref Unsafe.AsRef<float>(&NativePtr->LastFirstRowHeight);
        public void Destroy()
        {
            ImGuiNative.ImGuiTableInstanceData_destroy((ImGuiTableInstanceData*)(NativePtr));
        }
    }
}
