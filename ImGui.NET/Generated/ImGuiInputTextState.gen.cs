using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiInputTextState
    {
        public IntPtr Ctx;
        public IntPtr* Stb;
        public ImGuiInputTextFlags Flags;
        public uint ID;
        public int TextLen;
        public byte* TextSrc;
        public ImVector TextA;
        public ImVector TextToRevertTo;
        public ImVector CallbackTextBackup;
        public int BufCapacity;
        public Vector2 Scroll;
        public int LineCount;
        public float WrapWidth;
        public float CursorAnim;
        public byte CursorFollow;
        public byte CursorCenterY;
        public byte SelectedAllMouseLock;
        public byte Edited;
        public byte WantReloadUserBuf;
        public sbyte LastMoveDirectionLR;
        public int ReloadSelectionStart;
        public int ReloadSelectionEnd;
    }
    public unsafe partial struct ImGuiInputTextStatePtr
    {
        public ImGuiInputTextState* NativePtr { get; }
        public ImGuiInputTextStatePtr(ImGuiInputTextState* nativePtr) => NativePtr = nativePtr;
        public ImGuiInputTextStatePtr(IntPtr nativePtr) => NativePtr = (ImGuiInputTextState*)nativePtr;
        public static implicit operator ImGuiInputTextStatePtr(ImGuiInputTextState* nativePtr) => new ImGuiInputTextStatePtr(nativePtr);
        public static implicit operator ImGuiInputTextState* (ImGuiInputTextStatePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiInputTextStatePtr(IntPtr nativePtr) => new ImGuiInputTextStatePtr(nativePtr);
        public ref IntPtr Ctx => ref Unsafe.AsRef<IntPtr>(&NativePtr->Ctx);
        public IntPtr Stb { get => (IntPtr)NativePtr->Stb; set => NativePtr->Stb = (IntPtr*)value; }
        public ref ImGuiInputTextFlags Flags => ref Unsafe.AsRef<ImGuiInputTextFlags>(&NativePtr->Flags);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref int TextLen => ref Unsafe.AsRef<int>(&NativePtr->TextLen);
        public IntPtr TextSrc { get => (IntPtr)NativePtr->TextSrc; set => NativePtr->TextSrc = (byte*)value; }
        public ImVector<byte> TextA => new ImVector<byte>(NativePtr->TextA);
        public ImVector<byte> TextToRevertTo => new ImVector<byte>(NativePtr->TextToRevertTo);
        public ImVector<byte> CallbackTextBackup => new ImVector<byte>(NativePtr->CallbackTextBackup);
        public ref int BufCapacity => ref Unsafe.AsRef<int>(&NativePtr->BufCapacity);
        public ref Vector2 Scroll => ref Unsafe.AsRef<Vector2>(&NativePtr->Scroll);
        public ref int LineCount => ref Unsafe.AsRef<int>(&NativePtr->LineCount);
        public ref float WrapWidth => ref Unsafe.AsRef<float>(&NativePtr->WrapWidth);
        public ref float CursorAnim => ref Unsafe.AsRef<float>(&NativePtr->CursorAnim);
        public ref bool CursorFollow => ref Unsafe.AsRef<bool>(&NativePtr->CursorFollow);
        public ref bool CursorCenterY => ref Unsafe.AsRef<bool>(&NativePtr->CursorCenterY);
        public ref bool SelectedAllMouseLock => ref Unsafe.AsRef<bool>(&NativePtr->SelectedAllMouseLock);
        public ref bool Edited => ref Unsafe.AsRef<bool>(&NativePtr->Edited);
        public ref bool WantReloadUserBuf => ref Unsafe.AsRef<bool>(&NativePtr->WantReloadUserBuf);
        public ref sbyte LastMoveDirectionLR => ref Unsafe.AsRef<sbyte>(&NativePtr->LastMoveDirectionLR);
        public ref int ReloadSelectionStart => ref Unsafe.AsRef<int>(&NativePtr->ReloadSelectionStart);
        public ref int ReloadSelectionEnd => ref Unsafe.AsRef<int>(&NativePtr->ReloadSelectionEnd);
        public void ClearFreeMemory()
        {
            ImGuiNative.ImGuiInputTextState_ClearFreeMemory((ImGuiInputTextState*)(NativePtr));
        }
        public void ClearSelection()
        {
            ImGuiNative.ImGuiInputTextState_ClearSelection((ImGuiInputTextState*)(NativePtr));
        }
        public void ClearText()
        {
            ImGuiNative.ImGuiInputTextState_ClearText((ImGuiInputTextState*)(NativePtr));
        }
        public void CursorAnimReset()
        {
            ImGuiNative.ImGuiInputTextState_CursorAnimReset((ImGuiInputTextState*)(NativePtr));
        }
        public void CursorClamp()
        {
            ImGuiNative.ImGuiInputTextState_CursorClamp((ImGuiInputTextState*)(NativePtr));
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiInputTextState_destroy((ImGuiInputTextState*)(NativePtr));
        }
        public int GetCursorPos()
        {
            int ret = ImGuiNative.ImGuiInputTextState_GetCursorPos((ImGuiInputTextState*)(NativePtr));
            return ret;
        }
        public float GetPreferredOffsetX()
        {
            float ret = ImGuiNative.ImGuiInputTextState_GetPreferredOffsetX((ImGuiInputTextState*)(NativePtr));
            return ret;
        }
        public int GetSelectionEnd()
        {
            int ret = ImGuiNative.ImGuiInputTextState_GetSelectionEnd((ImGuiInputTextState*)(NativePtr));
            return ret;
        }
        public int GetSelectionStart()
        {
            int ret = ImGuiNative.ImGuiInputTextState_GetSelectionStart((ImGuiInputTextState*)(NativePtr));
            return ret;
        }
        public bool HasSelection()
        {
            byte ret = ImGuiNative.ImGuiInputTextState_HasSelection((ImGuiInputTextState*)(NativePtr));
            return ret != 0;
        }
        public void OnCharPressed(uint c)
        {
            ImGuiNative.ImGuiInputTextState_OnCharPressed((ImGuiInputTextState*)(NativePtr), c);
        }
        public void OnKeyPressed(int key)
        {
            ImGuiNative.ImGuiInputTextState_OnKeyPressed((ImGuiInputTextState*)(NativePtr), key);
        }
        public void ReloadUserBufAndKeepSelection()
        {
            ImGuiNative.ImGuiInputTextState_ReloadUserBufAndKeepSelection((ImGuiInputTextState*)(NativePtr));
        }
        public void ReloadUserBufAndMoveToEnd()
        {
            ImGuiNative.ImGuiInputTextState_ReloadUserBufAndMoveToEnd((ImGuiInputTextState*)(NativePtr));
        }
        public void ReloadUserBufAndSelectAll()
        {
            ImGuiNative.ImGuiInputTextState_ReloadUserBufAndSelectAll((ImGuiInputTextState*)(NativePtr));
        }
        public void SelectAll()
        {
            ImGuiNative.ImGuiInputTextState_SelectAll((ImGuiInputTextState*)(NativePtr));
        }
    }
}
