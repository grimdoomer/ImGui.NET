using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotColormapData
    {
        public ImVector Keys;
        public ImVector KeyCounts;
        public ImVector KeyOffsets;
        public ImVector Tables;
        public ImVector TableSizes;
        public ImVector TableOffsets;
        public ImGuiTextBuffer Text;
        public ImVector TextOffsets;
        public ImVector Quals;
        public ImGuiStorage Map;
        public int Count;
    }
    public unsafe partial struct ImPlotColormapDataPtr
    {
        public ImPlotColormapData* NativePtr { get; }
        public ImPlotColormapDataPtr(ImPlotColormapData* nativePtr) => NativePtr = nativePtr;
        public ImPlotColormapDataPtr(IntPtr nativePtr) => NativePtr = (ImPlotColormapData*)nativePtr;
        public static implicit operator ImPlotColormapDataPtr(ImPlotColormapData* nativePtr) => new ImPlotColormapDataPtr(nativePtr);
        public static implicit operator ImPlotColormapData* (ImPlotColormapDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotColormapDataPtr(IntPtr nativePtr) => new ImPlotColormapDataPtr(nativePtr);
        public ImVector<uint> Keys => new ImVector<uint>(NativePtr->Keys);
        public ImVector<int> KeyCounts => new ImVector<int>(NativePtr->KeyCounts);
        public ImVector<int> KeyOffsets => new ImVector<int>(NativePtr->KeyOffsets);
        public ImVector<uint> Tables => new ImVector<uint>(NativePtr->Tables);
        public ImVector<int> TableSizes => new ImVector<int>(NativePtr->TableSizes);
        public ImVector<int> TableOffsets => new ImVector<int>(NativePtr->TableOffsets);
        public ref ImGuiTextBuffer Text => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->Text);
        public ImVector<int> TextOffsets => new ImVector<int>(NativePtr->TextOffsets);
        public ImVector<byte> Quals => new ImVector<byte>(NativePtr->Quals);
        public ref ImGuiStorage Map => ref Unsafe.AsRef<ImGuiStorage>(&NativePtr->Map);
        public ref int Count => ref Unsafe.AsRef<int>(&NativePtr->Count);
        public void _AppendTable(ImPlotColormap cmap)
        {
            ImPlotNative.ImPlotColormapData__AppendTable((ImPlotColormapData*)(NativePtr), cmap);
        }
        public int Append(string name, ref uint keys, int count, bool qual)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > NativeUtilities.StackAllocationSizeLimit)
                {
                    native_name = NativeUtilities.AllocateNativeBuffer(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = NativeUtilities.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte native_qual = qual ? (byte)1 : (byte)0;
            fixed (uint* native_keys = &keys)
            {
                int ret = ImPlotNative.ImPlotColormapData_Append((ImPlotColormapData*)(NativePtr), native_name, native_keys, count, native_qual);
                if (name_byteCount > NativeUtilities.StackAllocationSizeLimit)
                {
                    NativeUtilities.FreeNativeBuffer(native_name);
                }
                return ret;
            }
        }
        public void Destroy()
        {
            ImPlotNative.ImPlotColormapData_destroy((ImPlotColormapData*)(NativePtr));
        }
        public ImPlotColormap GetIndex(string name)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > NativeUtilities.StackAllocationSizeLimit)
                {
                    native_name = NativeUtilities.AllocateNativeBuffer(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = NativeUtilities.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImPlotColormap ret = ImPlotNative.ImPlotColormapData_GetIndex((ImPlotColormapData*)(NativePtr), native_name);
            if (name_byteCount > NativeUtilities.StackAllocationSizeLimit)
            {
                NativeUtilities.FreeNativeBuffer(native_name);
            }
            return ret;
        }
        public uint GetKeyColor(ImPlotColormap cmap, int idx)
        {
            uint ret = ImPlotNative.ImPlotColormapData_GetKeyColor((ImPlotColormapData*)(NativePtr), cmap, idx);
            return ret;
        }
        public int GetKeyCount(ImPlotColormap cmap)
        {
            int ret = ImPlotNative.ImPlotColormapData_GetKeyCount((ImPlotColormapData*)(NativePtr), cmap);
            return ret;
        }
        public uint* GetKeys(ImPlotColormap cmap)
        {
            uint* ret = ImPlotNative.ImPlotColormapData_GetKeys((ImPlotColormapData*)(NativePtr), cmap);
            return ret;
        }
        public string GetName(ImPlotColormap cmap)
        {
            byte* ret = ImPlotNative.ImPlotColormapData_GetName((ImPlotColormapData*)(NativePtr), cmap);
            return NativeUtilities.StringFromPtr(ret);
        }
        public uint* GetTable(ImPlotColormap cmap)
        {
            uint* ret = ImPlotNative.ImPlotColormapData_GetTable((ImPlotColormapData*)(NativePtr), cmap);
            return ret;
        }
        public uint GetTableColor(ImPlotColormap cmap, int idx)
        {
            uint ret = ImPlotNative.ImPlotColormapData_GetTableColor((ImPlotColormapData*)(NativePtr), cmap, idx);
            return ret;
        }
        public int GetTableSize(ImPlotColormap cmap)
        {
            int ret = ImPlotNative.ImPlotColormapData_GetTableSize((ImPlotColormapData*)(NativePtr), cmap);
            return ret;
        }
        public bool IsQual(ImPlotColormap cmap)
        {
            byte ret = ImPlotNative.ImPlotColormapData_IsQual((ImPlotColormapData*)(NativePtr), cmap);
            return ret != 0;
        }
        public uint LerpTable(ImPlotColormap cmap, float t)
        {
            uint ret = ImPlotNative.ImPlotColormapData_LerpTable((ImPlotColormapData*)(NativePtr), cmap, t);
            return ret;
        }
        public void RebuildTables()
        {
            ImPlotNative.ImPlotColormapData_RebuildTables((ImPlotColormapData*)(NativePtr));
        }
        public void SetKeyColor(ImPlotColormap cmap, int idx, uint value)
        {
            ImPlotNative.ImPlotColormapData_SetKeyColor((ImPlotColormapData*)(NativePtr), cmap, idx, value);
        }
    }
}
