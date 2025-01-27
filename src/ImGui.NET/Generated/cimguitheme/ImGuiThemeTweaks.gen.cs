using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImGuiThemeNET
{
    public unsafe partial struct ImGuiThemeTweaks
    {
        public float Rounding;
        public float RoundingScrollbarRatio;
        public float AlphaMultiplier;
        public float Hue;
        public float SaturationMultiplier;
        public float ValueMultiplierFront;
        public float ValueMultiplierBg;
        public float ValueMultiplierText;
        public float ValueMultiplierFrameBg;
    }
    public unsafe partial struct ImGuiThemeTweaksPtr
    {
        public ImGuiThemeTweaks* NativePtr { get; }
        public ImGuiThemeTweaksPtr(ImGuiThemeTweaks* nativePtr) => NativePtr = nativePtr;
        public ImGuiThemeTweaksPtr(IntPtr nativePtr) => NativePtr = (ImGuiThemeTweaks*)nativePtr;
        public static implicit operator ImGuiThemeTweaksPtr(ImGuiThemeTweaks* nativePtr) => new ImGuiThemeTweaksPtr(nativePtr);
        public static implicit operator ImGuiThemeTweaks* (ImGuiThemeTweaksPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiThemeTweaksPtr(IntPtr nativePtr) => new ImGuiThemeTweaksPtr(nativePtr);
        public ref float Rounding => ref Unsafe.AsRef<float>(&NativePtr->Rounding);
        public ref float RoundingScrollbarRatio => ref Unsafe.AsRef<float>(&NativePtr->RoundingScrollbarRatio);
        public ref float AlphaMultiplier => ref Unsafe.AsRef<float>(&NativePtr->AlphaMultiplier);
        public ref float Hue => ref Unsafe.AsRef<float>(&NativePtr->Hue);
        public ref float SaturationMultiplier => ref Unsafe.AsRef<float>(&NativePtr->SaturationMultiplier);
        public ref float ValueMultiplierFront => ref Unsafe.AsRef<float>(&NativePtr->ValueMultiplierFront);
        public ref float ValueMultiplierBg => ref Unsafe.AsRef<float>(&NativePtr->ValueMultiplierBg);
        public ref float ValueMultiplierText => ref Unsafe.AsRef<float>(&NativePtr->ValueMultiplierText);
        public ref float ValueMultiplierFrameBg => ref Unsafe.AsRef<float>(&NativePtr->ValueMultiplierFrameBg);
        public void Destroy()
        {
            ImGuiThemeNative.ImGuiThemeTweaks_destroy((ImGuiThemeTweaks*)(NativePtr));
        }
    }
}
