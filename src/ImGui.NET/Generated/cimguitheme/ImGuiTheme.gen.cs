using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using ImGuiNET;

namespace ImGuiThemeNET
{
    public static unsafe partial class ImGuiTheme
    {
        public static void ApplyTheme(ImGuiThemeType theme)
        {
            ImGuiThemeNative.ImGuiTheme_ApplyTheme(theme);
        }
        public static void ApplyTweakedTheme(ImGuiTweakedTheme tweaked_theme)
        {
            ImGuiThemeNative.ImGuiTheme_ApplyTweakedTheme(tweaked_theme);
        }
        public static ImGuiStyle Darcula()
        {
            float rounding = 1f;
            float hue = -1f;
            float saturation_multiplier = 1f;
            float value_multiplier_front = 1f;
            float value_multiplier_bg = 1f;
            float alpha_bg_transparency = 1f;
            ImGuiStyle ret = ImGuiThemeNative.ImGuiTheme_Darcula(rounding, hue, saturation_multiplier, value_multiplier_front, value_multiplier_bg, alpha_bg_transparency);
            return ret;
        }
        public static ImGuiStyle Darcula(float rounding)
        {
            float hue = -1f;
            float saturation_multiplier = 1f;
            float value_multiplier_front = 1f;
            float value_multiplier_bg = 1f;
            float alpha_bg_transparency = 1f;
            ImGuiStyle ret = ImGuiThemeNative.ImGuiTheme_Darcula(rounding, hue, saturation_multiplier, value_multiplier_front, value_multiplier_bg, alpha_bg_transparency);
            return ret;
        }
        public static ImGuiStyle Darcula(float rounding, float hue)
        {
            float saturation_multiplier = 1f;
            float value_multiplier_front = 1f;
            float value_multiplier_bg = 1f;
            float alpha_bg_transparency = 1f;
            ImGuiStyle ret = ImGuiThemeNative.ImGuiTheme_Darcula(rounding, hue, saturation_multiplier, value_multiplier_front, value_multiplier_bg, alpha_bg_transparency);
            return ret;
        }
        public static ImGuiStyle Darcula(float rounding, float hue, float saturation_multiplier)
        {
            float value_multiplier_front = 1f;
            float value_multiplier_bg = 1f;
            float alpha_bg_transparency = 1f;
            ImGuiStyle ret = ImGuiThemeNative.ImGuiTheme_Darcula(rounding, hue, saturation_multiplier, value_multiplier_front, value_multiplier_bg, alpha_bg_transparency);
            return ret;
        }
        public static ImGuiStyle Darcula(float rounding, float hue, float saturation_multiplier, float value_multiplier_front)
        {
            float value_multiplier_bg = 1f;
            float alpha_bg_transparency = 1f;
            ImGuiStyle ret = ImGuiThemeNative.ImGuiTheme_Darcula(rounding, hue, saturation_multiplier, value_multiplier_front, value_multiplier_bg, alpha_bg_transparency);
            return ret;
        }
        public static ImGuiStyle Darcula(float rounding, float hue, float saturation_multiplier, float value_multiplier_front, float value_multiplier_bg)
        {
            float alpha_bg_transparency = 1f;
            ImGuiStyle ret = ImGuiThemeNative.ImGuiTheme_Darcula(rounding, hue, saturation_multiplier, value_multiplier_front, value_multiplier_bg, alpha_bg_transparency);
            return ret;
        }
        public static ImGuiStyle Darcula(float rounding, float hue, float saturation_multiplier, float value_multiplier_front, float value_multiplier_bg, float alpha_bg_transparency)
        {
            ImGuiStyle ret = ImGuiThemeNative.ImGuiTheme_Darcula(rounding, hue, saturation_multiplier, value_multiplier_front, value_multiplier_bg, alpha_bg_transparency);
            return ret;
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static ImGuiThemeType ImGuiTheme_FromName(ReadOnlySpan<char> themeName)
        {
            byte* native_themeName;
            int themeName_byteCount = 0;
            if (themeName != null)
            {
                themeName_byteCount = Encoding.UTF8.GetByteCount(themeName);
                if (themeName_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_themeName = Util.Allocate(themeName_byteCount + 1);
                }
                else
                {
                    byte* native_themeName_stackBytes = stackalloc byte[themeName_byteCount + 1];
                    native_themeName = native_themeName_stackBytes;
                }
                int native_themeName_offset = Util.GetUtf8(themeName, native_themeName, themeName_byteCount);
                native_themeName[native_themeName_offset] = 0;
            }
            else { native_themeName = null; }
            ImGuiThemeType ret = ImGuiThemeNative.ImGuiTheme_ImGuiTheme_FromName(native_themeName);
            if (themeName_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_themeName);
            }
            return ret;
        }
#endif
        public static ImGuiThemeType ImGuiTheme_FromName(string themeName)
        {
            byte* native_themeName;
            int themeName_byteCount = 0;
            if (themeName != null)
            {
                themeName_byteCount = Encoding.UTF8.GetByteCount(themeName);
                if (themeName_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_themeName = Util.Allocate(themeName_byteCount + 1);
                }
                else
                {
                    byte* native_themeName_stackBytes = stackalloc byte[themeName_byteCount + 1];
                    native_themeName = native_themeName_stackBytes;
                }
                int native_themeName_offset = Util.GetUtf8(themeName, native_themeName, themeName_byteCount);
                native_themeName[native_themeName_offset] = 0;
            }
            else { native_themeName = null; }
            ImGuiThemeType ret = ImGuiThemeNative.ImGuiTheme_ImGuiTheme_FromName(native_themeName);
            if (themeName_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_themeName);
            }
            return ret;
        }
        public static string ImGuiTheme_Name(ImGuiThemeType theme)
        {
            byte* ret = ImGuiThemeNative.ImGuiTheme_ImGuiTheme_Name(theme);
            return Util.StringFromPtr(ret);
        }
        public static void PopTweakedTheme()
        {
            ImGuiThemeNative.ImGuiTheme_PopTweakedTheme();
        }
        public static void PushTweakedTheme(ImGuiTweakedTheme tweaked_theme)
        {
            ImGuiThemeNative.ImGuiTheme_PushTweakedTheme(tweaked_theme);
        }
        public static ImGuiStyle ShadesOfGray()
        {
            float rounding = 0f;
            float value_multiplier_front = 1f;
            float value_multiplier_bg = 1f;
            ImGuiStyle ret = ImGuiThemeNative.ImGuiTheme_ShadesOfGray(rounding, value_multiplier_front, value_multiplier_bg);
            return ret;
        }
        public static ImGuiStyle ShadesOfGray(float rounding)
        {
            float value_multiplier_front = 1f;
            float value_multiplier_bg = 1f;
            ImGuiStyle ret = ImGuiThemeNative.ImGuiTheme_ShadesOfGray(rounding, value_multiplier_front, value_multiplier_bg);
            return ret;
        }
        public static ImGuiStyle ShadesOfGray(float rounding, float value_multiplier_front)
        {
            float value_multiplier_bg = 1f;
            ImGuiStyle ret = ImGuiThemeNative.ImGuiTheme_ShadesOfGray(rounding, value_multiplier_front, value_multiplier_bg);
            return ret;
        }
        public static ImGuiStyle ShadesOfGray(float rounding, float value_multiplier_front, float value_multiplier_bg)
        {
            ImGuiStyle ret = ImGuiThemeNative.ImGuiTheme_ShadesOfGray(rounding, value_multiplier_front, value_multiplier_bg);
            return ret;
        }
        public static bool ShowThemeTweakGui(ImGuiTweakedThemePtr tweaked_theme)
        {
            ImGuiTweakedTheme* native_tweaked_theme = tweaked_theme.NativePtr;
            byte ret = ImGuiThemeNative.ImGuiTheme_ShowThemeTweakGui(native_tweaked_theme);
            return ret != 0;
        }
        public static ImGuiStyle SoDark(float hue)
        {
            ImGuiStyle ret = ImGuiThemeNative.ImGuiTheme_SoDark(hue);
            return ret;
        }
        public static ImGuiStyle ThemeToStyle(ImGuiThemeType theme)
        {
            ImGuiStyle ret = ImGuiThemeNative.ImGuiTheme_ThemeToStyle(theme);
            return ret;
        }
        public static ImGuiStyle TweakedThemeThemeToStyle(ImGuiTweakedTheme tweaked_theme)
        {
            ImGuiStyle ret = ImGuiThemeNative.ImGuiTheme_TweakedThemeThemeToStyle(tweaked_theme);
            return ret;
        }
    }
}
