using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiIDStackTool
    {
        public int LastActiveFrame;
        public int StackLevel;
        public uint QueryMainId;
        public ImVector Results;
        public byte QueryHookActive;
        public byte OptHexEncodeNonAsciiChars;
        public byte OptCopyToClipboardOnCtrlC;
        public float CopyToClipboardLastTime;
        public ImGuiTextBuffer ResultPathsBuf;
        public ImGuiTextBuffer ResultTempBuf;
    }
    public unsafe partial struct ImGuiIDStackToolPtr
    {
        public ImGuiIDStackTool* NativePtr { get; }
        public ImGuiIDStackToolPtr(ImGuiIDStackTool* nativePtr) => NativePtr = nativePtr;
        public ImGuiIDStackToolPtr(IntPtr nativePtr) => NativePtr = (ImGuiIDStackTool*)nativePtr;
        public static implicit operator ImGuiIDStackToolPtr(ImGuiIDStackTool* nativePtr) => new ImGuiIDStackToolPtr(nativePtr);
        public static implicit operator ImGuiIDStackTool* (ImGuiIDStackToolPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiIDStackToolPtr(IntPtr nativePtr) => new ImGuiIDStackToolPtr(nativePtr);
        public ref int LastActiveFrame => ref Unsafe.AsRef<int>(&NativePtr->LastActiveFrame);
        public ref int StackLevel => ref Unsafe.AsRef<int>(&NativePtr->StackLevel);
        public ref uint QueryMainId => ref Unsafe.AsRef<uint>(&NativePtr->QueryMainId);
        public ImPtrVector<ImGuiStackLevelInfoPtr> Results => new ImPtrVector<ImGuiStackLevelInfoPtr>(NativePtr->Results, Unsafe.SizeOf<ImGuiStackLevelInfo>());
        public ref bool QueryHookActive => ref Unsafe.AsRef<bool>(&NativePtr->QueryHookActive);
        public ref bool OptHexEncodeNonAsciiChars => ref Unsafe.AsRef<bool>(&NativePtr->OptHexEncodeNonAsciiChars);
        public ref bool OptCopyToClipboardOnCtrlC => ref Unsafe.AsRef<bool>(&NativePtr->OptCopyToClipboardOnCtrlC);
        public ref float CopyToClipboardLastTime => ref Unsafe.AsRef<float>(&NativePtr->CopyToClipboardLastTime);
        public ref ImGuiTextBuffer ResultPathsBuf => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->ResultPathsBuf);
        public ref ImGuiTextBuffer ResultTempBuf => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->ResultTempBuf);
        public void Destroy()
        {
            ImGuiNative.ImGuiIDStackTool_destroy((ImGuiIDStackTool*)(NativePtr));
        }
    }
}
