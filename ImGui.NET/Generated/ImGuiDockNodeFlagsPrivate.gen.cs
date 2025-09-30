namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiDockNodeFlagsPrivate
    {
        ImGuiDockNodeFlags_DockSpace = 1024,
        ImGuiDockNodeFlags_CentralNode = 2048,
        ImGuiDockNodeFlags_NoTabBar = 4096,
        ImGuiDockNodeFlags_HiddenTabBar = 8192,
        ImGuiDockNodeFlags_NoWindowMenuButton = 16384,
        ImGuiDockNodeFlags_NoCloseButton = 32768,
        ImGuiDockNodeFlags_NoResizeX = 65536,
        ImGuiDockNodeFlags_NoResizeY = 131072,
        ImGuiDockNodeFlags_DockedWindowsInFocusRoute = 262144,
        ImGuiDockNodeFlags_NoDockingSplitOther = 524288,
        ImGuiDockNodeFlags_NoDockingOverMe = 1048576,
        ImGuiDockNodeFlags_NoDockingOverOther = 2097152,
        ImGuiDockNodeFlags_NoDockingOverEmpty = 4194304,
        ImGuiDockNodeFlags_NoDocking = 7864336,
        ImGuiDockNodeFlags_SharedFlagsInheritMask = -1,
        ImGuiDockNodeFlags_NoResizeFlagsMask = 196640,
        ImGuiDockNodeFlags_LocalFlagsTransferMask = 260208,
        ImGuiDockNodeFlags_SavedFlagsMask = 261152,
    }
}
