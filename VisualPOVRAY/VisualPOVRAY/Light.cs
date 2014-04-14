using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVray
{
    class Light : PovObj
    {
        public Point3 loc;
        string color;

        public Light(Point3 loc)
        {
            this.loc = loc;
            this.color = "White";
        }

        public Light(Point3 loc, string color)
        {
            this.loc = loc;
            this.color = color;
        }

        public void move(Point3 loc)
        {
            this.loc = loc;
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("light_source { " + this.loc.render()[0] + " color " + this.color + " }");
            return l;
        }
    }
}
