using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Agate : PovTexture
    {
        //This is just a simple built in texture that looks like sand. No customization needed.
        public override List<string> render()
        {
            List<String> s = new List<string>();
            s.Add("    pigment {");
            s.Add("    agate");
            s.Add("    agate_turb 0.5");
            s.Add("    }");
            return s;
        }
    }
}
