using System;
using System.Runtime.InteropServices;

namespace PoeHUD.Poe
{
    public interface Component
    {
        Entity Owner { get; }
    }
}