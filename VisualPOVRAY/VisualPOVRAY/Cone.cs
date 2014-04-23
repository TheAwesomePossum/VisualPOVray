using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Cone : PovObj
    {
        public Point3 botp;
        public float botrad;
        public Point3 topp;
        public float toprad;
        public Point3 trans;
        public Point3 rot;
        public PovTexture tex;

        public Cone(Point3 bottompoint = null, float bottomradius = 1.0f, Point3 toppoint = null, float topradius = 0.0f, Point3 translate = null, Point3 rotation = null, PovTexture texture = null)
        {
            this.botp = bottompoint ?? new Point3(0, 0, 0);
            this.botrad = bottomradius;
            this.topp = toppoint ?? new Point3(0, 0, 0);
            this.toprad = topradius;
            this.trans = translate ?? new Point3(0, 0, 0);
            this.rot = rotation ?? new Point3(0, 0, 0);
            this.tex = texture ?? new POVColor("Red");
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("cone {");
            l.Add("    " + this.botp.render()[0] + ", " + botrad);
            l.Add("    " + this.topp.render()[0] + ", " + toprad);
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
