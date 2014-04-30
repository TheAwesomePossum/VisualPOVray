using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class ImageMap : PovTexture
    {
        String filePath;
        public ImageMap(String filePath)
        {
            this.filePath = filePath;
        }
        public override List<string> render()
        {
            List<String> s = new List<string>();
            s.Add("    pigment {");
            s.Add("    image_map");
            s.Add("    {");
            s.Add("    png \""+filePath+"\"");
            s.Add("    }");
            s.Add("    }");
            return s;
        }
    }
}
