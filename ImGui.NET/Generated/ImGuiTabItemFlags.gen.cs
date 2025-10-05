namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiTabItemFlags
    {
        None = 0,
        UnsavedDocument = 1,
        SetSelected = 2,
        NoCloseWithMiddleMouseButton = 4,
        NoPushId = 8,
        NoTooltip = 16,
        NoReorder = 32,
        Leading = 64,
        Trailing = 128,
        NoAssumedClosure = 256,
        
        // Private flags:
        SectionMask = 192,
        NoCloseButton = 1048576,
        Button = 2097152,
        Invisible = 4194304,
        Unsorted = 8388608,
    }
}
