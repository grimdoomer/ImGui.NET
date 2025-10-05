namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiInputFlags
    {
        None = 0,
        Repeat = 1,
        RouteActive = 1024,
        RouteFocused = 2048,
        RouteGlobal = 4096,
        RouteAlways = 8192,
        RouteOverFocused = 16384,
        RouteOverActive = 32768,
        RouteUnlessBgFocused = 65536,
        RouteFromRootWindow = 131072,
        Tooltip = 262144,
        
        // Private flags:
        RepeatRateDefault = 2,
        RepeatRateNavMove = 4,
        RepeatRateNavTweak = 8,
        RepeatUntilRelease = 16,
        RepeatUntilKeyModsChange = 32,
        RepeatUntilKeyModsChangeFromNone = 64,
        RepeatUntilOtherKeyPress = 128,
        LockThisFrame = 1048576,
        LockUntilRelease = 2097152,
        CondHovered = 4194304,
        CondActive = 8388608,
        CondDefault = 12582912,
        RepeatRateMask = 14,
        RepeatUntilMask = 240,
        RepeatMask = 255,
        CondMask = 12582912,
        RouteTypeMask = 15360,
        RouteOptionsMask = 245760,
        SupportedByIsKeyPressed = 255,
        SupportedByIsMouseClicked = 1,
        SupportedByShortcut = 261375,
        SupportedBySetNextItemShortcut = 523519,
        SupportedBySetKeyOwner = 3145728,
        SupportedBySetItemKeyOwner = 15728640,
    }
}
