using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class AnimatedPoint3 : PovObj
    {
        private String x, y, z;

        public AnimatedPoint3(String x, String y, String z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public List<string> render()
        {
            List<String> l = new List<String>();
            l.Add("<" + this.x + ", " + this.y + ", " + this.z + ">");
            return l;
        }

        public void move(Point3 p)
        {
            this.x = "" + p.x;
            this.y = "" + p.y;
            this.z = "" + p.z;
        }

        public void move(String x, String y, String z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }


        public void update(float time)
        {
            throw new NotImplementedException();
        }
    }
}
