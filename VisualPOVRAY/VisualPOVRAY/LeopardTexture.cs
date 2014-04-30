using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class LeopardTexture : PovTexture
    {
        Signal<float> scale, turbulence;
        String color1, color2, color3;
        bool reactive; 
        //.3, .5
        public LeopardTexture(String color1, String color2, String color3, float scale = .3f, Signal<float> rscale = null, float turbulence = .5f, Signal<float> rturbulence = null, bool reactive = false){
            this.scale = rscale ?? new Lift0f(scale);
            this.turbulence = rturbulence ?? new Lift0f(turbulence);
            this.reactive = reactive; 
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

        public override void update(float time)
        {
            if (reactive)
            {
                this.scale.now(time);
                this.turbulence.now(time);
            }
        }

        //turn constants into lifted signals 

    }
}
