namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiDebugLogFlags
    {
        None = 0,
        EventError = 1,
        EventActiveId = 2,
        EventFocus = 4,
        EventPopup = 8,
        EventNav = 16,
        EventClipper = 32,
        EventSelection = 64,
        EventIO = 128,
        EventFont = 256,
        EventInputRouting = 512,
        EventDocking = 1024,
        EventViewport = 2048,
        EventMask = 4095,
        OutputToTTY = 1048576,
        OutputToTestEngine = 2097152,
    }
}
