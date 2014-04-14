using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVray
{
    class Sphere : PovObj
    {
        public Point3 loc;
        float radius;
        string color;

        public Sphere(Point3 loc, float radius)
        {
            this.loc = loc;
            this.radius = radius;
            this.color = "Red";
        }

        public Sphere(Point3 loc, float radius, string color)
        {
            this.loc = loc;
            this.radius = radius;
            this.color = color;
        }

        public void move(Point3 loc)
        {
            this.loc = loc;
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("sphere {");
            l.Add("    " + this.loc.render()[0] + ", " + this.radius);
            l.Add("    texture {");
            l.Add("        pigment { color " + this.color + " }");
            l.Add("    }");
            l.Add("}");
            return l;
        }
    }
}
