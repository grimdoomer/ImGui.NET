using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawDataBuilder
    {
        public ImVector* Layers_0;
        public ImVector* Layers_1;
        public ImVector LayerData1;
    }
    public unsafe partial struct ImDrawDataBuilderPtr
    {
        public ImDrawDataBuilder* NativePtr { get; }
        public ImDrawDataBuilderPtr(ImDrawDataBuilder* nativePtr) => NativePtr = nativePtr;
        public ImDrawDataBuilderPtr(IntPtr nativePtr) => NativePtr = (ImDrawDataBuilder*)nativePtr;
        public static implicit operator ImDrawDataBuilderPtr(ImDrawDataBuilder* nativePtr) => new ImDrawDataBuilderPtr(nativePtr);
        public static implicit operator ImDrawDataBuilder* (ImDrawDataBuilderPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawDataBuilderPtr(IntPtr nativePtr) => new ImDrawDataBuilderPtr(nativePtr);
        public RangeAccessor<IntPtr> Layers => new RangeAccessor<IntPtr>(&NativePtr->Layers_0, 2);
        public ImVector<ImDrawListPtr> LayerData1 => new ImVector<ImDrawListPtr>(NativePtr->LayerData1);
        public void Destroy()
        {
            ImGuiNative.ImDrawDataBuilder_destroy((ImDrawDataBuilder*)(NativePtr));
        }
    }
}
