namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiInputFlags
    {
        None = 0,
        Repeat = 1,
        RepeatRateDefault = 2,
        RepeatRateNavMove = 4,
        RepeatRateNavTweak = 8,
        RepeatRateMask_ = 14,
    }
}
