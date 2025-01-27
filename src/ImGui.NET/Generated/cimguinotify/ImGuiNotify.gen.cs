using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using ImGuiNET;

namespace ImGuiNotifyNET
{
    public static unsafe partial class ImGuiNotify
    {
        public static void InsertNotification(IntPtr toast)
        {
            ImGuiNotifyNative.igInsertNotification_Toast(toast);
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void InsertNotification(ImGuiToastType type, int dismissTime, ReadOnlySpan<char> title, ReadOnlySpan<char> buttonLabel, IntPtr onButtonPress, ReadOnlySpan<char> fmt)
        {
            byte* native_title;
            int title_byteCount = 0;
            if (title != null)
            {
                title_byteCount = Encoding.UTF8.GetByteCount(title);
                if (title_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_title = Util.Allocate(title_byteCount + 1);
                }
                else
                {
                    byte* native_title_stackBytes = stackalloc byte[title_byteCount + 1];
                    native_title = native_title_stackBytes;
                }
                int native_title_offset = Util.GetUtf8(title, native_title, title_byteCount);
                native_title[native_title_offset] = 0;
            }
            else { native_title = null; }
            byte* native_buttonLabel;
            int buttonLabel_byteCount = 0;
            if (buttonLabel != null)
            {
                buttonLabel_byteCount = Encoding.UTF8.GetByteCount(buttonLabel);
                if (buttonLabel_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_buttonLabel = Util.Allocate(buttonLabel_byteCount + 1);
                }
                else
                {
                    byte* native_buttonLabel_stackBytes = stackalloc byte[buttonLabel_byteCount + 1];
                    native_buttonLabel = native_buttonLabel_stackBytes;
                }
                int native_buttonLabel_offset = Util.GetUtf8(buttonLabel, native_buttonLabel, buttonLabel_byteCount);
                native_buttonLabel[native_buttonLabel_offset] = 0;
            }
            else { native_buttonLabel = null; }
            void* native_onButtonPress = (void*)onButtonPress.ToPointer();
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNotifyNative.igInsertNotification_ToastType(type, dismissTime, native_title, native_buttonLabel, native_onButtonPress, native_fmt);
            if (title_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title);
            }
            if (buttonLabel_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_buttonLabel);
            }
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
#endif
        public static void InsertNotification(ImGuiToastType type, int dismissTime, string title, string buttonLabel, IntPtr onButtonPress, string fmt)
        {
            byte* native_title;
            int title_byteCount = 0;
            if (title != null)
            {
                title_byteCount = Encoding.UTF8.GetByteCount(title);
                if (title_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_title = Util.Allocate(title_byteCount + 1);
                }
                else
                {
                    byte* native_title_stackBytes = stackalloc byte[title_byteCount + 1];
                    native_title = native_title_stackBytes;
                }
                int native_title_offset = Util.GetUtf8(title, native_title, title_byteCount);
                native_title[native_title_offset] = 0;
            }
            else { native_title = null; }
            byte* native_buttonLabel;
            int buttonLabel_byteCount = 0;
            if (buttonLabel != null)
            {
                buttonLabel_byteCount = Encoding.UTF8.GetByteCount(buttonLabel);
                if (buttonLabel_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_buttonLabel = Util.Allocate(buttonLabel_byteCount + 1);
                }
                else
                {
                    byte* native_buttonLabel_stackBytes = stackalloc byte[buttonLabel_byteCount + 1];
                    native_buttonLabel = native_buttonLabel_stackBytes;
                }
                int native_buttonLabel_offset = Util.GetUtf8(buttonLabel, native_buttonLabel, buttonLabel_byteCount);
                native_buttonLabel[native_buttonLabel_offset] = 0;
            }
            else { native_buttonLabel = null; }
            void* native_onButtonPress = (void*)onButtonPress.ToPointer();
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNotifyNative.igInsertNotification_ToastType(type, dismissTime, native_title, native_buttonLabel, native_onButtonPress, native_fmt);
            if (title_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title);
            }
            if (buttonLabel_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_buttonLabel);
            }
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
        public static void RemoveNotification(int index)
        {
            ImGuiNotifyNative.igRemoveNotification(index);
        }
        public static void RenderNotifications()
        {
            ImGuiNotifyNative.igRenderNotifications();
        }
    }
}
