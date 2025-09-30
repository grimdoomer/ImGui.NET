using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiBoxSelectState
    {
        public uint ID;
        public byte IsActive;
        public byte IsStarting;
        public byte IsStartedFromVoid;
        public byte IsStartedSetNavIdOnce;
        public byte RequestClear;
        public int KeyMods;
        public Vector2 StartPosRel;
        public Vector2 EndPosRel;
        public Vector2 ScrollAccum;
        public ImGuiWindow* Window;
        public byte UnclipMode;
        public ImRect UnclipRect;
        public ImRect BoxSelectRectPrev;
        public ImRect BoxSelectRectCurr;
    }
    public unsafe partial struct ImGuiBoxSelectStatePtr
    {
        public ImGuiBoxSelectState* NativePtr { get; }
        public ImGuiBoxSelectStatePtr(ImGuiBoxSelectState* nativePtr) => NativePtr = nativePtr;
        public ImGuiBoxSelectStatePtr(IntPtr nativePtr) => NativePtr = (ImGuiBoxSelectState*)nativePtr;
        public static implicit operator ImGuiBoxSelectStatePtr(ImGuiBoxSelectState* nativePtr) => new ImGuiBoxSelectStatePtr(nativePtr);
        public static implicit operator ImGuiBoxSelectState* (ImGuiBoxSelectStatePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiBoxSelectStatePtr(IntPtr nativePtr) => new ImGuiBoxSelectStatePtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref bool IsActive => ref Unsafe.AsRef<bool>(&NativePtr->IsActive);
        public ref bool IsStarting => ref Unsafe.AsRef<bool>(&NativePtr->IsStarting);
        public ref bool IsStartedFromVoid => ref Unsafe.AsRef<bool>(&NativePtr->IsStartedFromVoid);
        public ref bool IsStartedSetNavIdOnce => ref Unsafe.AsRef<bool>(&NativePtr->IsStartedSetNavIdOnce);
        public ref bool RequestClear => ref Unsafe.AsRef<bool>(&NativePtr->RequestClear);
        public ref int KeyMods => ref Unsafe.AsRef<int>(&NativePtr->KeyMods);
        public ref Vector2 StartPosRel => ref Unsafe.AsRef<Vector2>(&NativePtr->StartPosRel);
        public ref Vector2 EndPosRel => ref Unsafe.AsRef<Vector2>(&NativePtr->EndPosRel);
        public ref Vector2 ScrollAccum => ref Unsafe.AsRef<Vector2>(&NativePtr->ScrollAccum);
        public ImGuiWindowPtr Window => new ImGuiWindowPtr(NativePtr->Window);
        public ref bool UnclipMode => ref Unsafe.AsRef<bool>(&NativePtr->UnclipMode);
        public ref ImRect UnclipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->UnclipRect);
        public ref ImRect BoxSelectRectPrev => ref Unsafe.AsRef<ImRect>(&NativePtr->BoxSelectRectPrev);
        public ref ImRect BoxSelectRectCurr => ref Unsafe.AsRef<ImRect>(&NativePtr->BoxSelectRectCurr);
        public void Destroy()
        {
            ImGuiNative.ImGuiBoxSelectState_destroy((ImGuiBoxSelectState*)(NativePtr));
        }
    }
}
