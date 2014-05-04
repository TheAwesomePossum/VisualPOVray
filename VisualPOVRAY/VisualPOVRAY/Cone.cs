using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Cone : PovObj
    {
        public Point3 bottompoint;
        public Signal<float> bottomradius;
        public Point3 toppoint;
        public Signal<float> topradius;
        public Point3 translate;
        public Point3 rotation;
        public PovTexture texture;
        bool reactive;
        String finish;

        public Cone(Point3 bottompoint = null, float bottomradius = 1.0f, Signal<float> bottomradiusr = null, Point3 toppoint = null, float topradius = 0.0f, Signal<float> topradiusr = null, Point3 translate = null, Point3 rotation = null, PovTexture texture = null ,String finish = null, bool reactive = false)
        {
            this.bottompoint = bottompoint ?? new Point3(0, 0, 0);
            this.bottomradius = bottomradiusr ?? new Lift0f(bottomradius);
            this.toppoint = toppoint ?? new Point3(0, 0, 0);
            this.topradius = topradiusr ?? new Lift0f(topradius);
            this.translate = translate ?? new Point3(0, 0, 0, reactive: reactive);
            this.rotation = rotation ?? new Point3(0, 0, 0, reactive: reactive);
            this.finish = finish ?? "finish {phong .9 reflection .5}";
            this.texture = texture ?? new POVColor("Red");
            this.reactive = reactive;
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("cone {");
            l.Add("    " + this.bottompoint.render()[0] + ", " + bottomradius);
            l.Add("    " + this.toppoint.render()[0] + ", " + topradius);
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
                this.bottompoint.update(time);
                this.bottomradius.now(time);
                this.toppoint.update(time);
                this.topradius.now(time);
                this.translate.update(time);
                this.rotation.update(time);
            }
        }
    }
}
