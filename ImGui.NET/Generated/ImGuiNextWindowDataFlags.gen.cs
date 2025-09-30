namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiNextWindowDataFlags
    {
        None = 0,
        HasPos = 1,
        HasSize = 2,
        HasContentSize = 4,
        HasCollapsed = 8,
        HasSizeConstraint = 16,
        HasFocus = 32,
        HasBgAlpha = 64,
        HasScroll = 128,
        HasWindowFlags = 256,
        HasChildFlags = 512,
        HasRefreshPolicy = 1024,
        HasViewport = 2048,
        HasDock = 4096,
        HasWindowClass = 8192,
    }
}
