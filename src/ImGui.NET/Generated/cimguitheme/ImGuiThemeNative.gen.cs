using System;
using System.Numerics;
using System.Runtime.InteropServices;
using ImGuiNET;

namespace ImGuiThemeNET
{
    public static unsafe partial class ImGuiThemeNative
    {
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTheme_ApplyTheme(ImGuiThemeType theme);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTheme_ApplyTweakedTheme(ImGuiTweakedTheme tweaked_theme);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle ImGuiTheme_Darcula(float rounding, float hue, float saturation_multiplier, float value_multiplier_front, float value_multiplier_bg, float alpha_bg_transparency);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiThemeType ImGuiTheme_ImGuiTheme_FromName(byte* themeName);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTheme_ImGuiTheme_Name(ImGuiThemeType theme);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTheme_PopTweakedTheme();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTheme_PushTweakedTheme(ImGuiTweakedTheme tweaked_theme);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle ImGuiTheme_ShadesOfGray(float rounding, float value_multiplier_front, float value_multiplier_bg);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTheme_ShowThemeTweakGui(ImGuiTweakedTheme* tweaked_theme);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle ImGuiTheme_SoDark(float hue);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle ImGuiTheme_ThemeToStyle(ImGuiThemeType theme);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle ImGuiTheme_TweakedThemeThemeToStyle(ImGuiTweakedTheme tweaked_theme);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiThemeTweaks_destroy(ImGuiThemeTweaks* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiThemeTweaks* ImGuiThemeTweaks_ImGuiThemeTweaks();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTweakedTheme_destroy(ImGuiTweakedTheme* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTweakedTheme* ImGuiTweakedTheme_ImGuiTweakedTheme(ImGuiThemeType theme, ImGuiThemeTweaks tweaks);
    }
}
