using System;
using System.Numerics;
using System.Runtime.InteropServices;
using ImGuiNET;

namespace ImGuiNotifyNET
{
    public static unsafe partial class ImGuiNotifyNative
    {
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igInsertNotification_Toast(IntPtr toast);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igInsertNotification_ToastType(ImGuiToastType type, int dismissTime, byte* title, byte* buttonLabel, void* onButtonPress, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRemoveNotification(int index);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderNotifications();
    }
}
