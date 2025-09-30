using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
	public unsafe partial struct ImGuiStyleMod
	{
		public ImGuiStyleVar VarIdx;
		public int BackupInt0;
		public int BackupInt1;
	}

	public unsafe partial struct ImGuiStyleModPtr
	{
		public ImGuiStyleMod* NativePtr { get; }
		public ImGuiStyleModPtr(ImGuiStyleMod* nativePtr) => NativePtr = nativePtr;
		public ImGuiStyleModPtr(IntPtr nativePtr) => NativePtr = (ImGuiStyleMod*)nativePtr;
		public static implicit operator ImGuiStyleModPtr(ImGuiStyleMod* nativePtr) => new ImGuiStyleModPtr(nativePtr);
		public static implicit operator ImGuiStyleMod*(ImGuiStyleModPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiStyleModPtr(IntPtr nativePtr) => new ImGuiStyleModPtr(nativePtr);

		public ref ImGuiStyleVar VarIdx => ref Unsafe.AsRef<ImGuiStyleVar>(&NativePtr->VarIdx);

		public ref int BackupInt0 => ref Unsafe.AsRef<int>(&NativePtr->BackupInt0);
        public ref int BackupInt1 => ref Unsafe.AsRef<int>(&NativePtr->BackupInt1);
        public ref float BackupFloat0 => ref Unsafe.AsRef<float>(&NativePtr->BackupInt0);
        public ref float BackupFloat1 => ref Unsafe.AsRef<float>(&NativePtr->BackupInt1);

        public void Destroy()
		{
			ImGuiNative.ImGuiStyleMod_destroy((ImGuiStyleMod*)(NativePtr));
		}
	}
}
