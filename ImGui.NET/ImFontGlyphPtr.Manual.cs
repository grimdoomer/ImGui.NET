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
        public uint CodepointPacked;
        public float AdvanceX;
        public float X0;
        public float Y0;
        public float X1;
        public float Y1;
        public float U0;
        public float V0;
        public float U1;
        public float V1;
        public int PackId;
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
                return (Unsafe.AsRef<uint>(&NativePtr->CodepointPacked) & 1) != 0;
            }
            set
            {
                if (value == true)
                    Unsafe.AsRef<uint>(&NativePtr->CodepointPacked) |= 1;
                else
                    Unsafe.AsRef<uint>(&NativePtr->CodepointPacked) &= ~(uint)1;
            }
        }

        public bool Visible
        {
            get
            {
                return (Unsafe.AsRef<uint>(&NativePtr->CodepointPacked) & 2) != 0;
            }
            set
            {
                if (value == true)
                    Unsafe.AsRef<uint>(&NativePtr->CodepointPacked) |= 2;
                else
                    Unsafe.AsRef<uint>(&NativePtr->CodepointPacked) &= ~(uint)2;
            }
        }

        public uint SourceIdx
        {
            get
            {
                return (Unsafe.AsRef<uint>(&NativePtr->CodepointPacked) >> 2) & 0xF;
            }
            set
            {
                Unsafe.AsRef<uint>(&NativePtr->CodepointPacked) = (uint)((Unsafe.AsRef<uint>(&NativePtr->CodepointPacked) & ~0x3C) | ((value & 0xF) << 2));
            }
        }

        public uint Codepoint
        {
            get
            {
                return Unsafe.AsRef<uint>(&NativePtr->CodepointPacked) >> 6;
            }
            set
            {
                Unsafe.AsRef<uint>(&NativePtr->CodepointPacked) = (uint)((Unsafe.AsRef<uint>(&NativePtr->CodepointPacked) & 0x3F) | (value << 6));
            }
        }

        public ref float AdvanceX => ref Unsafe.AsRef<float>(&NativePtr->AdvanceX);
        public ref float X0 => ref Unsafe.AsRef<float>(&NativePtr->X0);
        public ref float Y0 => ref Unsafe.AsRef<float>(&NativePtr->Y0);
        public ref float X1 => ref Unsafe.AsRef<float>(&NativePtr->X1);
        public ref float Y1 => ref Unsafe.AsRef<float>(&NativePtr->Y1);
        public ref float U0 => ref Unsafe.AsRef<float>(&NativePtr->U0);
        public ref float V0 => ref Unsafe.AsRef<float>(&NativePtr->V0);
        public ref float U1 => ref Unsafe.AsRef<float>(&NativePtr->U1);
        public ref float V1 => ref Unsafe.AsRef<float>(&NativePtr->V1);
        public ref int PackId => ref Unsafe.AsRef<int>(&NativePtr->PackId);
    }
}
