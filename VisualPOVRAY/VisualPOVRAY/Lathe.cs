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
        public double e;
        double n;
        public Point3 loc;
        PovTexture texture;
        String spline_type;
        int numPoints;
        PointF [] p;
        String points = "";
        public Lathe(String spline_type, int numPoints, PointF [] p, Point3 loc)
        {
            this.spline_type = spline_type;
            this.numPoints = numPoints;
            this.loc = loc;
            this.p = p;
            this.texture = new POVColor("Green");
            for (int i = 0; i < p.Length - 1; i++)
            {
                points += "< " + p[i].X + ", " + p[i].Y + "> , ";
            }
            points += "< " + p[p.Length - 1].X + ", " + p[p.Length - 1].Y + ">";
        }

        public Lathe(String spline_type, int numPoints, PointF[] p, Point3 loc, PovTexture texture)
        {
            this.spline_type = spline_type;
            this.numPoints = numPoints;
            this.loc = loc;
            this.p = p;
            this.texture = texture;
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
            l.Add("   translate" + this.loc.render()[0]);
            l.AddRange(this.texture.render());
            l.Add("}");
            return l;
        }
    }
}
