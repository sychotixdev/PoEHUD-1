using System;

namespace PoeHUD.Hud.Interfaces
{
    public interface IPlugin : IDisposable
    {
        void Render();
    }
}