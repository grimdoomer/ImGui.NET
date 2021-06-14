﻿using System;
using System.Numerics;
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

        public static void PushItemFlag(ImGuiItemFlags option, bool enabled)
        {
            ImGuiNative.igPushItemFlag(option, enabled);
        }

        public static void PopItemFlag()
        {
            ImGuiNative.igPopItemFlag();
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

        #region InputFloat2

        public static bool InputFloat2(string label, ref SharpDX.Vector2 v)
        {
            return InputFloat2(label, ref v, "%.3f", ImGuiInputTextFlags.None);
        }

        public static bool InputFloat2(string label, ref SharpDX.Vector2 v, string format)
        {
            return InputFloat2(label, ref v, format, ImGuiInputTextFlags.None);
        }

        public static bool InputFloat2(string label, ref SharpDX.Vector2 v, string format, ImGuiInputTextFlags flags)
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
            fixed (SharpDX.Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.igInputFloat2(native_label, native_v, native_format, flags);
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
        }

        #endregion

        #region InputFloat3

        public static bool InputFloat3(string label, ref SharpDX.Vector3 v)
        {
            return InputFloat3(label, ref v, "%.3f", ImGuiInputTextFlags.None);
        }

        public static bool InputFloat3(string label, ref SharpDX.Vector3 v, string format)
        {
            return InputFloat3(label, ref v, format, ImGuiInputTextFlags.None);
        }

        public static bool InputFloat3(string label, ref SharpDX.Vector3 v, string format, ImGuiInputTextFlags flags)
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
            fixed (SharpDX.Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.igInputFloat3(native_label, native_v, native_format, flags);
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
        }

        #endregion

        #region InputFloat4

        public static bool InputFloat4(string label, ref SharpDX.Vector4 v)
        {
            return InputFloat4(label, ref v, "%.3f", ImGuiInputTextFlags.None);
        }

        public static bool InputFloat4(string label, ref SharpDX.Vector4 v, string format)
        {
            return InputFloat4(label, ref v, format, ImGuiInputTextFlags.None);
        }

        public static bool InputFloat4(string label, ref SharpDX.Vector4 v, string format, ImGuiInputTextFlags flags)
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
            fixed (SharpDX.Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.igInputFloat4(native_label, native_v, native_format, flags);
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
        }

        #endregion

        #region InputInt2

        public static bool InputInt2(string label, ref SharpDX.Point v)
        {
            return InputInt2(label, ref v, ImGuiInputTextFlags.None);
        }
        public static bool InputInt2(string label, ref SharpDX.Point v, ImGuiInputTextFlags flags)
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
            fixed (SharpDX.Point* native_v = &v)
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

        #endregion
    }
}
