using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class POVColor : PovTexture
    {

        private String name;

        public POVColor(String name)
        {
            this.name = name;
        }

        public void setColor(String name)
        {
            this.name = name;
        }

        public override List<String> render()
        {
            List<String> s = base.render();
            s.Add("        pigment { " + name + " }");
            s.Add("    }");
            return s;
        }
    }
}
