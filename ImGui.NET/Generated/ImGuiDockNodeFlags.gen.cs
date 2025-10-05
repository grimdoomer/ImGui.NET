namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiDockNodeFlags
    {
        None = 0,
        KeepAliveOnly = 1,
        NoDockingOverCentralNode = 4,
        PassthruCentralNode = 8,
        NoDockingSplit = 16,
        NoResize = 32,
        AutoHideTabBar = 64,
        NoUndocking = 128,
        
        // Private flags:
        DockSpace = 1024,
        CentralNode = 2048,
        NoTabBar = 4096,
        HiddenTabBar = 8192,
        NoWindowMenuButton = 16384,
        NoCloseButton = 32768,
        NoResizeX = 65536,
        NoResizeY = 131072,
        DockedWindowsInFocusRoute = 262144,
        NoDockingSplitOther = 524288,
        NoDockingOverMe = 1048576,
        NoDockingOverOther = 2097152,
        NoDockingOverEmpty = 4194304,
        NoDocking = 7864336,
        SharedFlagsInheritMask = -1,
        NoResizeFlagsMask = 196640,
        LocalFlagsTransferMask = 260208,
        SavedFlagsMask = 261152,
    }
}
