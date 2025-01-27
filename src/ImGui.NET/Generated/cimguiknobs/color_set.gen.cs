using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImGuiKnobsNET
{
    public unsafe partial struct color_set
    {
        public ImColor @base;
        public ImColor hovered;
        public ImColor active;
    }
    public unsafe partial struct color_setPtr
    {
        public color_set* NativePtr { get; }
        public color_setPtr(color_set* nativePtr) => NativePtr = nativePtr;
        public color_setPtr(IntPtr nativePtr) => NativePtr = (color_set*)nativePtr;
        public static implicit operator color_setPtr(color_set* nativePtr) => new color_setPtr(nativePtr);
        public static implicit operator color_set* (color_setPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator color_setPtr(IntPtr nativePtr) => new color_setPtr(nativePtr);
        public ref ImColor @base => ref Unsafe.AsRef<ImColor>(&NativePtr->@base);
        public ref ImColor hovered => ref Unsafe.AsRef<ImColor>(&NativePtr->hovered);
        public ref ImColor active => ref Unsafe.AsRef<ImColor>(&NativePtr->active);
        public void Destroy()
        {
            ImGuiKnobsNative.color_set_destroy((color_set*)(NativePtr));
        }
    }
}
