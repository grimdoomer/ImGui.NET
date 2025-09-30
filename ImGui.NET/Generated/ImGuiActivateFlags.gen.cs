namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiActivateFlags
    {
        None = 0,
        PreferInput = 1,
        PreferTweak = 2,
        TryToPreserveState = 4,
        FromTabbing = 8,
        FromShortcut = 16,
        FromFocusApi = 32,
    }
}
