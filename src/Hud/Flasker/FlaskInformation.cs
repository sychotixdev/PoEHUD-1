using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Hud.Flasker
{
    public class FlaskInformation
    {
        public Dictionary<string, FlaskActions> UniqueFlaskNames { get; set; }
        public Dictionary<string, FlaskActions> FlaskTypes { get; set; }
        public Dictionary<string, FlaskActions> FlaskMods { get; set; }
    }
}
