using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class MarbleTexture : PovTexture
    {
        Signal<float> scale, turbulence;
        String color1, color2;
        bool reactive;

        public MarbleTexture(String color1, String color2, float turbulence = .7f, Signal<float> rturbulence = null, float scale = .7f, Signal<float> rscale = null, bool reactive = false)
        {
            this.scale = rscale ?? new Lift0f(scale);
            this.turbulence = rturbulence ?? new Lift0f(turbulence); 
            this.color1 = color1;
            this.color2 = color2;
            this.reactive = reactive; 

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

        public override void update(float time)
        {
            if (reactive)
            {
                this.scale.now(time);
                this.turbulence.now(time);
            }
        }
    }
}
