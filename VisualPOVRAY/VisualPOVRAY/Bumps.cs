using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Bumps : PovTexture
    {
        //Gray with some black bumps/holes in it.
        public override List<string> render()
        {
            List<String> s = new List<string>();
            s.Add("    pigment {");
            s.Add("    bumps");
            s.Add("    noise_generator 1");
            s.Add("    }");
            return s;
        }
    }
}
