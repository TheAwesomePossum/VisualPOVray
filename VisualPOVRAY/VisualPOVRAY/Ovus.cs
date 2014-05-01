using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Ovus : PovObj
    {
        public Point3 loc;
        Signal<float> topRadius, bottomRadius;
        public Point3 trans;
        public Point3 rot;
        PovTexture tex;
        bool reactive;
        String finish;
        public Ovus(Point3 location = null, float topRadius = 1.0f, float bottomRadius = 2f, Signal<float> rt = null,
            Signal<float> rb = null, Point3 translate = null, Point3 rotation = null, PovTexture texture = null, String finish = null,
            bool reactive = false)
        {
            this.reactive = reactive;
            this.loc = location ?? new Point3(0, 0, 0, reactive: reactive);
            this.trans = translate ?? new Point3(0, 0, 0, reactive: reactive);
            this.rot = rotation ?? new Point3(0, 0, 0, reactive: reactive);
            this.finish = finish ?? "finish {phong .9 reflection .5}";
            this.tex = texture ?? new POVColor("Red");
            this.topRadius = rt ?? new Lift0f(topRadius);
            this.bottomRadius = rb ?? new Lift0f(bottomRadius);

        }

        public void move(Point3 loc)
        {
            this.loc = loc;
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("ovus {");
            l.Add(this.topRadius + ", " + this.bottomRadius);
            l.Add("translate " + this.loc.render()[0]);
            l.AddRange(this.tex.render());
            l.Add(finish);
            l.Add("}");
            return l;
        }


        public void update(float currentTime)
        {
            if (reactive)
            {
                this.loc.update(currentTime);
                this.trans.update(currentTime);
                this.rot.update(currentTime);
                this.topRadius.now(currentTime);
                this.bottomRadius.now(currentTime);
            }
        }
    }
}
