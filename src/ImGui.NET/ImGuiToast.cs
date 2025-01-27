using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using ImGuiNET;

namespace ImGuiNotifyNET
{
    public class ImGuiToast : IDisposable
    {
        public IntPtr NativePtr;

        public string ButtonLabel
        {
            get
            {
                unsafe
                {
                    var b = ImGuiToast_getButtonLabel(NativePtr);
                    return Marshal.PtrToStringAnsi((IntPtr)b);
                }
            }
            set
            {
                unsafe
                {
                    byte* native_value;
                    int value_byteCount = 0;

                    if (value != null)
                    {
                        value_byteCount = Encoding.UTF8.GetByteCount(value);
                        if (value_byteCount > Util.StackAllocationSizeLimit)
                        {
                            native_value = Util.Allocate(value_byteCount + 1);
                        }
                        else
                        {
                            byte* native_str_id_stackBytes = stackalloc byte[value_byteCount + 1];
                            native_value = native_str_id_stackBytes;
                        }

                        int native_str_id_offset = Util.GetUtf8(value, native_value, value_byteCount);
                        native_value[native_str_id_offset] = 0;
                    }
                    else
                    {
                        native_value = null;
                    }

                    ImGuiToast_setButtonLabel(NativePtr, native_value);

                    if (value_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_value);
                    }
                }
            }
        }

