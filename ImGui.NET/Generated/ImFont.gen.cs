using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFont
    {
        public ImFontBaked* LastBaked;
        public ImFontAtlas* ContainerAtlas;
        public ImFontFlags Flags;
        public float CurrentRasterizerDensity;
        public uint FontId;
        public float LegacySize;
        public ImVector Sources;
        public ushort EllipsisChar;
        public ushort FallbackChar;
        public fixed byte Used8kPagesMap[1];
        public byte EllipsisAutoBake;
        public ImGuiStorage RemapPairs;
    }
    public unsafe partial struct ImFontPtr
    {
        public ImFont* NativePtr { get; }
        public ImFontPtr(ImFont* nativePtr) => NativePtr = nativePtr;
        public ImFontPtr(IntPtr nativePtr) => NativePtr = (ImFont*)nativePtr;
        public static implicit operator ImFontPtr(ImFont* nativePtr) => new ImFontPtr(nativePtr);
        public static implicit operator ImFont* (ImFontPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImFontPtr(IntPtr nativePtr) => new ImFontPtr(nativePtr);
        public ImFontBakedPtr LastBaked => new ImFontBakedPtr(NativePtr->LastBaked);
        public ImFontAtlasPtr ContainerAtlas => new ImFontAtlasPtr(NativePtr->ContainerAtlas);
        public ref ImFontFlags Flags => ref Unsafe.AsRef<ImFontFlags>(&NativePtr->Flags);
        public ref float CurrentRasterizerDensity => ref Unsafe.AsRef<float>(&NativePtr->CurrentRasterizerDensity);
        public ref uint FontId => ref Unsafe.AsRef<uint>(&NativePtr->FontId);
        public ref float LegacySize => ref Unsafe.AsRef<float>(&NativePtr->LegacySize);
        public ImVector<ImFontConfigPtr> Sources => new ImVector<ImFontConfigPtr>(NativePtr->Sources);
        public ref ushort EllipsisChar => ref Unsafe.AsRef<ushort>(&NativePtr->EllipsisChar);
        public ref ushort FallbackChar => ref Unsafe.AsRef<ushort>(&NativePtr->FallbackChar);
        public RangeAccessor<byte> Used8kPagesMap => new RangeAccessor<byte>(NativePtr->Used8kPagesMap, 1);
        public ref bool EllipsisAutoBake => ref Unsafe.AsRef<bool>(&NativePtr->EllipsisAutoBake);
        public ref ImGuiStorage RemapPairs => ref Unsafe.AsRef<ImGuiStorage>(&NativePtr->RemapPairs);
        public void AddRemapChar(ushort from_codepoint, ushort to_codepoint)
        {
            ImGuiNative.ImFont_AddRemapChar((ImFont*)(NativePtr), from_codepoint, to_codepoint);
        }
        public void ClearOutputData()
        {
            ImGuiNative.ImFont_ClearOutputData((ImFont*)(NativePtr));
        }
        public void Destroy()
        {
            ImGuiNative.ImFont_destroy((ImFont*)(NativePtr));
        }
        public string GetDebugName()
        {
            byte* ret = ImGuiNative.ImFont_GetDebugName((ImFont*)(NativePtr));
            return NativeUtilities.StringFromPtr(ret);
        }
        public ImFontBakedPtr GetFontBaked(float font_size)
        {
            float density = -1.0f;
            ImFontBaked* ret = ImGuiNative.ImFont_GetFontBaked((ImFont*)(NativePtr), font_size, density);
            return new ImFontBakedPtr(ret);
        }
        public ImFontBakedPtr GetFontBaked(float font_size, float density)
        {
            ImFontBaked* ret = ImGuiNative.ImFont_GetFontBaked((ImFont*)(NativePtr), font_size, density);
            return new ImFontBakedPtr(ret);
        }
        public bool IsGlyphInFont(ushort c)
        {
            byte ret = ImGuiNative.ImFont_IsGlyphInFont((ImFont*)(NativePtr), c);
            return ret != 0;
        }
        public bool IsLoaded()
        {
            byte ret = ImGuiNative.ImFont_IsLoaded((ImFont*)(NativePtr));
            return ret != 0;
        }
        public void RenderChar(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, ushort c)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            Vector4* cpu_fine_clip = null;
            ImGuiNative.ImFont_RenderChar((ImFont*)(NativePtr), native_draw_list, size, pos, col, c, cpu_fine_clip);
        }
        public void RenderChar(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, ushort c, ref Vector4 cpu_fine_clip)
        {
            ImDrawList* native_draw_list = draw_list.NativePtr;
            fixed (Vector4* native_cpu_fine_clip = &cpu_fine_clip)
            {
                ImGuiNative.ImFont_RenderChar((ImFont*)(NativePtr), native_draw_list, size, pos, col, c, native_cpu_fine_clip);
            }
        }
    }
}
