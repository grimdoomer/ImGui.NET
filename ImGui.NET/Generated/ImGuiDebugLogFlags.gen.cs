namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiDebugLogFlags
    {
        None = 0,
        EventActiveId = 1,
        EventFocus = 2,
        EventPopup = 4,
        EventNav = 8,
        EventIO = 16,
        EventDocking = 32,
        EventViewport = 64,
        EventMask = 127,
        OutputToTTY = 1024,
    }
}