        public string Title
        {
            get
            {
                unsafe
                {
                    var b = ImGuiToast_setTitle(NativePtr);
                    return Marshal.PtrToStringAnsi((IntPtr)b);
                }
            }

            set
            {
                unsafe
                {
                    byte* native_value;
                    int value_byteCount = 0;

                    if (value != null)
                    {
                        value_byteCount = Encoding.UTF8.GetByteCount(value);
                        if (value_byteCount > Util.StackAllocationSizeLimit)
                        {
                            native_value = Util.Allocate(value_byteCount + 1);
                        }
                        else
                        {
                            byte* native_str_id_stackBytes = stackalloc byte[value_byteCount + 1];
                            native_value = native_str_id_stackBytes;
                        }

                        int native_str_id_offset = Util.GetUtf8(value, native_value, value_byteCount);
                        native_value[native_str_id_offset] = 0;
                    }
                    else
                    {
                        native_value = null;
                    }

                    ImGuiToast_setTitle(NativePtr, native_value);

                    if (value_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_value);
                    }
                }
            }
        }

        public string Content
        {
            get
            {
                unsafe
                {
                    var b = ImGuiToast_getContent(NativePtr);
                    return Marshal.PtrToStringAnsi((IntPtr)b);
                }
            }

            set
            {
                unsafe
                {
                    byte* native_value;
                    int value_byteCount = 0;

                    if (value != null)
                    {
                        value_byteCount = Encoding.UTF8.GetByteCount(value);
                        if (value_byteCount > Util.StackAllocationSizeLimit)
                        {
                            native_value = Util.Allocate(value_byteCount + 1);
                        }
                        else
                        {
                            byte* native_str_id_stackBytes = stackalloc byte[value_byteCount + 1];
                            native_value = native_str_id_stackBytes;
                        }

                        int native_str_id_offset = Util.GetUtf8(value, native_value, value_byteCount);
                        native_value[native_str_id_offset] = 0;
                    }
                    else
                    {
                        native_value = null;
                    }

                    ImGuiToast_setContent(NativePtr, native_value);

                    if (value_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_value);
                    }
                }
            }
        }

        public string DefaultTitle
        {
            get
            {
                unsafe
                {
                    var b = ImGuiToast_getDefaultTitle();
                    return Marshal.PtrToStringAnsi((IntPtr)b);
                }
            }
        }

        public ImGuiToastType Type => ImGuiToast_getType(NativePtr);

        public Vector4 Color
        {
            get => ImGuiToast_getColor(NativePtr);
            set => ImGuiToast_setColor(NativePtr, value);
        }

        public string Icon
        {
            get
            {
                unsafe
                {
                    var b = ImGuiToast_getIcon(NativePtr);
                    return Marshal.PtrToStringAnsi((IntPtr)b);
                }
            }

            set
            {
                unsafe
                {
                    byte* native_value;
                    int value_byteCount = 0;

                    if (value != null)
                    {
                        value_byteCount = Encoding.UTF8.GetByteCount(value);
                        if (value_byteCount > Util.StackAllocationSizeLimit)
                        {
                            native_value = Util.Allocate(value_byteCount + 1);
                        }
                        else
                        {
                            byte* native_str_id_stackBytes = stackalloc byte[value_byteCount + 1];
                            native_value = native_str_id_stackBytes;
                        }

                        int native_str_id_offset = Util.GetUtf8(value, native_value, value_byteCount);
                        native_value[native_str_id_offset] = 0;
                    }
                    else
                    {
                        native_value = null;
                    }

                    ImGuiToast_setIcon(NativePtr, native_value);

                    if (value_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_value);
                    }
                }
            }
        }

        public long ElapsedTime => ImGuiToast_getElapsedTime(NativePtr);

        public ImGuiToastPhase Phase => ImGuiToast_getPhase(NativePtr);

        public float FadePercent => ImGuiToast_getFadePercent(NativePtr);

        ImGuiWindowFlags ImGuiToastFlags
        {
            get => ImGuiToast_setImGuiToastFlags(NativePtr);
            set => ImGuiToast_setImGuiToastFlags(NativePtr, value);
        }

        ButtonPressDelegate OnButtonPress
        {
            get
            {
                unsafe
                {
                    var b = ImGuiToast_getOnButtonPress(NativePtr);
                    return Marshal.GetDelegateForFunctionPointer<ButtonPressDelegate>(b);
                }
            }
            set
            {
                unsafe
                {
                    IntPtr native_value = Marshal.GetFunctionPointerForDelegate(value);
                    ImGuiToast_setOnButtonPress(NativePtr, native_value);
                }
            }
        }

        public ImGuiToast(ImGuiToastType type, int dismissTime, string title, string content,
            ButtonPressDelegate onButtonPress, string buttonLabel, Vector4 color,
            string icon, ImGuiWindowFlags flags)
        {
            unsafe
            {
                var buttonPressDelegatePtr = onButtonPress != null
                    ? Marshal.GetFunctionPointerForDelegate(onButtonPress)
                    : IntPtr.Zero;

                var title_byteCount = Encoding.UTF8.GetByteCount(title);
                byte* native_title;
                if (title_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_title = Util.Allocate(title_byteCount + 1);
                }
                else
                {
                    byte* native_title_stackBytes = stackalloc byte[title_byteCount + 1];
                    native_title = native_title_stackBytes;
                }

                var title_offset = Util.GetUtf8(title, native_title, title_byteCount);
                native_title[title_offset] = 0;

                var content_byteCount = Encoding.UTF8.GetByteCount(content);
                byte* native_content;
                if (content_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_content = Util.Allocate(content_byteCount + 1);
                }
                else
                {
                    byte* native_content_stackBytes = stackalloc byte[content_byteCount + 1];
                    native_content = native_content_stackBytes;
                }

                var content_offset = Util.GetUtf8(content, native_content, content_byteCount);
                native_content[content_offset] = 0;

                var icon_byteCount = Encoding.UTF8.GetByteCount(icon);
                byte* native_icon;

                if (icon_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_icon = Util.Allocate(icon_byteCount + 1);
                }
                else
                {
                    byte* native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
                    native_icon = native_icon_stackBytes;
                }

                var icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
                native_icon[icon_offset] = 0;

                var buttonLabel_byteCount = Encoding.UTF8.GetByteCount(buttonLabel);
                byte* native_buttonLabel;

                if (buttonLabel_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_buttonLabel = Util.Allocate(buttonLabel_byteCount + 1);
                }
                else
                {
                    byte* native_buttonLabel_stackBytes = stackalloc byte[buttonLabel_byteCount + 1];
                    native_buttonLabel = native_buttonLabel_stackBytes;
                }

                var buttonLabel_offset = Util.GetUtf8(buttonLabel, native_buttonLabel, buttonLabel_byteCount);
                native_buttonLabel[buttonLabel_offset] = 0;

                NativePtr = ImGuiToast_Create(type, dismissTime, native_buttonLabel, buttonPressDelegatePtr,
                    native_title);
                ImGuiToastFlags = flags;
                Color = color;
                Icon = icon;
            }
        }

        public ImGuiToast(ImGuiToastType type, int dismissTime, string title, string content,
            ButtonPressDelegate onButtonPress, string buttonLabel, Vector4 color,
            string icon)
            : this(type, dismissTime, title, content, onButtonPress, buttonLabel, color, icon, ImGuiWindowFlags.None)
        {
        }

        public ImGuiToast(ImGuiToastType type, int dismissTime, string title, string content,
            ButtonPressDelegate onButtonPress, string buttonLabel, Vector4 color)
            : this(type, dismissTime, title, content, onButtonPress, buttonLabel, color, "", ImGuiWindowFlags.None)
        {
        }

        public ImGuiToast(ImGuiToastType type, int dismissTime, string title, string content,
            ButtonPressDelegate onButtonPress, string buttonLabel)
            : this(type, dismissTime, title, content, onButtonPress, buttonLabel,
                new Vector4(0.10f, 0.10f, 0.10f, 1.00f), "", ImGuiWindowFlags.None)
        {
        }

        public ImGuiToast(ImGuiToastType type, int dismissTime, string title, string content,
            ButtonPressDelegate onButtonPress)
            : this(type, dismissTime, title, content, onButtonPress, "X", new Vector4(0.10f, 0.10f, 0.10f, 1.00f), "",
                ImGuiWindowFlags.None)
        {
        }

        public ImGuiToast(ImGuiToastType type, int dismissTime, string title, string content)
            : this(type, dismissTime, title, content, null, "X", new Vector4(0.10f, 0.10f, 0.10f, 1.00f), "",
                ImGuiWindowFlags.None)
        {
        }

        public ImGuiToast(ImGuiToastType type, int dismissTime)
            : this(type, dismissTime, "Notification", "X", null, "", new Vector4(0.10f, 0.10f, 0.10f, 1.00f), "",
                ImGuiWindowFlags.None)
        {
        }

        public ImGuiToast(ImGuiToastType type)
            : this(type, 3, "Notification", "X", null, "", new Vector4(0.10f, 0.10f, 0.10f, 1.00f), "",
                ImGuiWindowFlags.None)
        {
        }

        public ImGuiToast() : this(ImGuiToastType.Info, 3, "Notification", "X", null, "",
            new Vector4(0.10f, 0.10f, 0.10f, 1.00f), "", ImGuiWindowFlags.None)
        {
        }

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe IntPtr ImGuiToast_Create(ImGuiToastType type, int dismissTime, byte* buttonLabel,
            IntPtr onButtonPress, byte* format);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern void ImGuiToast_Destroy(IntPtr nativePtr);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe byte* ImGuiToast_setTitle(IntPtr nativePtr);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe void ImGuiToast_setTitle(IntPtr nativePtr, byte* format);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe byte* ImGuiToast_getContent(IntPtr nativePtr);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe void ImGuiToast_setContent(IntPtr nativePtr, byte* format);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe byte* ImGuiToast_getDefaultTitle();

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern ImGuiToastType ImGuiToast_getType(IntPtr nativePtr);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern Vector4 ImGuiToast_getColor(IntPtr nativePtr);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern void ImGuiToast_setColor(IntPtr nativePtr, Vector4 value);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe byte* ImGuiToast_getIcon(IntPtr nativePtr);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe void ImGuiToast_setIcon(IntPtr nativePtr, byte* format);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern long ImGuiToast_getElapsedTime(IntPtr nativePtr);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern ImGuiToastPhase ImGuiToast_getPhase(IntPtr nativePtr);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern float ImGuiToast_getFadePercent(IntPtr nativePtr);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern ImGuiWindowFlags ImGuiToast_setImGuiToastFlags(IntPtr nativePtr);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern void ImGuiToast_setImGuiToastFlags(IntPtr nativePtr, ImGuiWindowFlags value);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr ImGuiToast_getOnButtonPress(IntPtr nativePtr);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern void ImGuiToast_setOnButtonPress(IntPtr nativePtr, IntPtr value);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe byte* ImGuiToast_getButtonLabel(IntPtr nativePtr);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe void ImGuiToast_setButtonLabel(IntPtr nativePtr, byte* format);

        private void ReleaseUnmanagedResources()
        {
            if (NativePtr == IntPtr.Zero) return;
            ImGuiToast_Destroy(NativePtr);
            NativePtr = IntPtr.Zero;
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        ~ImGuiToast()
        {
            ReleaseUnmanagedResources();
        }
    }
}
