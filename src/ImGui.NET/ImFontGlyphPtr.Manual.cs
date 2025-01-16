using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFontGlyph
    {
        // Note: Colored and Visible are bit packed into Codepoint. To work around this
        //  we only expose Codepoint and in ImFontGlyphPtr have accessors that mask in/out the corresponding bits.

        //public uint Colored;
        //public uint Visible;
        public uint Codepoint;
        public float AdvanceX;
        public float X0;
        public float Y0;
        public float X1;
        public float Y1;
        public float U0;
        public float V0;
        public float U1;
        public float V1;
    }
    public unsafe partial struct ImFontGlyphPtr
    {
        public ImFontGlyph* NativePtr { get; }
        public ImFontGlyphPtr(ImFontGlyph* nativePtr) => NativePtr = nativePtr;
        public ImFontGlyphPtr(IntPtr nativePtr) => NativePtr = (ImFontGlyph*)nativePtr;
        public static implicit operator ImFontGlyphPtr(ImFontGlyph* nativePtr) => new ImFontGlyphPtr(nativePtr);
        public static implicit operator ImFontGlyph*(ImFontGlyphPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImFontGlyphPtr(IntPtr nativePtr) => new ImFontGlyphPtr(nativePtr);

        public bool Colored
        {
            get
            {
                return (Unsafe.AsRef<uint>(&NativePtr->Codepoint) & 1) != 0;
            }
            set
            {
                if (value == true)
                    Unsafe.AsRef<uint>(&NativePtr->Codepoint) |= 1;
                else
                    Unsafe.AsRef<uint>(&NativePtr->Codepoint) &= ~(uint)1;
            }
        }

        public bool Visible
        {
            get
            {
                return (Unsafe.AsRef<uint>(&NativePtr->Codepoint) & 2) != 0;
            }
            set
            {
                if (value == true)
                    Unsafe.AsRef<uint>(&NativePtr->Codepoint) |= 2;
                else
                    Unsafe.AsRef<uint>(&NativePtr->Codepoint) &= ~(uint)2;
            }
        }

        public ref uint Codepoint => ref Unsafe.AsRef<uint>(&NativePtr->Codepoint);
        public ref float AdvanceX => ref Unsafe.AsRef<float>(&NativePtr->AdvanceX);
        public ref float X0 => ref Unsafe.AsRef<float>(&NativePtr->X0);
        public ref float Y0 => ref Unsafe.AsRef<float>(&NativePtr->Y0);
        public ref float X1 => ref Unsafe.AsRef<float>(&NativePtr->X1);
        public ref float Y1 => ref Unsafe.AsRef<float>(&NativePtr->Y1);
        public ref float U0 => ref Unsafe.AsRef<float>(&NativePtr->U0);
        public ref float V0 => ref Unsafe.AsRef<float>(&NativePtr->V0);
        public ref float U1 => ref Unsafe.AsRef<float>(&NativePtr->U1);
        public ref float V1 => ref Unsafe.AsRef<float>(&NativePtr->V1);
    }
}
