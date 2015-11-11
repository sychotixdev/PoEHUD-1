using System;

namespace PoeHUD.Framework
{
    public delegate IntPtr CCHookProc(IntPtr hWnd, UInt16 msg, Int32 wParam, Int32 lParam);

    public struct ChooseColor
    {
        public Int32 lStructSize;
        public IntPtr hwndOwner;
        public IntPtr hInstance;
        public Int32 rgbResult;
        public IntPtr lpCustColors;
        public Int32 Flags;
        public IntPtr lCustData;
        public CCHookProc lpfnHook;
        public IntPtr lpTemplateName;
    };
}