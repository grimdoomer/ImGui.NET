using System;
using System.Collections.Generic;
using System.Text;

namespace ImGuiNET
{
    public enum ImGuiItemFlags
    {
        None = 0,
        NoTabStop = 1,
        ButtonRepeat = 2,
        Disabled = 4,
        NoNav = 8,
        NoNavDefaultFocus = 0x10,
        SelectableDontClosePopup = 0x20,
        MixedValue = 0x40,
        ReadOnly = 0x80
    }
}
