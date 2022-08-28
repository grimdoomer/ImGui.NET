using System;
using System.Collections.Generic;
using System.Text;

namespace ImGuiNET
{
    public unsafe struct ImSpan
    {
        public readonly IntPtr Data;
        public readonly IntPtr DataEnd;
    }
}
