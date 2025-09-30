namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiItemFlagsPrivate
    {
        ImGuiItemFlags_Disabled = 1024,
        ImGuiItemFlags_ReadOnly = 2048,
        ImGuiItemFlags_MixedValue = 4096,
        ImGuiItemFlags_NoWindowHoverableCheck = 8192,
        ImGuiItemFlags_AllowOverlap = 16384,
        ImGuiItemFlags_NoNavDisableMouseHover = 32768,
        ImGuiItemFlags_NoMarkEdited = 65536,
        ImGuiItemFlags_NoFocus = 131072,
        ImGuiItemFlags_Inputable = 1048576,
        ImGuiItemFlags_HasSelectionUserData = 2097152,
        ImGuiItemFlags_IsMultiSelect = 4194304,
        ImGuiItemFlags_Default = 16,
    }
}
