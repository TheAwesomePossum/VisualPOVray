using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class BlueSkyTexture : PovTexture
    {
        double turbulence; 
        public BlueSkyTexture(double turbulence)
        {
            this.turbulence = turbulence; 
        }
        public override List<string> render()
        {
            List<String> s = base.render();
            s.Add(@"pigment{
           bozo turbulence " + turbulence
           + @" color_map {
             [0.0 color rgb <0.5, 0.5, 1.0>] //LightBlue
             [0.5 color rgb <0.5, 0.5, 1.0>] //LightBlue
             [0.6 color rgb <1.0, 1.0, 1.0>] //White
             [1.0 color rgb <0.5, 0.5, 0.5>] //Grey
                     } // end of color_map
               } // end of pigment
        finish { diffuse 0.9 phong 1}}");
            return s;
        }
    }
}
