namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiWindowRefreshFlags
    {
        None = 0,
        TryToAvoidRefresh = 1,
        RefreshOnHover = 2,
        RefreshOnFocus = 4,
    }
}
