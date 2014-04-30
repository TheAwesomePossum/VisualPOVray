using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Lathe : PovObj
    {
        public Point3 loc, rot;
        PovTexture tex;
        String spline_type;
        int numPoints;
        PointF [] p;
        String points = "";
        bool reactive;
        public Lathe(String spline_type, int numPoints, PointF [] p,
            Point3 location = null, float radius = 1.0f, Signal<float> rrad = null,
            Point3 translate = null, Point3 rotation = null, PovTexture texture = null, bool reactive = false)
        {
            this.reactive = reactive;
            this.loc = location ?? new Point3(0, 0, 0, reactive: reactive);
            this.rot = rotation ?? new Point3(0, 0, 0, reactive: reactive);
            this.tex = texture ?? new POVColor("Green");
            this.spline_type = spline_type;
            this.numPoints = numPoints;
            this.p = p;
            
            for (int i = 0; i < p.Length - 1; i++)
            {
                points += "< " + p[i].X + ", " + p[i].Y + "> , ";
            }
            points += "< " + p[p.Length - 1].X + ", " + p[p.Length - 1].Y + ">";
        }

        public void move(Point3 loc)
        {
            this.loc = loc;
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("lathe {");
            l.Add(spline_type);
            l.Add(" "+this.numPoints);
            l.Add(points);
            l.Add("translate" + this.loc.render()[0]);
            l.AddRange(this.tex.render());
            l.Add("}");
            return l;
        }


        public void update(float currentTime)
        {
            this.loc.update(currentTime);
            this.rot.update(currentTime);
            //this.tex.update(currentTime);
        }
    }
}
