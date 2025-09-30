using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFontAtlasBuilder
    {
        public stbrp_context_opaque PackContext;
        public ImVector PackNodes;
        public ImVector Rects;
        public ImVector RectsIndex;
        public ImVector TempBuffer;
        public int RectsIndexFreeListStart;
        public int RectsPackedCount;
        public int RectsPackedSurface;
        public int RectsDiscardedCount;
        public int RectsDiscardedSurface;
        public int FrameCount;
        public ImVec2i MaxRectSize;
        public ImVec2i MaxRectBounds;
        public byte LockDisableResize;
        public byte PreloadedAllGlyphsRanges;
        public ImStableVector BakedPool;
        public ImGuiStorage BakedMap;
        public int BakedDiscardedCount;
        public int PackIdMouseCursors;
        public int PackIdLinesTexData;
    }
    public unsafe partial struct ImFontAtlasBuilderPtr
    {
        public ImFontAtlasBuilder* NativePtr { get; }
        public ImFontAtlasBuilderPtr(ImFontAtlasBuilder* nativePtr) => NativePtr = nativePtr;
        public ImFontAtlasBuilderPtr(IntPtr nativePtr) => NativePtr = (ImFontAtlasBuilder*)nativePtr;
        public static implicit operator ImFontAtlasBuilderPtr(ImFontAtlasBuilder* nativePtr) => new ImFontAtlasBuilderPtr(nativePtr);
        public static implicit operator ImFontAtlasBuilder* (ImFontAtlasBuilderPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImFontAtlasBuilderPtr(IntPtr nativePtr) => new ImFontAtlasBuilderPtr(nativePtr);
        public ref stbrp_context_opaque PackContext => ref Unsafe.AsRef<stbrp_context_opaque>(&NativePtr->PackContext);
        public ImVector<IntPtr> PackNodes => new ImVector<IntPtr>(NativePtr->PackNodes);
        public ImPtrVector<ImTextureRectPtr> Rects => new ImPtrVector<ImTextureRectPtr>(NativePtr->Rects, Unsafe.SizeOf<ImTextureRect>());
        public ImPtrVector<ImFontAtlasRectEntryPtr> RectsIndex => new ImPtrVector<ImFontAtlasRectEntryPtr>(NativePtr->RectsIndex, Unsafe.SizeOf<ImFontAtlasRectEntry>());
        public ImVector<byte> TempBuffer => new ImVector<byte>(NativePtr->TempBuffer);
        public ref int RectsIndexFreeListStart => ref Unsafe.AsRef<int>(&NativePtr->RectsIndexFreeListStart);
        public ref int RectsPackedCount => ref Unsafe.AsRef<int>(&NativePtr->RectsPackedCount);
        public ref int RectsPackedSurface => ref Unsafe.AsRef<int>(&NativePtr->RectsPackedSurface);
        public ref int RectsDiscardedCount => ref Unsafe.AsRef<int>(&NativePtr->RectsDiscardedCount);
        public ref int RectsDiscardedSurface => ref Unsafe.AsRef<int>(&NativePtr->RectsDiscardedSurface);
        public ref int FrameCount => ref Unsafe.AsRef<int>(&NativePtr->FrameCount);
        public ref ImVec2i MaxRectSize => ref Unsafe.AsRef<ImVec2i>(&NativePtr->MaxRectSize);
        public ref ImVec2i MaxRectBounds => ref Unsafe.AsRef<ImVec2i>(&NativePtr->MaxRectBounds);
        public ref bool LockDisableResize => ref Unsafe.AsRef<bool>(&NativePtr->LockDisableResize);
        public ref bool PreloadedAllGlyphsRanges => ref Unsafe.AsRef<bool>(&NativePtr->PreloadedAllGlyphsRanges);
        public ImStableVector<ImFontBakedPtr> BakedPool => new ImStableVector<ImFontBakedPtr>(NativePtr->BakedPool, 32);
        public ref ImGuiStorage BakedMap => ref Unsafe.AsRef<ImGuiStorage>(&NativePtr->BakedMap);
        public ref int BakedDiscardedCount => ref Unsafe.AsRef<int>(&NativePtr->BakedDiscardedCount);
        public ref int PackIdMouseCursors => ref Unsafe.AsRef<int>(&NativePtr->PackIdMouseCursors);
        public ref int PackIdLinesTexData => ref Unsafe.AsRef<int>(&NativePtr->PackIdLinesTexData);
        public void Destroy()
        {
            ImGuiNative.ImFontAtlasBuilder_destroy((ImFontAtlasBuilder*)(NativePtr));
        }
    }
}
