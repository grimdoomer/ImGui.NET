using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe struct ImPool
    {
        public ImVector Buf;
        public ImGuiStorage Map;
        public int FreeIdx;
        public int AliveCount;
    }

    public unsafe struct ImPool<T>
    {
        public ImVector Buf;
        public ImGuiStorage Map;
        public int FreeIdx;
        public int AliveCount;
        private int _stride;

        public ImPool(ImPool pool)
        {
            Buf = pool.Buf;
            Map = pool.Map;
            FreeIdx = pool.FreeIdx;
            AliveCount = pool.AliveCount;
            _stride = Unsafe.SizeOf<T>();
        }
    }
}
