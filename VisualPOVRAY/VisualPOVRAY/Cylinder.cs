using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Cylinder : PovObj
    {
        public Point3 basepoint;
        public Point3 toppoint;
        public Signal<float> radius;
        public Point3 translate;
        public Point3 rotation;
        PovTexture texture;
        String finish;
        bool reactive;

        public Cylinder(Point3 basepoint = null, Point3 toppoint = null, float radius = 1.0f, Signal<float> radiusr = null, Point3 translate = null, Point3 rotation = null, PovTexture texture = null, String finish = null, bool reactive = false)
        {
            this.basepoint = basepoint ?? new Point3(0, 0, 0, reactive: reactive);
            this.toppoint = toppoint ?? new Point3(0, 0, 0, reactive: reactive);
            this.radius = radiusr ?? new Lift0f(radius);
            this.translate = translate ?? new Point3(0, 0, 0, reactive: reactive);
            this.rotation = rotation ?? new Point3(0, 0, 0, reactive: reactive);
            this.finish = finish ?? "finish {phong .9 reflection .5}";
            this.texture = texture ?? new POVColor("Red");
            this.reactive = reactive;
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("cylinder {");
            l.Add("    " + this.basepoint.render()[0] + ", " + this.toppoint.render()[0] + ", " + this.radius);
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
            this.basepoint.update(time);
            this.toppoint.update(time);
            this.radius.now(time);
            this.translate.update(time);
            this.rotation.update(time);
        }
    }
}
