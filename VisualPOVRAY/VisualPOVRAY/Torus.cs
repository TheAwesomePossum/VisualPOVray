using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Torus : PovObj
    {
        public float outerrad;
        public float innerrad;
        public Point3 trans;
        public Point3 rot;
        public PovTexture tex;

        public Torus(float outerrad = 1.0f, float innerrad = 0.5f, Point3 translate = null, Point3 rotation = null, PovTexture texture = null)
        {
            this.outerrad = outerrad;
            this.innerrad = innerrad;
            this.trans = translate ?? new Point3(0, 0, 0);
            this.rot = rotation ?? new Point3(0, 0, 0);
            this.tex = texture ?? new POVColor("Red");
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("torus {");
            l.Add("    " + this.outerrad + ", " + this.innerrad );
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



        public void update(float time)
        {
            throw new NotImplementedException();
        }
    }
}
