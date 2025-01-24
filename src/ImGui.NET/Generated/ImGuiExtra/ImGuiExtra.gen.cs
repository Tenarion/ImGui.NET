using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using ImGuiNET;

namespace ImGuiExtraNET
{
    public static unsafe partial class ImGuiExtra
    {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static int Curve(ReadOnlySpan<char> label, Vector2 size, int maxpoints, ref Vector2 points)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int* selection = null;
            Vector2 rangeMin = new Vector2();
            Vector2 rangeMax = new Vector2(1, 1);
            fixed (Vector2* native_points = &points)
            {
                int ret = ImGuiExtraNative.ImGuiExtra_Curve(native_label, size, maxpoints, native_points, selection, rangeMin, rangeMax);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret;
            }
        }
#endif
        public static int Curve(string label, Vector2 size, int maxpoints, ref Vector2 points)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int* selection = null;
            Vector2 rangeMin = new Vector2();
            Vector2 rangeMax = new Vector2(1, 1);
            fixed (Vector2* native_points = &points)
            {
                int ret = ImGuiExtraNative.ImGuiExtra_Curve(native_label, size, maxpoints, native_points, selection, rangeMin, rangeMax);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret;
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static int Curve(ReadOnlySpan<char> label, Vector2 size, int maxpoints, ref Vector2 points, ref int selection)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            Vector2 rangeMin = new Vector2();
            Vector2 rangeMax = new Vector2(1, 1);
            fixed (Vector2* native_points = &points)
            {
                fixed (int* native_selection = &selection)
                {
                    int ret = ImGuiExtraNative.ImGuiExtra_Curve(native_label, size, maxpoints, native_points, native_selection, rangeMin, rangeMax);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    return ret;
                }
            }
        }
#endif
        public static int Curve(string label, Vector2 size, int maxpoints, ref Vector2 points, ref int selection)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            Vector2 rangeMin = new Vector2();
            Vector2 rangeMax = new Vector2(1, 1);
            fixed (Vector2* native_points = &points)
            {
                fixed (int* native_selection = &selection)
                {
                    int ret = ImGuiExtraNative.ImGuiExtra_Curve(native_label, size, maxpoints, native_points, native_selection, rangeMin, rangeMax);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    return ret;
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static int Curve(ReadOnlySpan<char> label, Vector2 size, int maxpoints, ref Vector2 points, ref int selection, Vector2 rangeMin)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            Vector2 rangeMax = new Vector2(1, 1);
            fixed (Vector2* native_points = &points)
            {
                fixed (int* native_selection = &selection)
                {
                    int ret = ImGuiExtraNative.ImGuiExtra_Curve(native_label, size, maxpoints, native_points, native_selection, rangeMin, rangeMax);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    return ret;
                }
            }
        }
#endif
        public static int Curve(string label, Vector2 size, int maxpoints, ref Vector2 points, ref int selection, Vector2 rangeMin)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            Vector2 rangeMax = new Vector2(1, 1);
            fixed (Vector2* native_points = &points)
            {
                fixed (int* native_selection = &selection)
                {
                    int ret = ImGuiExtraNative.ImGuiExtra_Curve(native_label, size, maxpoints, native_points, native_selection, rangeMin, rangeMax);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    return ret;
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static int Curve(ReadOnlySpan<char> label, Vector2 size, int maxpoints, ref Vector2 points, ref int selection, Vector2 rangeMin, Vector2 rangeMax)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (Vector2* native_points = &points)
            {
                fixed (int* native_selection = &selection)
                {
                    int ret = ImGuiExtraNative.ImGuiExtra_Curve(native_label, size, maxpoints, native_points, native_selection, rangeMin, rangeMax);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    return ret;
                }
            }
        }
#endif
        public static int Curve(string label, Vector2 size, int maxpoints, ref Vector2 points, ref int selection, Vector2 rangeMin, Vector2 rangeMax)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (Vector2* native_points = &points)
            {
                fixed (int* native_selection = &selection)
                {
                    int ret = ImGuiExtraNative.ImGuiExtra_Curve(native_label, size, maxpoints, native_points, native_selection, rangeMin, rangeMax);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    return ret;
                }
            }
        }
        public static float CurveValue(float p, int maxpoints, ref Vector2 points)
        {
            fixed (Vector2* native_points = &points)
            {
                float ret = ImGuiExtraNative.ImGuiExtra_CurveValue(p, maxpoints, native_points);
                return ret;
            }
        }
        public static float CurveValueSmooth(float p, int maxpoints, ref Vector2 points)
        {
            fixed (Vector2* native_points = &points)
            {
                float ret = ImGuiExtraNative.ImGuiExtra_CurveValueSmooth(p, maxpoints, native_points);
                return ret;
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void SanityCheck(ReadOnlySpan<char> text)
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            ImGuiExtraNative.ImGuiExtra_SanityCheck(native_text);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
        }
#endif
        public static void SanityCheck(string text)
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            ImGuiExtraNative.ImGuiExtra_SanityCheck(native_text);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
        }
    }
}
