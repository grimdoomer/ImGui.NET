using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ImGuiNET
{
    public unsafe struct ImVector
    {
        public readonly int Size;
        public readonly int Capacity;
        public readonly IntPtr Data;

        public ref T Ref<T>(int index)
        {
            return ref Unsafe.AsRef<T>((byte*)Data + index * Unsafe.SizeOf<T>());
        }

        public IntPtr Address<T>(int index)
        {
            return (IntPtr)((byte*)Data + index * Unsafe.SizeOf<T>());
        }
    }

    public unsafe struct ImVector<T>
    {
        public readonly int Size;
        public readonly int Capacity;
        public readonly IntPtr Data;

        public ImVector(ImVector vector)
        {
            Size = vector.Size;
            Capacity = vector.Capacity;
            Data = vector.Data;
        }

        public ImVector(ImVector* vector)
        {
            if (vector != null)
            {
                Size = vector->Size;
                Capacity = vector->Capacity;
                Data = vector->Data;
            }
            else
            {
                Size = 0;
                Capacity = 0;
                Data = IntPtr.Zero;
            }
        }

        public ImVector(int size, int capacity, IntPtr data)
        {
            Size = size;
            Capacity = capacity;
            Data = data;
        }

        public ref T this[int index] => ref Unsafe.AsRef<T>((byte*)Data + index * Unsafe.SizeOf<T>());
    }

    public unsafe struct ImPtrVector<T>
    {
        public readonly int Size;
        public readonly int Capacity;
        public readonly IntPtr Data;
        private readonly int _stride;

        public ImPtrVector(ImVector vector, int stride)
            : this(vector.Size, vector.Capacity, vector.Data, stride)
        { }

        public ImPtrVector(int size, int capacity, IntPtr data, int stride)
        {
            Size = size;
            Capacity = capacity;
            Data = data;
            _stride = stride;
        }

        public T this[int index]
        {
            get
            {
                byte* address = (byte*)Data + index * _stride;
                T ret = Unsafe.Read<T>(&address);
                return ret;
            }
        }
    }

    public unsafe struct ImStableVector
    {
        public readonly int Size;
        public readonly int Capacity;
        public readonly ImVector Blocks;
    }

    public unsafe struct ImStableVector<T>
    {
        public readonly int Size;
        public readonly int Capacity;
        public readonly ImVector Blocks;
        public readonly int BlockSize;
        private readonly int _stride;

        public ImStableVector(ImStableVector vector, int blockSize)
        {
            this.Size = vector.Size;
            this.Capacity = vector.Capacity;
            this.Blocks = vector.Blocks;
            this.BlockSize = blockSize;
            this._stride = Unsafe.SizeOf<T>();
        }
    }
}
