using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Torus : PovObj
    {
        public Signal<float> outerrad;
        public Signal<float> innerrad;
        public Point3 trans;
        public Point3 rot;
        public PovTexture tex;
        bool reactive;

        public Torus(float outerrad = 1.0f, Signal<float> outerradr = null, float innerrad = 1.0f, Signal<float> innerradr = null, Point3 translate = null, Point3 rotation = null, PovTexture texture = null, bool reactive = false)
        {
            this.outerrad = outerradr ?? new Lift0f(outerrad);
            this.innerrad = innerradr ?? new Lift0f(innerrad);
            this.trans = translate ?? new Point3(0, 0, 0, reactive: reactive);
            this.rot = rotation ?? new Point3(0, 0, 0, reactive: reactive);
            this.tex = texture ?? new POVColor("Red");
            this.reactive = reactive;
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
            if (reactive)
            {
                this.outerrad.now(time);
                this.innerrad.now(time);
                this.trans.update(time);
                this.rot.update(time);
            }
        }
    }
}
