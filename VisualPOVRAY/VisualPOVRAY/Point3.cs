using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVray
{
    class Point3 : PovObj
    {
        public int x, y, z;

        public Point3(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("<" + this.x + ", " + this.y + ", " + this.z + ">");
            return l;
        }
    
        public void move(Point3 loc)
        {
            this.x = loc.x;
            this.y = loc.y;
            this.z = loc.z;
        }
}
}
