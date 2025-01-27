using System;
using System.Runtime.InteropServices;

namespace ImGuiNotifyNET
{
    public static unsafe partial class ImGuiNotify
    {
        public static void InsertNotification(ImGuiToast toast)
        {
            ImGuiNotifyNative.igInsertNotification_Toast(toast.NativePtr);
        }

        public static void InsertNotification(ImGuiToastType type, int dismissTime = 3000)
        {
            InsertNotification(type, dismissTime, "Notification", "X", IntPtr.Zero, "");
        }

        public static void InsertNotification(ImGuiToastType type, int dismissTime, string title, string content)
        {
            InsertNotification(type, dismissTime, title, "", IntPtr.Zero, content);
        }

        public static void InsertNotification(ImGuiToastType type, int dismissTime, string title, string content,
            ButtonPressDelegate buttonPressDelegate)
        {
            var buttonPressDelegatePtr = buttonPressDelegate != null
                ? Marshal.GetFunctionPointerForDelegate(buttonPressDelegate)
                : IntPtr.Zero;
            InsertNotification(type, dismissTime, title, "", buttonPressDelegatePtr, content);
        }

        public static void InsertNotification(ImGuiToastType type, int dismissTime, string title, string content,
            string buttonLabel, ButtonPressDelegate buttonPressDelegate)
        {
            var buttonPressDelegatePtr = buttonPressDelegate != null
                ? Marshal.GetFunctionPointerForDelegate(buttonPressDelegate)
                : IntPtr.Zero;
            InsertNotification(type, dismissTime, title, buttonLabel, buttonPressDelegatePtr, content);
        }
    }
}
