using System;
using System.Numerics;
using System.Runtime.InteropServices;
using ImGuiNET;

namespace ImGuiKnobsNET
{
    public static unsafe partial class ImGuiKnobsNative
    {
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern color_set* color_set_color_set_Color(ImColor @base, ImColor hovered, ImColor active);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern color_set* color_set_color_set_Nil(ImColor color);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void color_set_destroy(color_set* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiKnobs_Knob(byte* label, float* p_value, float v_min, float v_max, float speed, byte* format, ImGuiKnobVariant variant, float size, ImGuiKnobFlags flags, int steps, float angle_min, float angle_max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiKnobs_KnobInt(byte* label, int* p_value, int v_min, int v_max, float speed, byte* format, ImGuiKnobVariant variant, float size, ImGuiKnobFlags flags, int steps, float angle_min, float angle_max);
    }
}
