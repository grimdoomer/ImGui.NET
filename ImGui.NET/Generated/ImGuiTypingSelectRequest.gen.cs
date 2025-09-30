using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTypingSelectRequest
    {
        public ImGuiTypingSelectFlags Flags;
        public int SearchBufferLen;
        public byte* SearchBuffer;
        public byte SelectRequest;
        public byte SingleCharMode;
        public sbyte SingleCharSize;
    }
    public unsafe partial struct ImGuiTypingSelectRequestPtr
    {
        public ImGuiTypingSelectRequest* NativePtr { get; }
        public ImGuiTypingSelectRequestPtr(ImGuiTypingSelectRequest* nativePtr) => NativePtr = nativePtr;
        public ImGuiTypingSelectRequestPtr(IntPtr nativePtr) => NativePtr = (ImGuiTypingSelectRequest*)nativePtr;
        public static implicit operator ImGuiTypingSelectRequestPtr(ImGuiTypingSelectRequest* nativePtr) => new ImGuiTypingSelectRequestPtr(nativePtr);
        public static implicit operator ImGuiTypingSelectRequest* (ImGuiTypingSelectRequestPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTypingSelectRequestPtr(IntPtr nativePtr) => new ImGuiTypingSelectRequestPtr(nativePtr);
        public ref ImGuiTypingSelectFlags Flags => ref Unsafe.AsRef<ImGuiTypingSelectFlags>(&NativePtr->Flags);
        public ref int SearchBufferLen => ref Unsafe.AsRef<int>(&NativePtr->SearchBufferLen);
        public IntPtr SearchBuffer { get => (IntPtr)NativePtr->SearchBuffer; set => NativePtr->SearchBuffer = (byte*)value; }
        public ref bool SelectRequest => ref Unsafe.AsRef<bool>(&NativePtr->SelectRequest);
        public ref bool SingleCharMode => ref Unsafe.AsRef<bool>(&NativePtr->SingleCharMode);
        public ref sbyte SingleCharSize => ref Unsafe.AsRef<sbyte>(&NativePtr->SingleCharSize);
    }
}
