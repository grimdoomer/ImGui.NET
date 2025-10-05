namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiItemFlags
    {
        None = 0,
        NoTabStop = 1,
        NoNav = 2,
        NoNavDefaultFocus = 4,
        ButtonRepeat = 8,
        AutoClosePopups = 16,
        AllowDuplicateId = 32,
        
        // Private flags:
        Disabled = 1024,
        ReadOnly = 2048,
        MixedValue = 4096,
        NoWindowHoverableCheck = 8192,
        AllowOverlap = 16384,
        NoNavDisableMouseHover = 32768,
        NoMarkEdited = 65536,
        NoFocus = 131072,
        Inputable = 1048576,
        HasSelectionUserData = 2097152,
        IsMultiSelect = 4194304,
        Default = 16,
    }
}
