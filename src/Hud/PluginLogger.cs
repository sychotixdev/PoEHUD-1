using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeHUD.DebugPlug;
using SharpDX;

namespace PoeHUD.Hud
{
    class PluginLogger
    {
        #region Logging

        public static void LogError(string message, float displayTime)
        {
            LogError((object)message, displayTime);
        }

        public static void LogMessage(string message, float displayTime)
        {
            LogMessage((object)message, displayTime);
        }

        public static void LogError(object message, float displayTime)
        {
            if (message == null)
                LogMessage("null", displayTime, Color.Red);
            else
                LogMessage(message.ToString(), displayTime, Color.Red);
        }

        public static void LogMessage(object message, float displayTime)
        {
            if (message == null)
                LogMessage("null", displayTime, Color.White);
            else
                LogMessage(message.ToString(), displayTime, Color.White);
        }

        public static void LogWarning(object message, float displayTime)
        {
            if (message == null)
                LogMessage("null", displayTime, Color.Yellow);
            else
                LogMessage(message.ToString(), displayTime, Color.Yellow);
        }

        public static void LogMessage(object message, float displayTime, Color color)
        {
            if (message == null)
                DebugPlugin.LogMsg("null", displayTime, color);
            else
                DebugPlugin.LogMsg(message.ToString(), displayTime, color);
        }

        #endregion
    }
}
