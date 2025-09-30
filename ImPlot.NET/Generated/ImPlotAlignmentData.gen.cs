using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotAlignmentData
    {
        public byte Vertical;
        public float PadA;
        public float PadB;
        public float PadAMax;
        public float PadBMax;
    }
    public unsafe partial struct ImPlotAlignmentDataPtr
    {
        public ImPlotAlignmentData* NativePtr { get; }
        public ImPlotAlignmentDataPtr(ImPlotAlignmentData* nativePtr) => NativePtr = nativePtr;
        public ImPlotAlignmentDataPtr(IntPtr nativePtr) => NativePtr = (ImPlotAlignmentData*)nativePtr;
        public static implicit operator ImPlotAlignmentDataPtr(ImPlotAlignmentData* nativePtr) => new ImPlotAlignmentDataPtr(nativePtr);
        public static implicit operator ImPlotAlignmentData* (ImPlotAlignmentDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotAlignmentDataPtr(IntPtr nativePtr) => new ImPlotAlignmentDataPtr(nativePtr);
        public ref bool Vertical => ref Unsafe.AsRef<bool>(&NativePtr->Vertical);
        public ref float PadA => ref Unsafe.AsRef<float>(&NativePtr->PadA);
        public ref float PadB => ref Unsafe.AsRef<float>(&NativePtr->PadB);
        public ref float PadAMax => ref Unsafe.AsRef<float>(&NativePtr->PadAMax);
        public ref float PadBMax => ref Unsafe.AsRef<float>(&NativePtr->PadBMax);
        public void Begin()
        {
            ImPlotNative.ImPlotAlignmentData_Begin((ImPlotAlignmentData*)(NativePtr));
        }
        public void Destroy()
        {
            ImPlotNative.ImPlotAlignmentData_destroy((ImPlotAlignmentData*)(NativePtr));
        }
        public void End()
        {
            ImPlotNative.ImPlotAlignmentData_End((ImPlotAlignmentData*)(NativePtr));
        }
        public void Reset()
        {
            ImPlotNative.ImPlotAlignmentData_Reset((ImPlotAlignmentData*)(NativePtr));
        }
        public void Update(ref float pad_a, ref float pad_b, ref float delta_a, ref float delta_b)
        {
            fixed (float* native_pad_a = &pad_a)
            {
                fixed (float* native_pad_b = &pad_b)
                {
                    fixed (float* native_delta_a = &delta_a)
                    {
                        fixed (float* native_delta_b = &delta_b)
                        {
                            ImPlotNative.ImPlotAlignmentData_Update((ImPlotAlignmentData*)(NativePtr), native_pad_a, native_pad_b, native_delta_a, native_delta_b);
                        }
                    }
                }
            }
        }
    }
}
