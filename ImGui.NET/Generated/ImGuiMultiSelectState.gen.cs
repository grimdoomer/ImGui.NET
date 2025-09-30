using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiMultiSelectState
    {
        public ImGuiWindow* Window;
        public uint ID;
        public int LastFrameActive;
        public int LastSelectionSize;
        public sbyte RangeSelected;
        public sbyte NavIdSelected;
        public long RangeSrcItem;
        public long NavIdItem;
    }
    public unsafe partial struct ImGuiMultiSelectStatePtr
    {
        public ImGuiMultiSelectState* NativePtr { get; }
        public ImGuiMultiSelectStatePtr(ImGuiMultiSelectState* nativePtr) => NativePtr = nativePtr;
        public ImGuiMultiSelectStatePtr(IntPtr nativePtr) => NativePtr = (ImGuiMultiSelectState*)nativePtr;
        public static implicit operator ImGuiMultiSelectStatePtr(ImGuiMultiSelectState* nativePtr) => new ImGuiMultiSelectStatePtr(nativePtr);
        public static implicit operator ImGuiMultiSelectState* (ImGuiMultiSelectStatePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiMultiSelectStatePtr(IntPtr nativePtr) => new ImGuiMultiSelectStatePtr(nativePtr);
        public ImGuiWindowPtr Window => new ImGuiWindowPtr(NativePtr->Window);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref int LastFrameActive => ref Unsafe.AsRef<int>(&NativePtr->LastFrameActive);
        public ref int LastSelectionSize => ref Unsafe.AsRef<int>(&NativePtr->LastSelectionSize);
        public ref sbyte RangeSelected => ref Unsafe.AsRef<sbyte>(&NativePtr->RangeSelected);
        public ref sbyte NavIdSelected => ref Unsafe.AsRef<sbyte>(&NativePtr->NavIdSelected);
        public ref long RangeSrcItem => ref Unsafe.AsRef<long>(&NativePtr->RangeSrcItem);
        public ref long NavIdItem => ref Unsafe.AsRef<long>(&NativePtr->NavIdItem);
        public void Destroy()
        {
            ImGuiNative.ImGuiMultiSelectState_destroy((ImGuiMultiSelectState*)(NativePtr));
        }
    }
}
