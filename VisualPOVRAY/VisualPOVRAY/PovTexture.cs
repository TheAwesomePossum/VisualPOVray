using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
     abstract class PovTexture : PovObj
    {
        public virtual List<string> render()
        {
            List<String> s = new List<string>();
            s.Add("    texture {");
            return s;
        }
    }
}
