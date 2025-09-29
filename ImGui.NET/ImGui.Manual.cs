using System;
using SharpDX;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ImGuiNET
{
    public static unsafe partial class ImGui
    {
        #region InputText

        public static bool InputText(
            string label,
            byte[] buf,
            uint buf_size)
        {
            return InputText(label, buf, buf_size, 0, null, IntPtr.Zero);
        }

        public static bool InputText(
            string label,
            byte[] buf,
            uint buf_size,
            ImGuiInputTextFlags flags)
        {
            return InputText(label, buf, buf_size, flags, null, IntPtr.Zero);
        }

        public static bool InputText(
            string label,
            byte[] buf,
            uint buf_size,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback)
        {
            return InputText(label, buf, buf_size, flags, callback, IntPtr.Zero);
        }

        public static bool InputText(
            string label,
            byte[] buf,
            uint buf_size,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback,
            IntPtr user_data)
        {
            int utf8LabelByteCount = Encoding.UTF8.GetByteCount(label);
            byte* utf8LabelBytes;
            if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
            {
                utf8LabelBytes = Util.Allocate(utf8LabelByteCount + 1);
            }
            else
            {
                byte* stackPtr = stackalloc byte[utf8LabelByteCount + 1];
                utf8LabelBytes = stackPtr;
            }
            Util.GetUtf8(label, utf8LabelBytes, utf8LabelByteCount);

            bool ret;
            fixed (byte* bufPtr = buf)
            {
                ret = ImGuiNative.igInputText(utf8LabelBytes, bufPtr, buf_size, flags, callback, user_data.ToPointer()) != 0;
            }

            if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(utf8LabelBytes);
            }

            return ret;
        }

        public static bool InputText(
            string label,
            ref string input,
            uint maxLength) => InputText(label, ref input, maxLength, 0, null, IntPtr.Zero);

        public static bool InputText(
            string label,
            ref string input,
            uint maxLength,
            ImGuiInputTextFlags flags) => InputText(label, ref input, maxLength, flags, null, IntPtr.Zero);

        public static bool InputText(
            string label,
            ref string input,
            uint maxLength,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback) => InputText(label, ref input, maxLength, flags, callback, IntPtr.Zero);

        public static bool InputText(
            string label,
            ref string input,
            uint maxLength,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback,
            IntPtr user_data)
        {
            int utf8LabelByteCount = Encoding.UTF8.GetByteCount(label);
            byte* utf8LabelBytes;
            if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
            {
                utf8LabelBytes = Util.Allocate(utf8LabelByteCount + 1);
            }
            else
            {
                byte* stackPtr = stackalloc byte[utf8LabelByteCount + 1];
                utf8LabelBytes = stackPtr;
            }
            Util.GetUtf8(label, utf8LabelBytes, utf8LabelByteCount);

            int utf8InputByteCount = Encoding.UTF8.GetByteCount(input);
            int inputBufSize = Math.Max((int)maxLength + 1, utf8InputByteCount + 1);

            byte* utf8InputBytes;
            byte* originalUtf8InputBytes;
            if (inputBufSize > Util.StackAllocationSizeLimit)
            {
                utf8InputBytes = Util.Allocate(inputBufSize);
                originalUtf8InputBytes = Util.Allocate(inputBufSize);
            }
            else
            {
                byte* inputStackBytes = stackalloc byte[inputBufSize];
                utf8InputBytes = inputStackBytes;
                byte* originalInputStackBytes = stackalloc byte[inputBufSize];
                originalUtf8InputBytes = originalInputStackBytes;
            }
            Util.GetUtf8(input, utf8InputBytes, inputBufSize);
            uint clearBytesCount = (uint)(inputBufSize - utf8InputByteCount);
            Unsafe.InitBlockUnaligned(utf8InputBytes + utf8InputByteCount, 0, clearBytesCount);
            Unsafe.CopyBlock(originalUtf8InputBytes, utf8InputBytes, (uint)inputBufSize);

            byte result = ImGuiNative.igInputText(
                utf8LabelBytes,
                utf8InputBytes,
                (uint)inputBufSize,
                flags,
                callback,
                user_data.ToPointer());
            if (!Util.AreStringsEqual(originalUtf8InputBytes, inputBufSize, utf8InputBytes))
            {
                input = Util.StringFromPtr(utf8InputBytes);
            }

            if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(utf8LabelBytes);
            }
            if (inputBufSize > Util.StackAllocationSizeLimit)
            {
                Util.Free(utf8InputBytes);
                Util.Free(originalUtf8InputBytes);
            }

            return result != 0;
        }

        public static bool InputText(
            string label,
            IntPtr buf,
            uint buf_size)
        {
            return InputText(label, buf, buf_size, 0, null, IntPtr.Zero);
        }

        public static bool InputText(
            string label,
            IntPtr buf,
            uint buf_size,
            ImGuiInputTextFlags flags)
        {
            return InputText(label, buf, buf_size, flags, null, IntPtr.Zero);
        }

        public static bool InputText(
            string label,
            IntPtr buf,
            uint buf_size,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback)
        {
            return InputText(label, buf, buf_size, flags, callback, IntPtr.Zero);
        }

        public static bool InputText(
            string label,
            IntPtr buf,
            uint buf_size,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback,
            IntPtr user_data)
        {
            int utf8LabelByteCount = Encoding.UTF8.GetByteCount(label);
            byte* utf8LabelBytes;
            if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
            {
                utf8LabelBytes = Util.Allocate(utf8LabelByteCount + 1);
            }
            else
            {
                byte* stackPtr = stackalloc byte[utf8LabelByteCount + 1];
                utf8LabelBytes = stackPtr;
            }
            Util.GetUtf8(label, utf8LabelBytes, utf8LabelByteCount);

            bool ret = ImGuiNative.igInputText(utf8LabelBytes, (byte*)buf.ToPointer(), buf_size, flags, callback, user_data.ToPointer()) != 0;

            if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(utf8LabelBytes);
            }

            return ret;
        }

        #endregion

        #region InputTextMultiline

        public static bool InputTextMultiline(
            string label,
            ref string input,
            uint maxLength,
            Vector2 size) => InputTextMultiline(label, ref input, maxLength, size, 0, null, IntPtr.Zero);

        public static bool InputTextMultiline(
            string label,
            ref string input,
            uint maxLength,
            Vector2 size,
            ImGuiInputTextFlags flags) => InputTextMultiline(label, ref input, maxLength, size, flags, null, IntPtr.Zero);

        public static bool InputTextMultiline(
            string label,
            ref string input,
            uint maxLength,
            Vector2 size,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback) => InputTextMultiline(label, ref input, maxLength, size, flags, callback, IntPtr.Zero);

        public static bool InputTextMultiline(
            string label,
            ref string input,
            uint maxLength,
            Vector2 size,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback,
            IntPtr user_data)
        {
            int utf8LabelByteCount = Encoding.UTF8.GetByteCount(label);
            byte* utf8LabelBytes;
            if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
            {
                utf8LabelBytes = Util.Allocate(utf8LabelByteCount + 1);
            }
            else
            {
                byte* stackPtr = stackalloc byte[utf8LabelByteCount + 1];
                utf8LabelBytes = stackPtr;
            }
            Util.GetUtf8(label, utf8LabelBytes, utf8LabelByteCount);

            int utf8InputByteCount = Encoding.UTF8.GetByteCount(input);
            int inputBufSize = Math.Max((int)maxLength + 1, utf8InputByteCount + 1);

            byte* utf8InputBytes;
            byte* originalUtf8InputBytes;
            if (inputBufSize > Util.StackAllocationSizeLimit)
            {
                utf8InputBytes = Util.Allocate(inputBufSize);
                originalUtf8InputBytes = Util.Allocate(inputBufSize);
            }
            else
            {
                byte* inputStackBytes = stackalloc byte[inputBufSize];
                utf8InputBytes = inputStackBytes;
                byte* originalInputStackBytes = stackalloc byte[inputBufSize];
                originalUtf8InputBytes = originalInputStackBytes;
            }
            Util.GetUtf8(input, utf8InputBytes, inputBufSize);
            uint clearBytesCount = (uint)(inputBufSize - utf8InputByteCount);
            Unsafe.InitBlockUnaligned(utf8InputBytes + utf8InputByteCount, 0, clearBytesCount);
            Unsafe.CopyBlock(originalUtf8InputBytes, utf8InputBytes, (uint)inputBufSize);

            byte result = ImGuiNative.igInputTextMultiline(
                utf8LabelBytes,
                utf8InputBytes,
                (uint)inputBufSize,
                size,
                flags,
                callback,
                user_data.ToPointer());
            if (!Util.AreStringsEqual(originalUtf8InputBytes, inputBufSize, utf8InputBytes))
            {
                input = Util.StringFromPtr(utf8InputBytes);
            }

            if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(utf8LabelBytes);
            }
            if (inputBufSize > Util.StackAllocationSizeLimit)
            {
                Util.Free(utf8InputBytes);
                Util.Free(originalUtf8InputBytes);
            }

            return result != 0;
        }

        #endregion

        #region InputTextWithHint

        /*
        public static bool InputTextWithHint(
            string label,
            string hint,
            ref string input,
            uint maxLength) => InputTextWithHint(label, hint, ref input, maxLength, 0, null, IntPtr.Zero);

        public static bool InputTextWithHint(
            string label,
            string hint,
            ref string input,
            uint maxLength,
            ImGuiInputTextFlags flags) => InputTextWithHint(label, hint, ref input, maxLength, flags, null, IntPtr.Zero);

        public static bool InputTextWithHint(
            string label,
            string hint,
            ref string input,
            uint maxLength,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback) => InputTextWithHint(label, hint, ref input, maxLength, flags, callback, IntPtr.Zero);

        public static bool InputTextWithHint(
            string label,
            string hint,
            ref string input,
            uint maxLength,
            ImGuiInputTextFlags flags,
            ImGuiInputTextCallback callback,
            IntPtr user_data)
        {
            int utf8LabelByteCount = Encoding.UTF8.GetByteCount(label);
            byte* utf8LabelBytes;
            if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
            {
                utf8LabelBytes = Util.Allocate(utf8LabelByteCount + 1);
            }
            else
            {
                byte* stackPtr = stackalloc byte[utf8LabelByteCount + 1];
                utf8LabelBytes = stackPtr;
            }
            Util.GetUtf8(label, utf8LabelBytes, utf8LabelByteCount);

            int utf8HintByteCount = Encoding.UTF8.GetByteCount(hint);
            byte* utf8HintBytes;
            if (utf8HintByteCount > Util.StackAllocationSizeLimit)
            {
                utf8HintBytes = Util.Allocate(utf8HintByteCount + 1);
            }
            else
            {
                byte* stackPtr = stackalloc byte[utf8HintByteCount + 1];
                utf8HintBytes = stackPtr;
            }
            Util.GetUtf8(hint, utf8HintBytes, utf8HintByteCount);

            int utf8InputByteCount = Encoding.UTF8.GetByteCount(input);
            int inputBufSize = Math.Max((int)maxLength + 1, utf8InputByteCount + 1);

            byte* utf8InputBytes;
            byte* originalUtf8InputBytes;
            if (inputBufSize > Util.StackAllocationSizeLimit)
            {
                utf8InputBytes = Util.Allocate(inputBufSize);
                originalUtf8InputBytes = Util.Allocate(inputBufSize);
            }
            else
            {
                byte* inputStackBytes = stackalloc byte[inputBufSize];
                utf8InputBytes = inputStackBytes;
                byte* originalInputStackBytes = stackalloc byte[inputBufSize];
                originalUtf8InputBytes = originalInputStackBytes;
            }
            Util.GetUtf8(input, utf8InputBytes, inputBufSize);
            uint clearBytesCount = (uint)(inputBufSize - utf8InputByteCount);
            Unsafe.InitBlockUnaligned(utf8InputBytes + utf8InputByteCount, 0, clearBytesCount);
            Unsafe.CopyBlock(originalUtf8InputBytes, utf8InputBytes, (uint)inputBufSize);

            byte result = ImGuiNative.igInputTextWithHint(
                utf8LabelBytes,
                utf8HintBytes,
                utf8InputBytes,
                (uint)inputBufSize,
                flags,
                callback,
                user_data.ToPointer());
            if (!Util.AreStringsEqual(originalUtf8InputBytes, inputBufSize, utf8InputBytes))
            {
                input = Util.StringFromPtr(utf8InputBytes);
            }

            if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(utf8LabelBytes);
            }
            if (utf8HintByteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(utf8HintBytes);
            }
            if (inputBufSize > Util.StackAllocationSizeLimit)
            {
                Util.Free(utf8InputBytes);
                Util.Free(originalUtf8InputBytes);
            }

            return result != 0;
        }
        */

        #endregion

        #region CalcTextSize

        /*
        public static Vector2 CalcTextSize(string text)
            => CalcTextSizeImpl(text);

        public static Vector2 CalcTextSize(string text, int start)
            => CalcTextSizeImpl(text, start);

        public static Vector2 CalcTextSize(string text, float wrapWidth)
            => CalcTextSizeImpl(text, wrapWidth: wrapWidth);

        public static Vector2 CalcTextSize(string text, bool hideTextAfterDoubleHash)
            => CalcTextSizeImpl(text, hideTextAfterDoubleHash: hideTextAfterDoubleHash);

        public static Vector2 CalcTextSize(string text, int start, int length)
            => CalcTextSizeImpl(text, start, length);

        public static Vector2 CalcTextSize(string text, int start, bool hideTextAfterDoubleHash)
            => CalcTextSizeImpl(text, start, hideTextAfterDoubleHash: hideTextAfterDoubleHash);

        public static Vector2 CalcTextSize(string text, int start, float wrapWidth)
            => CalcTextSizeImpl(text, start, wrapWidth: wrapWidth);

        public static Vector2 CalcTextSize(string text, bool hideTextAfterDoubleHash, float wrapWidth)
            => CalcTextSizeImpl(text, hideTextAfterDoubleHash: hideTextAfterDoubleHash, wrapWidth: wrapWidth);

        public static Vector2 CalcTextSize(string text, int start, int length, bool hideTextAfterDoubleHash)
            => CalcTextSizeImpl(text, start, length, hideTextAfterDoubleHash);

        public static Vector2 CalcTextSize(string text, int start, int length, float wrapWidth)
            => CalcTextSizeImpl(text, start, length, wrapWidth: wrapWidth);

        public static Vector2 CalcTextSize(string text, int start, int length, bool hideTextAfterDoubleHash, float wrapWidth)
            => CalcTextSizeImpl(text, start, length, hideTextAfterDoubleHash, wrapWidth);

        private static Vector2 CalcTextSizeImpl(
            string text,
            int start = 0,
            int? length = null,
            bool hideTextAfterDoubleHash = false,
            float wrapWidth = -1.0f)
        {
            Vector2 ret;
            byte* nativeTextStart = null;
            byte* nativeTextEnd = null;
            int textByteCount = 0;
            if (text != null)
            {

                int textToCopyLen = length.HasValue ? length.Value : text.Length;
                textByteCount = Util.CalcSizeInUtf8(text, start, textToCopyLen);
                if (textByteCount > Util.StackAllocationSizeLimit)
                {
                    nativeTextStart = Util.Allocate(textByteCount + 1);
                }
                else
                {
                    byte* nativeTextStackBytes = stackalloc byte[textByteCount + 1];
                    nativeTextStart = nativeTextStackBytes;
                }

                int nativeTextOffset = Util.GetUtf8(text, start, textToCopyLen, nativeTextStart, textByteCount);
                nativeTextStart[nativeTextOffset] = 0;
                nativeTextEnd = nativeTextStart + nativeTextOffset;
            }

            ImGuiNative.igCalcTextSize(&ret, nativeTextStart, nativeTextEnd, *((byte*)(&hideTextAfterDoubleHash)), wrapWidth);
            if (textByteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(nativeTextStart);
            }

            return ret;
        }
        */

        #endregion

        public static bool Begin(string name, ImGuiWindowFlags flags)
        {
            int utf8NameByteCount = Encoding.UTF8.GetByteCount(name);
            byte* utf8NameBytes;
            if (utf8NameByteCount > Util.StackAllocationSizeLimit)
            {
                utf8NameBytes = Util.Allocate(utf8NameByteCount + 1);
            }
            else
            {
                byte* stackPtr = stackalloc byte[utf8NameByteCount + 1];
                utf8NameBytes = stackPtr;
            }
            Util.GetUtf8(name, utf8NameBytes, utf8NameByteCount);

            byte* p_open = null;
            byte ret = ImGuiNative.igBegin(utf8NameBytes, p_open, flags);

            if (utf8NameByteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(utf8NameBytes);
            }

            return ret != 0;
        }

        public static bool MenuItem(string label, bool enabled)
        {
            return MenuItem(label, string.Empty, false, enabled);
        }

        #region InputScalar

        public static bool InputScalarInt8(string label, ref byte p_data)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.U8, p_native_data);
            }
        }

        public static bool InputScalarInt8(string label, ref byte p_data, byte p_step)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.U8, p_native_data, &p_step);
            }
        }

        public static bool InputScalarInt8(string label, ref byte p_data, byte p_step, byte p_step_fast)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.U8, p_native_data, &p_step, &p_step_fast);
            }
        }

        public static bool InputScalarInt8(string label, ref byte p_data, byte p_step, byte p_step_fast, string format)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.U8, p_native_data, &p_step, &p_step_fast, format);
            }
        }

        public static bool InputScalarInt8(string label, ref byte p_data, byte p_step, byte p_step_fast, string format, ImGuiInputTextFlags flags)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.U8, p_native_data, &p_step, &p_step_fast, format, flags);
            }
        }

        public static bool InputScalarInt16(string label, ref short p_data)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.S16, p_native_data);
            }
        }

        public static bool InputScalarInt16(string label, ref short p_data, short p_step)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.S16, p_native_data, &p_step);
            }
        }

        public static bool InputScalarInt16(string label, ref short p_data, short p_step, short p_step_fast)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.S16, p_native_data, &p_step, &p_step_fast);
            }
        }

        public static bool InputScalarInt16(string label, ref short p_data, short p_step, short p_step_fast, string format)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.S16, p_native_data, &p_step, &p_step_fast, format);
            }
        }

        public static bool InputScalarInt16(string label, ref short p_data, short p_step, short p_step_fast, string format, ImGuiInputTextFlags flags)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.S16, p_native_data, &p_step, &p_step_fast, format, flags);
            }
        }

        public static bool InputScalarUInt16(string label, ref ushort p_data)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.U16, p_native_data);
            }
        }

        public static bool InputScalarUInt16(string label, ref ushort p_data, ushort p_step)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.U16, p_native_data, &p_step);
            }
        }

        public static bool InputScalarUInt16(string label, ref ushort p_data, ushort p_step, ushort p_step_fast)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.U16, p_native_data, &p_step, &p_step_fast);
            }
        }

        public static bool InputScalarUInt16(string label, ref ushort p_data, ushort p_step, ushort p_step_fast, string format)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.U16, p_native_data, &p_step, &p_step_fast, format);
            }
        }

        public static bool InputScalarUInt16(string label, ref ushort p_data, ushort p_step, ushort p_step_fast, string format, ImGuiInputTextFlags flags)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.U16, p_native_data, &p_step, &p_step_fast, format, flags);
            }
        }

        public static bool InputScalarInt32(string label, ref int p_data)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.S32, p_native_data);
            }
        }

        public static bool InputScalarInt32(string label, ref int p_data, int p_step)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.S32, p_native_data, &p_step);
            }
        }

        public static bool InputScalarInt32(string label, ref int p_data, int p_step, int p_step_fast)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.S32, p_native_data, &p_step, &p_step_fast);
            }
        }

        public static bool InputScalarInt32(string label, ref int p_data, int p_step, int p_step_fast, string format)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.S32, p_native_data, &p_step, &p_step_fast, format);
            }
        }

        public static bool InputScalarInt32(string label, ref int p_data, int p_step, int p_step_fast, string format, ImGuiInputTextFlags flags)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.S32, p_native_data, &p_step, &p_step_fast, format, flags);
            }
        }

        public static bool InputScalarUInt32(string label, ref uint p_data)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.U32, p_native_data);
            }
        }

        public static bool InputScalarUInt32(string label, ref uint p_data, uint p_step)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.U32, p_native_data, &p_step);
            }
        }

        public static bool InputScalarUInt32(string label, ref uint p_data, uint p_step, uint p_step_fast)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.U32, p_native_data, &p_step, &p_step_fast);
            }
        }

        public static bool InputScalarUInt32(string label, ref uint p_data, uint p_step, uint p_step_fast, string format)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.U32, p_native_data, &p_step, &p_step_fast, format);
            }
        }

        public static bool InputScalarUInt32(string label, ref uint p_data, uint p_step, uint p_step_fast, string format, ImGuiInputTextFlags flags)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.U32, p_native_data, &p_step, &p_step_fast, format, flags);
            }
        }

        public static bool InputScalarFloat(string label, ref float p_data)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.Float, p_native_data);
            }
        }

        public static bool InputScalarFloat(string label, ref float p_data, float p_step)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.Float, p_native_data, &p_step);
            }
        }

        public static bool InputScalarFloat(string label, ref float p_data, float p_step, float p_step_fast)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.Float, p_native_data, &p_step, &p_step_fast);
            }
        }

        public static bool InputScalarFloat(string label, ref float p_data, float p_step, float p_step_fast, string format)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.Float, p_native_data, &p_step, &p_step_fast, format);
            }
        }

        public static bool InputScalarFloat(string label, ref float p_data, float p_step, float p_step_fast, string format, ImGuiInputTextFlags flags)
        {
            fixed (void* p_native_data = &p_data)
            {
                return InputScalarTypeless(label, ImGuiDataType.Float, p_native_data, &p_step, &p_step_fast, format, flags);
            }
        }

        public static bool InputScalarTypeless(string label, ImGuiDataType data_type, void *p_data, void* p_step = null, void* p_step_fast = null, string format = null, ImGuiInputTextFlags flags = ImGuiInputTextFlags.None)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }

            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte ret = ImGuiNative.igInputScalar(native_label, data_type, p_data, p_step, p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }

        #endregion

        #region InputInt2

        public static bool InputInt2(string label, ref Point v, ImGuiInputTextFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (Point* native_v = &v)
            {
                int* intp = (int*)native_v;
                byte ret = ImGuiNative.igInputInt2(native_label, intp, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }

        #endregion

        #region InputInt3

        public static bool InputInt3(string label, ref SharpDX.Int3 v)
        {
            return InputInt3(label, ref v, ImGuiInputTextFlags.None);
        }
        public static bool InputInt3(string label, ref SharpDX.Int3 v, ImGuiInputTextFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (SharpDX.Int3* native_v = &v)
            {
                int* intp = (int*)native_v;
                byte ret = ImGuiNative.igInputInt3(native_label, intp, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }

        #endregion

        #region InputInt4

        public static bool InputInt4(string label, ref SharpDX.Int4 v)
        {
            return InputInt4(label, ref v, ImGuiInputTextFlags.None);
        }
        public static bool InputInt4(string label, ref SharpDX.Int4 v, ImGuiInputTextFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (SharpDX.Int4* native_v = &v)
            {
                int* intp = (int*)native_v;
                byte ret = ImGuiNative.igInputInt4(native_label, intp, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }

        #endregion

        #region Misc

        public static void ScrollToBringRectIntoView()
        {
            ImGuiNative.igScrollToBringRectIntoView();
        }

        public static float GetWindowContentRegionWidth()
        {
            // OBSOLETED in 1.85 (from August 2021)
            return ImGui.GetWindowContentRegionMax().X - ImGui.GetWindowContentRegionMin().X;
        }

        #endregion

        #region DockBuilder

        /*
        public static void DockBuilderDockWindow(string window_name, uint node_id)
        {
            int utf8NameByteCount = Encoding.UTF8.GetByteCount(window_name);
            byte* utf8NameBytes;
            if (utf8NameByteCount > Util.StackAllocationSizeLimit)
            {
                utf8NameBytes = Util.Allocate(utf8NameByteCount + 1);
            }
            else
            {
                byte* stackPtr = stackalloc byte[utf8NameByteCount + 1];
                utf8NameBytes = stackPtr;
            }
            Util.GetUtf8(window_name, utf8NameBytes, utf8NameByteCount);

            ImGuiNative.igDockBuilderDockWindow(utf8NameBytes, node_id);

            if (utf8NameByteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(utf8NameBytes);
            }
        }

        public static uint DockBuilderSplitNode(uint node_id, ImGuiDir split_dir, float size_ratio_for_node_at_dir, out uint out_id_at_dir, out uint out_id_at_opposite_dir)
        {
            out_id_at_dir = 0;
            out_id_at_opposite_dir = 0;

            return ImGuiNative.igDockBuilderSplitNode(node_id, split_dir, size_ratio_for_node_at_dir, ref out_id_at_dir, ref out_id_at_opposite_dir);
        }

        public static uint DockBuilderAddNode(uint node_id = 0, ImGuiDockNodeFlags flags = ImGuiDockNodeFlags.None)
        {
            return ImGuiNative.igDockBuilderAddNode(node_id, flags);
        }

        public static void DockBuilderRemoveNode(uint node_id)
        {
            ImGuiNative.igDockBuilderRemoveNode(node_id);
        }

        public static void DockBuilderSetNodePos(uint node_id, Vector2 pos)
        {
            ImGuiNative.igDockBuilderSetNodePos(node_id, pos);
        }

        public static void DockBuilderSetNodeSize(uint node_id, Vector2 size)
        {
            ImGuiNative.igDockBuilderSetNodeSize(node_id, size);
        }

        public static void DockBuilderFinish(uint node_id)
        {
            ImGuiNative.igDockBuilderFinish(node_id);
        }
        */

        #endregion
    }
}
