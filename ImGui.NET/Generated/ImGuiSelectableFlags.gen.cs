namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiSelectableFlags
    {
        None = 0,
        NoAutoClosePopups = 1,
        SpanAllColumns = 2,
        AllowDoubleClick = 4,
        Disabled = 8,
        AllowOverlap = 16,
        Highlight = 32,
        SelectOnNav = 64,
        
        // Private flags:
        NoHoldingActiveID = 1048576,
        SelectOnClick = 4194304,
        SelectOnRelease = 8388608,
        SpanAvailWidth = 16777216,
        SetNavIdOnHover = 33554432,
        NoPadWithHalfSpacing = 67108864,
        NoSetKeyOwner = 134217728,
    }
}
