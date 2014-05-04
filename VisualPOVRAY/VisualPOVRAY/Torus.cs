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
        public Point3 translate;
        public Point3 rotation;
        public PovTexture texture;
        bool reactive;
        String finish;

        public Torus(float outerrad = 1.0f, Signal<float> outerradr = null, float innerrad = 1.0f, Signal<float> innerradr = null, Point3 translate = null, Point3 rotation = null, PovTexture texture = null, String finish = null, bool reactive = false)
        {
            this.outerrad = outerradr ?? new Lift0f(outerrad);
            this.innerrad = innerradr ?? new Lift0f(innerrad);
            this.translate = translate ?? new Point3(0, 0, 0, reactive: reactive);
            this.rotation = rotation ?? new Point3(0, 0, 0, reactive: reactive);
            this.texture = texture ?? new POVColor("Red");
            this.finish = finish ?? "finish {phong .9 reflection .5}";
            this.reactive = reactive;
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("torus {");
            l.Add("    " + this.outerrad + ", " + this.innerrad );
            l.AddRange(this.texture.render());
            l.Add("    rotate " + this.rotation.render()[0]);
            l.Add("    translate " + this.translate.render()[0]);
            l.Add(finish);
            l.Add("}");
            return l;
        }

        public void move(Point3 transform)
        {
            this.translate = transform;
        }

        public void update(float time)
        {
            if (reactive)
            {
                this.outerrad.now(time);
                this.innerrad.now(time);
                this.translate.update(time);
                this.rotation.update(time);
            }
        }
    }
}
