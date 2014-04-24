using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Brick : PovTexture
    {
        //Give this two colors and it will provide a brick pattern. The first color is the color of the "mortar" and the other is the "brick".
        String color1, color2;
        public Brick(String color1, String color2)
        {
            this.color1 = color1;
            this.color2 = color2;
        }

        public override List<string> render()
        {
            List<String> s = new List<string>();
            s.Add("    pigment {");
            s.Add("    brick");
            s.Add("    pigment{"+color1+"}");
            s.Add("    pigment{"+color2+"}");
            s.Add("    brick_size 1");
            s.Add("    mortar .2");
            s.Add("    }");
            return s;
        }
    }
}
