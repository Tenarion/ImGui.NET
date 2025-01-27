using System;
using System.Numerics;
using System.Runtime.InteropServices;
using ImGuiNET;

namespace ImGuiExtraNET
{
    public static unsafe partial class ImGuiExtraNative
    {
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiExtra_Curve(byte* label, Vector2 size, int maxpoints, Vector2* points, int* selection, Vector2 rangeMin, Vector2 rangeMax);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiExtra_CurveValue(float p, int maxpoints, Vector2* points);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiExtra_CurveValueSmooth(float p, int maxpoints, Vector2* points);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiExtra_DrawRowsBackground(int row_count, float line_height, float x1, float x2, float y_offset, uint col_even, uint col_odd);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiExtra_SanityCheck(byte* text);
    }
}
