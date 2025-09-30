using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiWindowStackData
    {
        public ImGuiWindow* Window;
        public ImGuiLastItemData ParentLastItemDataBackup;
        public ImGuiErrorRecoveryState StackSizesInBegin;
        public byte DisabledOverrideReenable;
        public float DisabledOverrideReenableAlphaBackup;
    }
    public unsafe partial struct ImGuiWindowStackDataPtr
    {
        public ImGuiWindowStackData* NativePtr { get; }
        public ImGuiWindowStackDataPtr(ImGuiWindowStackData* nativePtr) => NativePtr = nativePtr;
        public ImGuiWindowStackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiWindowStackData*)nativePtr;
        public static implicit operator ImGuiWindowStackDataPtr(ImGuiWindowStackData* nativePtr) => new ImGuiWindowStackDataPtr(nativePtr);
        public static implicit operator ImGuiWindowStackData* (ImGuiWindowStackDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiWindowStackDataPtr(IntPtr nativePtr) => new ImGuiWindowStackDataPtr(nativePtr);
        public ImGuiWindowPtr Window => new ImGuiWindowPtr(NativePtr->Window);
        public ref ImGuiLastItemData ParentLastItemDataBackup => ref Unsafe.AsRef<ImGuiLastItemData>(&NativePtr->ParentLastItemDataBackup);
        public ref ImGuiErrorRecoveryState StackSizesInBegin => ref Unsafe.AsRef<ImGuiErrorRecoveryState>(&NativePtr->StackSizesInBegin);
        public ref bool DisabledOverrideReenable => ref Unsafe.AsRef<bool>(&NativePtr->DisabledOverrideReenable);
        public ref float DisabledOverrideReenableAlphaBackup => ref Unsafe.AsRef<float>(&NativePtr->DisabledOverrideReenableAlphaBackup);
    }
}
