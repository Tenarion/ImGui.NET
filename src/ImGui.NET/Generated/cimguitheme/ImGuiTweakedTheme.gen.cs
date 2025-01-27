using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImGuiThemeNET
{
    public unsafe partial struct ImGuiTweakedTheme
    {
        public ImGuiThemeType Theme;
        public ImGuiThemeTweaks Tweaks;
    }
    public unsafe partial struct ImGuiTweakedThemePtr
    {
        public ImGuiTweakedTheme* NativePtr { get; }
        public ImGuiTweakedThemePtr(ImGuiTweakedTheme* nativePtr) => NativePtr = nativePtr;
        public ImGuiTweakedThemePtr(IntPtr nativePtr) => NativePtr = (ImGuiTweakedTheme*)nativePtr;
        public static implicit operator ImGuiTweakedThemePtr(ImGuiTweakedTheme* nativePtr) => new ImGuiTweakedThemePtr(nativePtr);
        public static implicit operator ImGuiTweakedTheme* (ImGuiTweakedThemePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTweakedThemePtr(IntPtr nativePtr) => new ImGuiTweakedThemePtr(nativePtr);
        public ref ImGuiThemeType Theme => ref Unsafe.AsRef<ImGuiThemeType>(&NativePtr->Theme);
        public ref ImGuiThemeTweaks Tweaks => ref Unsafe.AsRef<ImGuiThemeTweaks>(&NativePtr->Tweaks);
        public void Destroy()
        {
            ImGuiThemeNative.ImGuiTweakedTheme_destroy((ImGuiTweakedTheme*)(NativePtr));
        }
    }
}
