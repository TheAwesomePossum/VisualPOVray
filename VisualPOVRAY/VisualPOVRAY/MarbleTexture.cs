using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class MarbleTexture : PovTexture
    {
        double scale, turbulence;
        String color1, color2; 

        public MarbleTexture(double scale, double turbulence, String color1, String color2)
        {
            this.scale = scale;
            this.turbulence = turbulence;
            this.color1 = color1;
            this.color2 = color2; 

        }
        public override List<string> render()
        {
            List<String> s = base.render();
            s.Add(@"pigment{ marble scale " + scale + @" turbulence " + turbulence
  + @"color_map{ [0.0 color " + color1 + @"]
               [1.0 color " + color2 + @"]
             }
       }} //---- end of pigment ------");
            return s;
        }
    }
}
