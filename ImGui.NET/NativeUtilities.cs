using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ImGuiNET
{
    public static unsafe class NativeUtilities
    {
        public const int StackAllocationSizeLimit = 2048;

        public static string StringFromPtr(byte* ptr)
        {
            int characters = 0;
            while (ptr[characters] != 0)
            {
                characters++;
            }

            return Encoding.UTF8.GetString(ptr, characters);
        }

        public static bool AreStringsEqual(byte* a, int aLength, byte* b)
        {
            for (int i = 0; i < aLength; i++)
            {
                if (a[i] != b[i]) { return false; }
            }

            if (b[aLength] != 0) { return false; }

            return true;
        }

        public static byte* AllocateNativeBuffer(int byteCount)
        {
            byte* pAlloc = (byte*)Marshal.AllocHGlobal(byteCount);
            for (int i = 0; i < byteCount; i++)
                pAlloc[i] = 0;

            return pAlloc;
        }

        public static void FreeNativeBuffer(byte* ptr) => Marshal.FreeHGlobal((IntPtr)ptr);

        public static int CalcSizeInUtf8(string s, int start, int length)
        {
            if (start < 0 || length < 0 || start + length > s.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            fixed (char* utf16Ptr = s)
            {
                return Encoding.UTF8.GetByteCount(utf16Ptr + start, length);
            }
        }

        public static int GetUtf8(string s, byte* utf8Bytes, int utf8ByteCount)
        {
            fixed (char* utf16Ptr = s)
            {
                return Encoding.UTF8.GetBytes(utf16Ptr, s.Length, utf8Bytes, utf8ByteCount);
            }
        }

        public static int GetUtf8(string s, int start, int length, byte* utf8Bytes, int utf8ByteCount)
        {
            if (start < 0 || length < 0 || start + length > s.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            fixed (char* utf16Ptr = s)
            {
                return Encoding.UTF8.GetBytes(utf16Ptr + start, length, utf8Bytes, utf8ByteCount);
            }
        }

        public static byte* GetNativeStringBuffer(string str)
        {
            // Allocate a pinned buffer to hold the string contents.
            int length = Encoding.UTF8.GetByteCount(str) + 1;
            byte* pNativeString = (byte*)Marshal.AllocHGlobal(length);

            // Copy the managed string contents into the native buffer.
            fixed (char* pManagedStr = str)
            {
                Encoding.UTF8.GetBytes(pManagedStr, str.Length, pNativeString, length);
            }

            // Null terminate the native string.
            pNativeString[length - 1] = 0;

            return pNativeString;
        }
    }
}
