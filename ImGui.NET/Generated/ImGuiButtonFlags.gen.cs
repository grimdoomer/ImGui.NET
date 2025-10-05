namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiButtonFlags
    {
        None = 0,
        MouseButtonLeft = 1,
        MouseButtonRight = 2,
        MouseButtonMiddle = 4,
        MouseButtonMask = 7,
        EnableNav = 8,
        
        // Private flags:
        PressedOnClick = 16,
        PressedOnClickRelease = 32,
        PressedOnClickReleaseAnywhere = 64,
        PressedOnRelease = 128,
        PressedOnDoubleClick = 256,
        PressedOnDragDropHold = 512,
        FlattenChildren = 2048,
        AllowOverlap = 4096,
        AlignTextBaseLine = 32768,
        NoKeyModsAllowed = 65536,
        NoHoldingActiveId = 131072,
        NoNavFocus = 262144,
        NoHoveredOnFocus = 524288,
        NoSetKeyOwner = 1048576,
        NoTestKeyOwner = 2097152,
        NoFocus = 4194304,
        PressedOnMask = 1008,
        PressedOnDefault = 32,
    }
}
