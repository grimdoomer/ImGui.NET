namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiNavMoveFlags
    {
        None = 0,
        LoopX = 1,
        LoopY = 2,
        WrapX = 4,
        WrapY = 8,
        WrapMask = 15,
        AllowCurrentNavId = 16,
        AlsoScoreVisibleSet = 32,
        ScrollToEdgeY = 64,
        Forwarded = 128,
        DebugNoResult = 256,
        FocusApi = 512,
        IsTabbing = 1024,
        IsPageMove = 2048,
        Activate = 4096,
        NoSelect = 8192,
        NoSetNavCursorVisible = 16384,
        NoClearActiveId = 32768,
    }
}
