using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawListSharedData
    {
        public Vector2 TexUvWhitePixel;
        public Vector4* TexUvLines;
        public ImFontAtlas* FontAtlas;
        public ImFont* Font;
        public float FontSize;
        public float FontScale;
        public float CurveTessellationTol;
        public float CircleSegmentMaxError;
        public float InitialFringeScale;
        public ImDrawListFlags InitialFlags;
        public Vector4 ClipRectFullscreen;
        public ImVector TempBuffer;
        public ImVector DrawLists;
        public IntPtr Context;
        public Vector2 ArcFastVtx_0;
        public Vector2 ArcFastVtx_1;
        public Vector2 ArcFastVtx_2;
        public Vector2 ArcFastVtx_3;
        public Vector2 ArcFastVtx_4;
        public Vector2 ArcFastVtx_5;
        public Vector2 ArcFastVtx_6;
        public Vector2 ArcFastVtx_7;
        public Vector2 ArcFastVtx_8;
        public Vector2 ArcFastVtx_9;
        public Vector2 ArcFastVtx_10;
        public Vector2 ArcFastVtx_11;
        public Vector2 ArcFastVtx_12;
        public Vector2 ArcFastVtx_13;
        public Vector2 ArcFastVtx_14;
        public Vector2 ArcFastVtx_15;
        public Vector2 ArcFastVtx_16;
        public Vector2 ArcFastVtx_17;
        public Vector2 ArcFastVtx_18;
        public Vector2 ArcFastVtx_19;
        public Vector2 ArcFastVtx_20;
        public Vector2 ArcFastVtx_21;
        public Vector2 ArcFastVtx_22;
        public Vector2 ArcFastVtx_23;
        public Vector2 ArcFastVtx_24;
        public Vector2 ArcFastVtx_25;
        public Vector2 ArcFastVtx_26;
        public Vector2 ArcFastVtx_27;
        public Vector2 ArcFastVtx_28;
        public Vector2 ArcFastVtx_29;
        public Vector2 ArcFastVtx_30;
        public Vector2 ArcFastVtx_31;
        public Vector2 ArcFastVtx_32;
        public Vector2 ArcFastVtx_33;
        public Vector2 ArcFastVtx_34;
        public Vector2 ArcFastVtx_35;
        public Vector2 ArcFastVtx_36;
        public Vector2 ArcFastVtx_37;
        public Vector2 ArcFastVtx_38;
        public Vector2 ArcFastVtx_39;
        public Vector2 ArcFastVtx_40;
        public Vector2 ArcFastVtx_41;
        public Vector2 ArcFastVtx_42;
        public Vector2 ArcFastVtx_43;
        public Vector2 ArcFastVtx_44;
        public Vector2 ArcFastVtx_45;
        public Vector2 ArcFastVtx_46;
        public Vector2 ArcFastVtx_47;
        public float ArcFastRadiusCutoff;
        public fixed byte CircleSegmentCounts[64];
    }
    public unsafe partial struct ImDrawListSharedDataPtr
    {
        public ImDrawListSharedData* NativePtr { get; }
        public ImDrawListSharedDataPtr(ImDrawListSharedData* nativePtr) => NativePtr = nativePtr;
        public ImDrawListSharedDataPtr(IntPtr nativePtr) => NativePtr = (ImDrawListSharedData*)nativePtr;
        public static implicit operator ImDrawListSharedDataPtr(ImDrawListSharedData* nativePtr) => new ImDrawListSharedDataPtr(nativePtr);
        public static implicit operator ImDrawListSharedData* (ImDrawListSharedDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawListSharedDataPtr(IntPtr nativePtr) => new ImDrawListSharedDataPtr(nativePtr);
        public ref Vector2 TexUvWhitePixel => ref Unsafe.AsRef<Vector2>(&NativePtr->TexUvWhitePixel);
        public IntPtr TexUvLines { get => (IntPtr)NativePtr->TexUvLines; set => NativePtr->TexUvLines = (Vector4*)value; }
        public ImFontAtlasPtr FontAtlas => new ImFontAtlasPtr(NativePtr->FontAtlas);
        public ImFontPtr Font => new ImFontPtr(NativePtr->Font);
        public ref float FontSize => ref Unsafe.AsRef<float>(&NativePtr->FontSize);
        public ref float FontScale => ref Unsafe.AsRef<float>(&NativePtr->FontScale);
        public ref float CurveTessellationTol => ref Unsafe.AsRef<float>(&NativePtr->CurveTessellationTol);
        public ref float CircleSegmentMaxError => ref Unsafe.AsRef<float>(&NativePtr->CircleSegmentMaxError);
        public ref float InitialFringeScale => ref Unsafe.AsRef<float>(&NativePtr->InitialFringeScale);
        public ref ImDrawListFlags InitialFlags => ref Unsafe.AsRef<ImDrawListFlags>(&NativePtr->InitialFlags);
        public ref Vector4 ClipRectFullscreen => ref Unsafe.AsRef<Vector4>(&NativePtr->ClipRectFullscreen);
        public ImVector<Vector2> TempBuffer => new ImVector<Vector2>(NativePtr->TempBuffer);
        public ImVector<ImDrawListPtr> DrawLists => new ImVector<ImDrawListPtr>(NativePtr->DrawLists);
        public ref IntPtr Context => ref Unsafe.AsRef<IntPtr>(&NativePtr->Context);
        public RangeAccessor<Vector2> ArcFastVtx => new RangeAccessor<Vector2>(&NativePtr->ArcFastVtx_0, 48);
        public ref float ArcFastRadiusCutoff => ref Unsafe.AsRef<float>(&NativePtr->ArcFastRadiusCutoff);
        public RangeAccessor<byte> CircleSegmentCounts => new RangeAccessor<byte>(NativePtr->CircleSegmentCounts, 64);
        public void Destroy()
        {
            ImGuiNative.ImDrawListSharedData_destroy((ImDrawListSharedData*)(NativePtr));
        }
        public void SetCircleTessellationMaxError(float max_error)
        {
            ImGuiNative.ImDrawListSharedData_SetCircleTessellationMaxError((ImDrawListSharedData*)(NativePtr), max_error);
        }
    }
}
