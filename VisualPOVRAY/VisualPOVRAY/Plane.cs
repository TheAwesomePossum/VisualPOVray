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
        public Signal<float> d;
        public Point3 trans;
        public Point3 rot;
        public PovTexture tex;
        bool reactive;

        public Plane(Point3 normal = null, float disp = -1.0f, Signal<float> dispr = null, Point3 translate = null, Point3 rotation = null, PovTexture texture = null, bool reactive = false)
        {
            this.n = normal ?? new Point3(0, 1, 0, reactive: reactive);
            this.d = dispr ?? new Lift0f(disp);
            this.trans = translate ?? new Point3(0, 0, 0, reactive: reactive);
            this.rot = rotation ?? new Point3(0, 0, 0, reactive: reactive);
            this.tex = texture ?? new POVColor("Red");
            this.reactive = reactive;
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

        public void update(float time)
        {
            if (reactive)
            {
                this.d.now(time);
                this.n.update(time);
                this.trans.update(time);
                this.rot.update(time);
            }
        }
    }
}
