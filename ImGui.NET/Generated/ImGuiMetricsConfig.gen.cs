using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiMetricsConfig
    {
        public byte ShowDebugLog;
        public byte ShowIDStackTool;
        public byte ShowWindowsRects;
        public byte ShowWindowsBeginOrder;
        public byte ShowTablesRects;
        public byte ShowDrawCmdMesh;
        public byte ShowDrawCmdBoundingBoxes;
        public byte ShowTextEncodingViewer;
        public byte ShowTextureUsedRect;
        public byte ShowDockingNodes;
        public int ShowWindowsRectsType;
        public int ShowTablesRectsType;
        public int HighlightMonitorIdx;
        public uint HighlightViewportID;
        public byte ShowFontPreview;
    }
    public unsafe partial struct ImGuiMetricsConfigPtr
    {
        public ImGuiMetricsConfig* NativePtr { get; }
        public ImGuiMetricsConfigPtr(ImGuiMetricsConfig* nativePtr) => NativePtr = nativePtr;
        public ImGuiMetricsConfigPtr(IntPtr nativePtr) => NativePtr = (ImGuiMetricsConfig*)nativePtr;
        public static implicit operator ImGuiMetricsConfigPtr(ImGuiMetricsConfig* nativePtr) => new ImGuiMetricsConfigPtr(nativePtr);
        public static implicit operator ImGuiMetricsConfig* (ImGuiMetricsConfigPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiMetricsConfigPtr(IntPtr nativePtr) => new ImGuiMetricsConfigPtr(nativePtr);
        public ref bool ShowDebugLog => ref Unsafe.AsRef<bool>(&NativePtr->ShowDebugLog);
        public ref bool ShowIDStackTool => ref Unsafe.AsRef<bool>(&NativePtr->ShowIDStackTool);
        public ref bool ShowWindowsRects => ref Unsafe.AsRef<bool>(&NativePtr->ShowWindowsRects);
        public ref bool ShowWindowsBeginOrder => ref Unsafe.AsRef<bool>(&NativePtr->ShowWindowsBeginOrder);
        public ref bool ShowTablesRects => ref Unsafe.AsRef<bool>(&NativePtr->ShowTablesRects);
        public ref bool ShowDrawCmdMesh => ref Unsafe.AsRef<bool>(&NativePtr->ShowDrawCmdMesh);
        public ref bool ShowDrawCmdBoundingBoxes => ref Unsafe.AsRef<bool>(&NativePtr->ShowDrawCmdBoundingBoxes);
        public ref bool ShowTextEncodingViewer => ref Unsafe.AsRef<bool>(&NativePtr->ShowTextEncodingViewer);
        public ref bool ShowTextureUsedRect => ref Unsafe.AsRef<bool>(&NativePtr->ShowTextureUsedRect);
        public ref bool ShowDockingNodes => ref Unsafe.AsRef<bool>(&NativePtr->ShowDockingNodes);
        public ref int ShowWindowsRectsType => ref Unsafe.AsRef<int>(&NativePtr->ShowWindowsRectsType);
        public ref int ShowTablesRectsType => ref Unsafe.AsRef<int>(&NativePtr->ShowTablesRectsType);
        public ref int HighlightMonitorIdx => ref Unsafe.AsRef<int>(&NativePtr->HighlightMonitorIdx);
        public ref uint HighlightViewportID => ref Unsafe.AsRef<uint>(&NativePtr->HighlightViewportID);
        public ref bool ShowFontPreview => ref Unsafe.AsRef<bool>(&NativePtr->ShowFontPreview);
    }
}
