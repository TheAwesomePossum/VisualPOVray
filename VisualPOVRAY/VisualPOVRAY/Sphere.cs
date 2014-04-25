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
        Signal<float> rad;
        public Point3 trans;
        public Point3 rot;
        PovTexture tex;
        bool reactive;

        public Sphere(Point3 location = null, float radius = 1.0f, Signal<float> rrad = null, Point3 translate = null, Point3 rotation = null, PovTexture texture = null, bool reactive = false)
        {
            this.reactive = reactive;
            this.loc = location ?? new Point3(0, 0, 0, reactive: reactive);
            this.trans = translate ?? new Point3(0, 0, 0, reactive: reactive);
            this.rot = rotation ?? new Point3(0, 0, 0, reactive: reactive);
            this.tex = texture ?? new POVColor("Red");
            this.rad = rrad ?? new Lift0f(radius);
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("sphere {");
            l.Add("    " + this.loc.render()[0] + ", " + this.rad);
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
                this.loc.update(time);
                this.trans.update(time);
                this.rot.update(time);
                this.rad.now(time);
            }

        }
    }
}
