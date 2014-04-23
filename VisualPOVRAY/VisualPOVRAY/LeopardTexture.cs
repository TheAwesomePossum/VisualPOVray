using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class LeopardTexture : PovTexture
    {
        double scale, turbulence;
        String color1, color2, color3; 
        public LeopardTexture(double scale, double turbulence, String color1, String color2, String color3){
            this.scale = scale; 
            this.turbulence = turbulence;
            this.color1 = color1;
            this.color2 = color2;
            this.color3 = color3; 
        }
        public override List<string> render(){
            List<String> s = base.render();
            s.Add(@"pigment{ leopard scale " + scale + @"  turbulence " +  turbulence
            + @" color_map{[0.0 color " + color1 + @"]
                   [0.2 color " + color2 + @"]
                   [1.0 color " + color3 + @"]
                  }
        }} // end of pigment");
            return s;
        }

    }
}
