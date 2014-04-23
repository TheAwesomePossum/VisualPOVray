using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Plane : PovObj
    {
        public Point3 n;
        public float d;
        public Point3 trans;
        public Point3 rot;
        public PovTexture tex;

        public Plane(Point3 normal = null, float disp = -1.0f,Point3 translate = null, Point3 rotation = null, PovTexture texture = null)
        {
            this.n = normal ?? new Point3(0, 1, 0);
            this.d = disp;
            this.trans = translate ?? new Point3(0, 0, 0);
            this.rot = rotation ?? new Point3(0, 0, 0);
            this.tex = texture ?? new POVColor("Red");
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("plane {");
            l.Add("    " + this.n.render()[0] + ", " + d);
            l.AddRange(this.tex.render());
            l.Add("    rotate " + this.rot.render()[0]);
            l.Add("    translate " + this.trans.render()[0]);
            l.Add("}");
            return l;
        }

        public void move(Point3 transform)
        {
            this.trans = transform;
        }

    }
}
