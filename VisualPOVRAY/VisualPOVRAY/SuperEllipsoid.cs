using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class SuperEllipsoid : PovObj
    {
        public double e;
        double n;
        public Point3 loc;
        PovTexture texture;

        public SuperEllipsoid(double e, double n, Point3 loc)
        {
            this.e = e;
            this.n = n;
            this.loc = loc;
            this.texture = new POVColor("Green");
        }

        public SuperEllipsoid(double e, double n, Point3 loc,PovTexture texture)
        {
            this.e = e;
            this.n = n;
            this.texture = texture;
            this.loc = loc;
        }

        public void move(Point3 loc)
        {
            this.loc = loc;
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("superellipsoid {");
            l.Add("<" + this.e + ", " + this.n + ">");
            l.Add("   translate" + this.loc.render()[0]);
            l.AddRange(this.texture.render());
            l.Add("}");
            return l;
        }
    }
}
