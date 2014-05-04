using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Box : PovObj
    {
        public Point3 lowerleftcorner;
        public Point3 upperrightcorner;
        public Point3 translate;
        public Point3 rotation;
        public PovTexture texture;
        public bool reactive;
        String finish;

        public Box(Point3 lowerleftcorner = null, Point3 upperrightcorner = null, Point3 translate = null, Point3 rotation = null, PovTexture texture = null, String finish = null, bool reactive = false)
        {
            this.reactive = reactive;
            this.lowerleftcorner = lowerleftcorner ?? new Point3(0, 0, 0, reactive: reactive);
            this.upperrightcorner = upperrightcorner ?? new Point3(0, 0, 0, reactive: reactive);
            this.translate = translate ?? new Point3(0, 0, 0, reactive: reactive);
            this.rotation = rotation ?? new Point3(0, 0, 0, reactive: reactive);
            this.finish = finish ?? "finish {phong .9 reflection .5}";
            this.texture = texture ?? new POVColor("Red");
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("box {");
            l.Add("    " + this.lowerleftcorner.render()[0] + ", " + this.upperrightcorner.render()[0]);
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
                this.lowerleftcorner.update(time);
                this.translate.update(time);
                this.rotation.update(time);
                this.upperrightcorner.update(time);
            }
        }
    }
}
