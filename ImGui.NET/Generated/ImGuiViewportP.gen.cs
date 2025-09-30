using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiViewportP
    {
        public ImGuiViewport _ImGuiViewport;
        public ImGuiWindow* Window;
        public int Idx;
        public int LastFrameActive;
        public int LastFocusedStampCount;
        public uint LastNameHash;
        public Vector2 LastPos;
        public Vector2 LastSize;
        public float Alpha;
        public float LastAlpha;
        public byte LastFocusedHadNavWindow;
        public short PlatformMonitor;
        public fixed int BgFgDrawListsLastFrame[2];
        public ImDrawList* BgFgDrawLists_0;
        public ImDrawList* BgFgDrawLists_1;
        public ImDrawData DrawDataP;
        public ImDrawDataBuilder DrawDataBuilder;
        public Vector2 LastPlatformPos;
        public Vector2 LastPlatformSize;
        public Vector2 LastRendererSize;
        public Vector2 WorkInsetMin;
        public Vector2 WorkInsetMax;
        public Vector2 BuildWorkInsetMin;
        public Vector2 BuildWorkInsetMax;
    }
    public unsafe partial struct ImGuiViewportPPtr
    {
        public ImGuiViewportP* NativePtr { get; }
        public ImGuiViewportPPtr(ImGuiViewportP* nativePtr) => NativePtr = nativePtr;
        public ImGuiViewportPPtr(IntPtr nativePtr) => NativePtr = (ImGuiViewportP*)nativePtr;
        public static implicit operator ImGuiViewportPPtr(ImGuiViewportP* nativePtr) => new ImGuiViewportPPtr(nativePtr);
        public static implicit operator ImGuiViewportP* (ImGuiViewportPPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiViewportPPtr(IntPtr nativePtr) => new ImGuiViewportPPtr(nativePtr);
        public ref ImGuiViewport _ImGuiViewport => ref Unsafe.AsRef<ImGuiViewport>(&NativePtr->_ImGuiViewport);
        public ImGuiWindowPtr Window => new ImGuiWindowPtr(NativePtr->Window);
        public ref int Idx => ref Unsafe.AsRef<int>(&NativePtr->Idx);
        public ref int LastFrameActive => ref Unsafe.AsRef<int>(&NativePtr->LastFrameActive);
        public ref int LastFocusedStampCount => ref Unsafe.AsRef<int>(&NativePtr->LastFocusedStampCount);
        public ref uint LastNameHash => ref Unsafe.AsRef<uint>(&NativePtr->LastNameHash);
        public ref Vector2 LastPos => ref Unsafe.AsRef<Vector2>(&NativePtr->LastPos);
        public ref Vector2 LastSize => ref Unsafe.AsRef<Vector2>(&NativePtr->LastSize);
        public ref float Alpha => ref Unsafe.AsRef<float>(&NativePtr->Alpha);
        public ref float LastAlpha => ref Unsafe.AsRef<float>(&NativePtr->LastAlpha);
        public ref bool LastFocusedHadNavWindow => ref Unsafe.AsRef<bool>(&NativePtr->LastFocusedHadNavWindow);
        public ref short PlatformMonitor => ref Unsafe.AsRef<short>(&NativePtr->PlatformMonitor);
        public RangeAccessor<int> BgFgDrawListsLastFrame => new RangeAccessor<int>(NativePtr->BgFgDrawListsLastFrame, 2);
        public RangeAccessor<IntPtr> BgFgDrawLists => new RangeAccessor<IntPtr>(&NativePtr->BgFgDrawLists_0, 2);
        public ref ImDrawData DrawDataP => ref Unsafe.AsRef<ImDrawData>(&NativePtr->DrawDataP);
        public ref ImDrawDataBuilder DrawDataBuilder => ref Unsafe.AsRef<ImDrawDataBuilder>(&NativePtr->DrawDataBuilder);
        public ref Vector2 LastPlatformPos => ref Unsafe.AsRef<Vector2>(&NativePtr->LastPlatformPos);
        public ref Vector2 LastPlatformSize => ref Unsafe.AsRef<Vector2>(&NativePtr->LastPlatformSize);
        public ref Vector2 LastRendererSize => ref Unsafe.AsRef<Vector2>(&NativePtr->LastRendererSize);
        public ref Vector2 WorkInsetMin => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkInsetMin);
        public ref Vector2 WorkInsetMax => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkInsetMax);
        public ref Vector2 BuildWorkInsetMin => ref Unsafe.AsRef<Vector2>(&NativePtr->BuildWorkInsetMin);
        public ref Vector2 BuildWorkInsetMax => ref Unsafe.AsRef<Vector2>(&NativePtr->BuildWorkInsetMax);
        public Vector2 CalcWorkRectPos(Vector2 inset_min)
        {
            Vector2 __retval;
            ImGuiNative.ImGuiViewportP_CalcWorkRectPos(&__retval, (ImGuiViewportP*)(NativePtr), inset_min);
            return __retval;
        }
        public Vector2 CalcWorkRectSize(Vector2 inset_min, Vector2 inset_max)
        {
            Vector2 __retval;
            ImGuiNative.ImGuiViewportP_CalcWorkRectSize(&__retval, (ImGuiViewportP*)(NativePtr), inset_min, inset_max);
            return __retval;
        }
        public void ClearRequestFlags()
        {
            ImGuiNative.ImGuiViewportP_ClearRequestFlags((ImGuiViewportP*)(NativePtr));
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiViewportP_destroy((ImGuiViewportP*)(NativePtr));
        }
        public ImRect GetBuildWorkRect()
        {
            ImRect __retval;
            ImGuiNative.ImGuiViewportP_GetBuildWorkRect(&__retval, (ImGuiViewportP*)(NativePtr));
            return __retval;
        }
        public ImRect GetMainRect()
        {
            ImRect __retval;
            ImGuiNative.ImGuiViewportP_GetMainRect(&__retval, (ImGuiViewportP*)(NativePtr));
            return __retval;
        }
        public ImRect GetWorkRect()
        {
            ImRect __retval;
            ImGuiNative.ImGuiViewportP_GetWorkRect(&__retval, (ImGuiViewportP*)(NativePtr));
            return __retval;
        }
        public void UpdateWorkRect()
        {
            ImGuiNative.ImGuiViewportP_UpdateWorkRect((ImGuiViewportP*)(NativePtr));
        }
    }
}
