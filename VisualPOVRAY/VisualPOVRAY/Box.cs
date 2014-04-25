using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Box : PovObj
    {
        public Point3 lowleft;
        public Point3 upright;
        public Point3 trans;
        public Point3 rot;
        public PovTexture tex;
        public bool reactive;

        public Box(Point3 lowerleftcorner = null, Point3 upperrightcorner = null, Point3 translate = null, Point3 rotation = null, PovTexture texture = null, bool reactive = false)
        {
            this.reactive = reactive;
            this.lowleft = lowerleftcorner ?? new Point3(0, 0, 0, reactive: reactive);
            this.upright = upperrightcorner ?? new Point3(0, 0, 0, reactive: reactive);
            this.trans = translate ?? new Point3(0, 0, 0, reactive: reactive);
            this.rot = rotation ?? new Point3(0, 0, 0, reactive: reactive);
            this.tex = texture ?? new POVColor("Red");
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("box {");
            l.Add("    " + this.lowleft.render()[0] + ", " + this.upright.render()[0]);
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
                this.lowleft.update(time);
                this.trans.update(time);
                this.rot.update(time);
                this.upright.update(time);
            }
        }
    }
}
