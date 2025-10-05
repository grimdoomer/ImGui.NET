using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotItemGroup
    {
        public uint ID;
        public ImPlotLegend Legend;
        public ImPool ItemPool;
        public int ColormapIdx;
    }
    public unsafe partial struct ImPlotItemGroupPtr
    {
        public ImPlotItemGroup* NativePtr { get; }
        public ImPlotItemGroupPtr(ImPlotItemGroup* nativePtr) => NativePtr = nativePtr;
        public ImPlotItemGroupPtr(IntPtr nativePtr) => NativePtr = (ImPlotItemGroup*)nativePtr;
        public static implicit operator ImPlotItemGroupPtr(ImPlotItemGroup* nativePtr) => new ImPlotItemGroupPtr(nativePtr);
        public static implicit operator ImPlotItemGroup* (ImPlotItemGroupPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotItemGroupPtr(IntPtr nativePtr) => new ImPlotItemGroupPtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref ImPlotLegend Legend => ref Unsafe.AsRef<ImPlotLegend>(&NativePtr->Legend);
        public ImPool<ImPlotItemPtr> ItemPool => new ImPool<ImPlotItemPtr>(NativePtr->ItemPool);
        public ref int ColormapIdx => ref Unsafe.AsRef<int>(&NativePtr->ColormapIdx);
        public void Destroy()
        {
            ImPlotNative.ImPlotItemGroup_destroy((ImPlotItemGroup*)(NativePtr));
        }
        public ImPlotItemPtr GetItem(uint id)
        {
            ImPlotItem* ret = ImPlotNative.ImPlotItemGroup_GetItem_ID((ImPlotItemGroup*)(NativePtr), id);
            return new ImPlotItemPtr(ret);
        }
        public ImPlotItemPtr GetItem(string label_id)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > NativeUtilities.StackAllocationSizeLimit)
                {
                    native_label_id = NativeUtilities.AllocateNativeBuffer(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = NativeUtilities.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlotItem* ret = ImPlotNative.ImPlotItemGroup_GetItem_Str((ImPlotItemGroup*)(NativePtr), native_label_id);
            if (label_id_byteCount > NativeUtilities.StackAllocationSizeLimit)
            {
                NativeUtilities.FreeNativeBuffer(native_label_id);
            }
            return new ImPlotItemPtr(ret);
        }
        public ImPlotItemPtr GetItemByIndex(int i)
        {
            ImPlotItem* ret = ImPlotNative.ImPlotItemGroup_GetItemByIndex((ImPlotItemGroup*)(NativePtr), i);
            return new ImPlotItemPtr(ret);
        }
        public int GetItemCount()
        {
            int ret = ImPlotNative.ImPlotItemGroup_GetItemCount((ImPlotItemGroup*)(NativePtr));
            return ret;
        }
        public uint GetItemID(string label_id)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > NativeUtilities.StackAllocationSizeLimit)
                {
                    native_label_id = NativeUtilities.AllocateNativeBuffer(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = NativeUtilities.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            uint ret = ImPlotNative.ImPlotItemGroup_GetItemID((ImPlotItemGroup*)(NativePtr), native_label_id);
            if (label_id_byteCount > NativeUtilities.StackAllocationSizeLimit)
            {
                NativeUtilities.FreeNativeBuffer(native_label_id);
            }
            return ret;
        }
        public int GetItemIndex(ImPlotItemPtr item)
        {
            ImPlotItem* native_item = item.NativePtr;
            int ret = ImPlotNative.ImPlotItemGroup_GetItemIndex((ImPlotItemGroup*)(NativePtr), native_item);
            return ret;
        }
        public int GetLegendCount()
        {
            int ret = ImPlotNative.ImPlotItemGroup_GetLegendCount((ImPlotItemGroup*)(NativePtr));
            return ret;
        }
        public ImPlotItemPtr GetLegendItem(int i)
        {
            ImPlotItem* ret = ImPlotNative.ImPlotItemGroup_GetLegendItem((ImPlotItemGroup*)(NativePtr), i);
            return new ImPlotItemPtr(ret);
        }
        public string GetLegendLabel(int i)
        {
            byte* ret = ImPlotNative.ImPlotItemGroup_GetLegendLabel((ImPlotItemGroup*)(NativePtr), i);
            return NativeUtilities.StringFromPtr(ret);
        }
        public ImPlotItemPtr GetOrAddItem(uint id)
        {
            ImPlotItem* ret = ImPlotNative.ImPlotItemGroup_GetOrAddItem((ImPlotItemGroup*)(NativePtr), id);
            return new ImPlotItemPtr(ret);
        }
        public void Reset()
        {
            ImPlotNative.ImPlotItemGroup_Reset((ImPlotItemGroup*)(NativePtr));
        }
    }
}
