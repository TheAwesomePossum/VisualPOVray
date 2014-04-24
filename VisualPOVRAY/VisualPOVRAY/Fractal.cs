using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Fractal : PovTexture
    {
        //This is just a test class. It does render, it's just really hard to figure out what does what in here to provide customization.
        public override List<string> render()
        {
            List<String> s = new List<string>();
            s.Add("    pigment {");
            s.Add("    julia <0.353, 0.288>, 30");
            s.Add("    exterior 5, 1");
            s.Add("    color_map {");
            s.Add("    [0 rgb 0]");
            s.Add("    [0.2 rgb x]");
            s.Add("    [0.4 rgb x+y]");
            s.Add("    [1 rgb 1]");
            s.Add("    [1 rgb 0]");
            s.Add("    }");
            s.Add("    }");
            return s;
        }
    }
}
