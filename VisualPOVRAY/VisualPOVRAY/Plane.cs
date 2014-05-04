using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Plane : PovObj
    {
        public Point3 normal;
        public Signal<float> disp;
        public Point3 translate;
        public Point3 rotation;
        public PovTexture texture;
        bool reactive;
        String finish;

        public Plane(Point3 normal = null, float disp = -1.0f, Signal<float> dispr = null, Point3 translate = null, Point3 rotation = null, PovTexture texture = null, String finish = null, bool reactive = false)
        {
            this.normal = normal ?? new Point3(0, 1, 0, reactive: reactive);
            this.disp = dispr ?? new Lift0f(disp);
            this.translate = translate ?? new Point3(0, 0, 0, reactive: reactive);
            this.rotation = rotation ?? new Point3(0, 0, 0, reactive: reactive);
            this.texture = texture ?? new POVColor("Red");
            this.finish = finish ?? "finish {phong .9 reflection .5}";
            this.reactive = reactive;
        }

        public Plane(Point3 vectorx = null, Point3 vectory = null, float disp = -1.0f, Signal<float> dispr = null, Point3 translate = null, Point3 rotation = null, PovTexture texture = null, bool reactive = false)
        {
            Point3 n = vectorx.crossproduct(vectory);
            this.normal = n ?? new Point3(0, 1, 0, reactive: reactive);
            this.normal.reactive = reactive;
            this.disp = dispr ?? new Lift0f(disp);
            this.translate = translate ?? new Point3(0, 0, 0, reactive: reactive);
            this.rotation = rotation ?? new Point3(0, 0, 0, reactive: reactive);
            this.texture = texture ?? new POVColor("Red");
            this.reactive = reactive;
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("plane {");
            l.Add("    " + this.normal.render()[0] + ", " + disp);
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
                this.disp.now(time);
                this.normal.update(time);
                this.translate.update(time);
                this.rotation.update(time);
            }
        }
    }
}
