using SharpDX;
using System;
using System.Diagnostics;
using PoeHUD.Controllers;
using Point = System.Drawing.Point;
using Rectangle = System.Drawing.Rectangle;

namespace PoeHUD.Framework
{
    public class GameWindow
    {
        private readonly IntPtr handle;

        public GameWindow(Process process)
        {
            Process = process;
            handle = process.MainWindowHandle;
        }

        public Process Process { get; private set; }

        public RectangleF GetWindowRectangle()
        {
            return GetWindowRectangleReal();
        }
        public RectangleF GetWindowRectangleReal()
        {
            Rectangle rectangle = WinApi.GetClientRectangle(handle);
            return new RectangleF(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }

        public bool IsForeground()
        {
            return WinApi.IsForegroundWindow(handle);
        }

        public Vector2 ScreenToClient(int x, int y)
        {
            var point = new Point(x, y);
            WinApi.ScreenToClient(handle, ref point);
            return new Vector2(point.X, point.Y);
        }

        public Vector2 ClientToScreen(int x, int y)
        {
            var point = new Point(x, y);
            WinApi.ClientToScreen(handle, ref point);
            return new Vector2(point.X, point.Y);
        }
    }
}