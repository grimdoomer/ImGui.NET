namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiInputFlagsPrivate
    {
        ImGuiInputFlags_RepeatRateDefault = 2,
        ImGuiInputFlags_RepeatRateNavMove = 4,
        ImGuiInputFlags_RepeatRateNavTweak = 8,
        ImGuiInputFlags_RepeatUntilRelease = 16,
        ImGuiInputFlags_RepeatUntilKeyModsChange = 32,
        ImGuiInputFlags_RepeatUntilKeyModsChangeFromNone = 64,
        ImGuiInputFlags_RepeatUntilOtherKeyPress = 128,
        ImGuiInputFlags_LockThisFrame = 1048576,
        ImGuiInputFlags_LockUntilRelease = 2097152,
        ImGuiInputFlags_CondHovered = 4194304,
        ImGuiInputFlags_CondActive = 8388608,
        ImGuiInputFlags_CondDefault = 12582912,
        ImGuiInputFlags_RepeatRateMask = 14,
        ImGuiInputFlags_RepeatUntilMask = 240,
        ImGuiInputFlags_RepeatMask = 255,
        ImGuiInputFlags_CondMask = 12582912,
        ImGuiInputFlags_RouteTypeMask = 15360,
        ImGuiInputFlags_RouteOptionsMask = 245760,
        ImGuiInputFlags_SupportedByIsKeyPressed = 255,
        ImGuiInputFlags_SupportedByIsMouseClicked = 1,
        ImGuiInputFlags_SupportedByShortcut = 261375,
        ImGuiInputFlags_SupportedBySetNextItemShortcut = 523519,
        ImGuiInputFlags_SupportedBySetKeyOwner = 3145728,
        ImGuiInputFlags_SupportedBySetItemKeyOwner = 15728640,
    }
}
