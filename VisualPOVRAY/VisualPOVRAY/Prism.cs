using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Prism : PovObj
    {
        public Point3 loc;
        PovTexture texture;
        String spline_type;
        public String points = " ";
        public Signal<float> numPoints;
        public Point2[] p;
        Signal<float> height1, height2;
        public bool reactive;

        public Prism(String spline_type, float height1, float height2, int numPoints, Point2[] p, Point3 loc = null,
                        bool reactive = false, Signal<float> rh1 = null, Signal<float> rh2 = null, Signal<float> nps = null)
        {
            this.reactive = reactive;
            this.spline_type = spline_type;
            this.numPoints = nps ?? new Lift0f(numPoints);
            this.loc = loc ?? new Point3(0, 0, 0, reactive: reactive);
            this.p = p;
            this.height1 = rh1 ?? new Lift0f(height1);
            this.height2 = rh2 ?? new Lift0f(height2);
            this.texture = new POVColor("Green");
            //ints = this.height1+", "+this.height2+", " + this.numPoints;
            for (int i = 0; i < p.Length - 1; i++)
            {
                points += "< " + p[i].x + ", " + p[i].y + "> , ";
            }
            points += "< " + p[p.Length - 1].x + ", " + p[p.Length - 1].y + ">";
        }

        public void move(Point3 loc)
        {
            this.loc = loc;
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("prism {");
            l.Add(spline_type);
            l.Add(this.height1 + ", " + this.height2 + ", " + this.numPoints);
            l.Add(points);
            l.Add("   translate" + this.loc.render()[0]);
            l.AddRange(this.texture.render());
            l.Add("}");
            return l;
        }


        public void update(float currentTime)
        {
            if (reactive)
            {
                this.loc.update(currentTime);
                this.numPoints.now(currentTime);
                this.height1.now(currentTime);
                this.height2.now(currentTime);
            }
        }
    }
}
