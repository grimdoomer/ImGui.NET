using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFontAtlasPostProcessData
    {
        public ImFontAtlas* FontAtlas;
        public ImFont* Font;
        public ImFontConfig* FontSrc;
        public ImFontBaked* FontBaked;
        public ImFontGlyph* Glyph;
        public void* Pixels;
        public ImTextureFormat Format;
        public int Pitch;
        public int Width;
        public int Height;
    }
    public unsafe partial struct ImFontAtlasPostProcessDataPtr
    {
        public ImFontAtlasPostProcessData* NativePtr { get; }
        public ImFontAtlasPostProcessDataPtr(ImFontAtlasPostProcessData* nativePtr) => NativePtr = nativePtr;
        public ImFontAtlasPostProcessDataPtr(IntPtr nativePtr) => NativePtr = (ImFontAtlasPostProcessData*)nativePtr;
        public static implicit operator ImFontAtlasPostProcessDataPtr(ImFontAtlasPostProcessData* nativePtr) => new ImFontAtlasPostProcessDataPtr(nativePtr);
        public static implicit operator ImFontAtlasPostProcessData* (ImFontAtlasPostProcessDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImFontAtlasPostProcessDataPtr(IntPtr nativePtr) => new ImFontAtlasPostProcessDataPtr(nativePtr);
        public ImFontAtlasPtr FontAtlas => new ImFontAtlasPtr(NativePtr->FontAtlas);
        public ImFontPtr Font => new ImFontPtr(NativePtr->Font);
        public ImFontConfigPtr FontSrc => new ImFontConfigPtr(NativePtr->FontSrc);
        public ImFontBakedPtr FontBaked => new ImFontBakedPtr(NativePtr->FontBaked);
        public ImFontGlyphPtr Glyph => new ImFontGlyphPtr(NativePtr->Glyph);
        public IntPtr Pixels { get => (IntPtr)NativePtr->Pixels; set => NativePtr->Pixels = (void*)value; }
        public ref ImTextureFormat Format => ref Unsafe.AsRef<ImTextureFormat>(&NativePtr->Format);
        public ref int Pitch => ref Unsafe.AsRef<int>(&NativePtr->Pitch);
        public ref int Width => ref Unsafe.AsRef<int>(&NativePtr->Width);
        public ref int Height => ref Unsafe.AsRef<int>(&NativePtr->Height);
    }
}
