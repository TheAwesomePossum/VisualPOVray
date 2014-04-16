using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Sphere : PovObj
    {
        public Point3 loc;
        float radius;
        PovTexture texture;

        public Sphere(Point3 loc, float radius)
        {
            this.loc = loc;
            this.radius = radius;
            this.texture = new POVColor("Red");
        }

        public Sphere(Point3 loc, float radius, PovTexture texture)
        {
            this.loc = loc;
            this.radius = radius;
            this.texture = texture;
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
            l.AddRange(this.texture.render());
            l.Add("}");
            return l;
        }
    }
}
