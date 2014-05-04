using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Sphere : PovObj
    {
        public Point3 location;
        Signal<float> radius;
        public Point3 translate;
        public Point3 rotation;
        PovTexture texture;
        bool reactive;
        String finish;

        public Sphere(Point3 location = null, float radius = 1.0f, Signal<float> rrad = null, Point3 translate = null, Point3 rotation = null, PovTexture texture = null, String finish = null, bool reactive = false)
        {
            this.reactive = reactive;
            this.location = location ?? new Point3(0, 0, 0, reactive: reactive);
            this.translate = translate ?? new Point3(0, 0, 0, reactive: reactive);
            this.rotation = rotation ?? new Point3(0, 0, 0, reactive: reactive);
            this.texture = texture ?? new POVColor("Red");
            this.finish = finish ?? "finish {phong .9 reflection .5}";
            this.radius = rrad ?? new Lift0f(radius);
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("sphere {");
            l.Add("    " + this.location.render()[0] + ", " + this.radius);
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
                this.location.update(time);
                this.translate.update(time);
                this.rotation.update(time);
                this.radius.now(time);
            }

        }
    }
}
