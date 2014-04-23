using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class WaveTexture : PovTexture
    {
        double scale;
        String color1, color2;

        public WaveTexture(double scale, String color1, String color2)
        {
            this.scale = scale;
            this.color1 = color1;
            this.color2 = color2; 
        }


        public override List<string> render(){
            List<String> s = base.render();
            s.Add(@"pigment{ waves scale " + scale
         + @" color_map{[0.0 color " + color1 + @"]
                   [0.3 color " + color1 + @"]
                   [0.8 color " + color2 + @"]
                   [1.0 color " + color2 + @"]
                  }//end of color_map
        }}");
            return s;
        }

    }
}
