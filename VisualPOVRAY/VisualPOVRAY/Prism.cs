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
        public int numPoints;
        public PointF [] p;
        float height1, height2;
       
        public Prism(String spline_type, float height1, float height2, int numPoints, PointF [] p, Point3 loc)
        {
            this.spline_type = spline_type;
            this.numPoints = numPoints;
            this.loc = loc;
            this.p = p;
            this.height1 = height1;
            this.height2 = height2;
            this.texture = new POVColor("Green");
            //ints = this.height1+", "+this.height2+", " + this.numPoints;
            for (int i = 0; i < p.Length -1; i++)
            {
                points += "< "+p[i].X+", "+p[i].Y+"> , ";
            }
            points += "< " + p[p.Length-1].X + ", " + p[p.Length-1].Y + ">";
        }

        public Prism(String spline_type, float height1, float height2, int numPoints, PointF[] p, Point3 loc, PovTexture texture)
        {
            this.spline_type = spline_type;
            this.numPoints = numPoints;
            this.loc = loc;
            this.p = p;
            this.height1 = height1;
            this.height2 = height2;
            this.texture = texture;
            this.loc = loc;
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
    }
}
