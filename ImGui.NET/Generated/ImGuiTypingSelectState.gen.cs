using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTypingSelectState
    {
        public ImGuiTypingSelectRequest Request;
        public fixed byte SearchBuffer[64];
        public uint FocusScope;
        public int LastRequestFrame;
        public float LastRequestTime;
        public byte SingleCharModeLock;
    }
    public unsafe partial struct ImGuiTypingSelectStatePtr
    {
        public ImGuiTypingSelectState* NativePtr { get; }
        public ImGuiTypingSelectStatePtr(ImGuiTypingSelectState* nativePtr) => NativePtr = nativePtr;
        public ImGuiTypingSelectStatePtr(IntPtr nativePtr) => NativePtr = (ImGuiTypingSelectState*)nativePtr;
        public static implicit operator ImGuiTypingSelectStatePtr(ImGuiTypingSelectState* nativePtr) => new ImGuiTypingSelectStatePtr(nativePtr);
        public static implicit operator ImGuiTypingSelectState* (ImGuiTypingSelectStatePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTypingSelectStatePtr(IntPtr nativePtr) => new ImGuiTypingSelectStatePtr(nativePtr);
        public ref ImGuiTypingSelectRequest Request => ref Unsafe.AsRef<ImGuiTypingSelectRequest>(&NativePtr->Request);
        public RangeAccessor<byte> SearchBuffer => new RangeAccessor<byte>(NativePtr->SearchBuffer, 64);
        public ref uint FocusScope => ref Unsafe.AsRef<uint>(&NativePtr->FocusScope);
        public ref int LastRequestFrame => ref Unsafe.AsRef<int>(&NativePtr->LastRequestFrame);
        public ref float LastRequestTime => ref Unsafe.AsRef<float>(&NativePtr->LastRequestTime);
        public ref bool SingleCharModeLock => ref Unsafe.AsRef<bool>(&NativePtr->SingleCharModeLock);
        public void Clear()
        {
            ImGuiNative.ImGuiTypingSelectState_Clear((ImGuiTypingSelectState*)(NativePtr));
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiTypingSelectState_destroy((ImGuiTypingSelectState*)(NativePtr));
        }
    }
}
