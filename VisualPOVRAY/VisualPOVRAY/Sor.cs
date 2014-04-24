using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Sor : PovObj
    {
        public Point3 loc;
        PovTexture texture;
        public String points = " ";
        public int numPoints;
        public PointF[] p;

        public Sor(int numPoints, PointF[] p, Point3 loc)
        {
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

        public Sor(String spline_type, float height1, float height2, int numPoints, PointF[] p, Point3 loc, PovTexture texture)
        {
            this.numPoints = numPoints;
            this.loc = loc;
            this.p = p;

            this.texture = new POVColor("Green");
            for (int i = 0; i < p.Length - 1; i++)
            {
                points += "< " + p[i].X + ", " + p[i].Y + "> , ";
            }
            points += "< " + p[p.Length - 1].X + ", " + p[p.Length - 1].Y + ">";
            this.texture = texture;
           
        }

        public void move(Point3 loc)
        {
            this.loc = loc;
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("sor {");
            l.Add(""+this.numPoints);
            l.Add(points);
            l.Add("   translate" + this.loc.render()[0]);
            l.AddRange(this.texture.render());
            l.Add("}");
            return l;
        }
    }
}
