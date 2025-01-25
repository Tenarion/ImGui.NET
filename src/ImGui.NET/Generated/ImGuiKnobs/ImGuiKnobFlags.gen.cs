namespace ImGuiKnobsNET
{
    [System.Flags]
    public enum ImGuiKnobFlags
    {
        NoTitle = 1,
        NoInput = 2,
        ValueTooltip = 4,
        DragHorizontal = 8,
        DragVertical = 16,
        Logarithmic = 32,
        AlwaysClamp = 64,
    }
}
