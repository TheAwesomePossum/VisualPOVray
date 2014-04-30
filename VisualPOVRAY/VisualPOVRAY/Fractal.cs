using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Fractal : PovTexture
    {
        String fractalType, orientation, exponent;
        public Fractal(String fractalType = "julia", String orientation = "interior", String exponent = "1")
        {
            this.fractalType = fractalType;
            this.orientation = orientation;
            this.exponent = exponent;
        }
        public override List<string> render()
        {
            List<String> s = new List<string>();
            s.Add("    pigment {");
            s.Add("    "+fractalType+" <0.353, 0.288>, 30");
            s.Add("    "+orientation+" "+exponent+", 1");
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