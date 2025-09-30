using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiMultiSelectTempData
    {
        public ImGuiMultiSelectIO IO;
        public ImGuiMultiSelectState* Storage;
        public uint FocusScopeId;
        public ImGuiMultiSelectFlags Flags;
        public Vector2 ScopeRectMin;
        public Vector2 BackupCursorMaxPos;
        public long LastSubmittedItem;
        public uint BoxSelectId;
        public int KeyMods;
        public sbyte LoopRequestSetAll;
        public byte IsEndIO;
        public byte IsFocused;
        public byte IsKeyboardSetRange;
        public byte NavIdPassedBy;
        public byte RangeSrcPassedBy;
        public byte RangeDstPassedBy;
    }
    public unsafe partial struct ImGuiMultiSelectTempDataPtr
    {
        public ImGuiMultiSelectTempData* NativePtr { get; }
        public ImGuiMultiSelectTempDataPtr(ImGuiMultiSelectTempData* nativePtr) => NativePtr = nativePtr;
        public ImGuiMultiSelectTempDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiMultiSelectTempData*)nativePtr;
        public static implicit operator ImGuiMultiSelectTempDataPtr(ImGuiMultiSelectTempData* nativePtr) => new ImGuiMultiSelectTempDataPtr(nativePtr);
        public static implicit operator ImGuiMultiSelectTempData* (ImGuiMultiSelectTempDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiMultiSelectTempDataPtr(IntPtr nativePtr) => new ImGuiMultiSelectTempDataPtr(nativePtr);
        public ref ImGuiMultiSelectIO IO => ref Unsafe.AsRef<ImGuiMultiSelectIO>(&NativePtr->IO);
        public ImGuiMultiSelectStatePtr Storage => new ImGuiMultiSelectStatePtr(NativePtr->Storage);
        public ref uint FocusScopeId => ref Unsafe.AsRef<uint>(&NativePtr->FocusScopeId);
        public ref ImGuiMultiSelectFlags Flags => ref Unsafe.AsRef<ImGuiMultiSelectFlags>(&NativePtr->Flags);
        public ref Vector2 ScopeRectMin => ref Unsafe.AsRef<Vector2>(&NativePtr->ScopeRectMin);
        public ref Vector2 BackupCursorMaxPos => ref Unsafe.AsRef<Vector2>(&NativePtr->BackupCursorMaxPos);
        public ref long LastSubmittedItem => ref Unsafe.AsRef<long>(&NativePtr->LastSubmittedItem);
        public ref uint BoxSelectId => ref Unsafe.AsRef<uint>(&NativePtr->BoxSelectId);
        public ref int KeyMods => ref Unsafe.AsRef<int>(&NativePtr->KeyMods);
        public ref sbyte LoopRequestSetAll => ref Unsafe.AsRef<sbyte>(&NativePtr->LoopRequestSetAll);
        public ref bool IsEndIO => ref Unsafe.AsRef<bool>(&NativePtr->IsEndIO);
        public ref bool IsFocused => ref Unsafe.AsRef<bool>(&NativePtr->IsFocused);
        public ref bool IsKeyboardSetRange => ref Unsafe.AsRef<bool>(&NativePtr->IsKeyboardSetRange);
        public ref bool NavIdPassedBy => ref Unsafe.AsRef<bool>(&NativePtr->NavIdPassedBy);
        public ref bool RangeSrcPassedBy => ref Unsafe.AsRef<bool>(&NativePtr->RangeSrcPassedBy);
        public ref bool RangeDstPassedBy => ref Unsafe.AsRef<bool>(&NativePtr->RangeDstPassedBy);
        public void Clear()
        {
            ImGuiNative.ImGuiMultiSelectTempData_Clear((ImGuiMultiSelectTempData*)(NativePtr));
        }
        public void ClearIO()
        {
            ImGuiNative.ImGuiMultiSelectTempData_ClearIO((ImGuiMultiSelectTempData*)(NativePtr));
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiMultiSelectTempData_destroy((ImGuiMultiSelectTempData*)(NativePtr));
        }
    }
}
