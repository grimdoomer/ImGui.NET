using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct stbrp_context_opaque
    {
        public fixed byte data[80];
    }
    public unsafe partial struct stbrp_context_opaquePtr
    {
        public stbrp_context_opaque* NativePtr { get; }
        public stbrp_context_opaquePtr(stbrp_context_opaque* nativePtr) => NativePtr = nativePtr;
        public stbrp_context_opaquePtr(IntPtr nativePtr) => NativePtr = (stbrp_context_opaque*)nativePtr;
        public static implicit operator stbrp_context_opaquePtr(stbrp_context_opaque* nativePtr) => new stbrp_context_opaquePtr(nativePtr);
        public static implicit operator stbrp_context_opaque* (stbrp_context_opaquePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator stbrp_context_opaquePtr(IntPtr nativePtr) => new stbrp_context_opaquePtr(nativePtr);
        public RangeAccessor<byte> data => new RangeAccessor<byte>(NativePtr->data, 80);
    }
}
