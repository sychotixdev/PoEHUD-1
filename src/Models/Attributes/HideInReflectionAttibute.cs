using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Models.Attributes
{
    /// Used to hide some class members from preview in plugins like ImGUI Developer due to useless information
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Method)]
    public class HideInReflectionAttribute : Attribute
    {
    }
}
