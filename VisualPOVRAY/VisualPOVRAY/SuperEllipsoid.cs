using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class SuperEllipsoid : PovObj
    {
        Signal<float> e,n;
        public Point3 loc;
        PovTexture tex;
        bool reactive;
        public Point3 trans;
        public Point3 rot;
        String finish;
        public SuperEllipsoid(Point3 location = null,float e =3f, float n = 2f, Signal<float> re = null,Signal<float> rn = null,
            Point3 translate = null, Point3 rotation = null, PovTexture texture = null, String finish = null, bool reactive = false)
        {
            this.reactive = reactive;
            this.loc = location ?? new Point3(0, 0, 0, reactive: reactive);
            this.trans = translate ?? new Point3(0, 0, 0, reactive: reactive);
            this.rot = rotation ?? new Point3(0, 0, 0, reactive: reactive);
            this.finish = finish ?? "finish {phong .9 reflection .5}";
            this.e = re ?? new Lift0f(e);
            this.n = rn ?? new Lift0f(n);
            this.tex = texture ?? new POVColor("Red");
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
                this.e.now(currentTime);
                this.n.now(currentTime);
            }

        }
    }
}
