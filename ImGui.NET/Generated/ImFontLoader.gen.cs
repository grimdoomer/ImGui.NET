using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFontLoader
    {
        public byte* Name;
        public IntPtr LoaderInit;
        public IntPtr LoaderShutdown;
        public IntPtr FontSrcInit;
        public IntPtr FontSrcDestroy;
        public IntPtr FontSrcContainsGlyph;
        public IntPtr FontBakedInit;
        public IntPtr FontBakedDestroy;
        public IntPtr FontBakedLoadGlyph;
        public uint FontBakedSrcLoaderDataSize;
    }
    public unsafe partial struct ImFontLoaderPtr
    {
        public ImFontLoader* NativePtr { get; }
        public ImFontLoaderPtr(ImFontLoader* nativePtr) => NativePtr = nativePtr;
        public ImFontLoaderPtr(IntPtr nativePtr) => NativePtr = (ImFontLoader*)nativePtr;
        public static implicit operator ImFontLoaderPtr(ImFontLoader* nativePtr) => new ImFontLoaderPtr(nativePtr);
        public static implicit operator ImFontLoader* (ImFontLoaderPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImFontLoaderPtr(IntPtr nativePtr) => new ImFontLoaderPtr(nativePtr);
        public NullTerminatedString Name => new NullTerminatedString(NativePtr->Name);
        public ref IntPtr LoaderInit => ref Unsafe.AsRef<IntPtr>(&NativePtr->LoaderInit);
        public ref IntPtr LoaderShutdown => ref Unsafe.AsRef<IntPtr>(&NativePtr->LoaderShutdown);
        public ref IntPtr FontSrcInit => ref Unsafe.AsRef<IntPtr>(&NativePtr->FontSrcInit);
        public ref IntPtr FontSrcDestroy => ref Unsafe.AsRef<IntPtr>(&NativePtr->FontSrcDestroy);
        public ref IntPtr FontSrcContainsGlyph => ref Unsafe.AsRef<IntPtr>(&NativePtr->FontSrcContainsGlyph);
        public ref IntPtr FontBakedInit => ref Unsafe.AsRef<IntPtr>(&NativePtr->FontBakedInit);
        public ref IntPtr FontBakedDestroy => ref Unsafe.AsRef<IntPtr>(&NativePtr->FontBakedDestroy);
        public ref IntPtr FontBakedLoadGlyph => ref Unsafe.AsRef<IntPtr>(&NativePtr->FontBakedLoadGlyph);
        public ref uint FontBakedSrcLoaderDataSize => ref Unsafe.AsRef<uint>(&NativePtr->FontBakedSrcLoaderDataSize);
        public void Destroy()
        {
            ImGuiNative.ImFontLoader_destroy((ImFontLoader*)(NativePtr));
        }
    }
}
