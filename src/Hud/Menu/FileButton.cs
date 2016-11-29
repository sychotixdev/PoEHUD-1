using PoeHUD.Hud.Settings;
using PoeHUD.Hud.UI;
using SharpDX;
using SharpDX.Direct3D9;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ColorGdi = System.Drawing.Color;
using System;

namespace PoeHUD.Hud.Menu
{
    public sealed class FileButton : MenuItem
    {
        private readonly FileNode path;
        private string PoeDirectory;

        public FileButton(FileNode path)
        {
            this.path = path;
            string documentsPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            PoeDirectory = Path.Combine(documentsPath, @"My Games\Path of Exile");
        }

        public override int DesiredWidth => 180;
        public override int DesiredHeight => 25;

        public override void Render(Graphics graphics, MenuSettings settings)
        {
            if (!IsVisible) { return; }
            string text = string.IsNullOrEmpty(path) ? "  Select file" : Path.GetFileName(path);
            float size = DesiredHeight - 2;
            graphics.DrawImage("menu-background.png", new RectangleF(Bounds.X, Bounds.Y, Bounds.Width, Bounds.Height), settings.BackgroundColor);

            //var textPosition = new Vector2(Bounds.X + Bounds.Width / 2 - size / 2, Bounds.Y + Bounds.Height / 2);//Fixed FileButton text offset to the left.
            var textPosition = new Vector2(Bounds.X + Bounds.Width, Bounds.Y + Bounds.Height / 2);

            graphics.DrawText(text, settings.MenuFontSize, textPosition, settings.MenuFontColor, FontDrawFlags.VerticalCenter | FontDrawFlags.Center);
            var rectangle = new RectangleF(Bounds.Left + 5, Bounds.Top + 3, size, size - 5);
            graphics.DrawImage(string.IsNullOrEmpty(path) ? "openFile.png" : "done.png", rectangle);
        }

        protected override void HandleEvent(MouseEventID id, Vector2 pos)
        {
            if (id == MouseEventID.LeftButtonDown)
            {
                Thread thread = new Thread(() =>
                {
                    var filedialog = new OpenFileDialog
                    {
                        Filter = "filter files (*.filter)|*.filter|All files (*.*)|*.*"
                    };
                    filedialog.InitialDirectory = PoeDirectory;
                    if (filedialog.ShowDialog() == DialogResult.OK)
                    {
                        path.Value = filedialog.FileName;
                    }
                });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }
    }
}