using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Parametric : PovObj
    {
        public double e;
        double n;
        public Point3 loc;
        PovTexture texture;
        String xFunc, yFunc, zFunc;
        float u1, u2, v1, v2;
        //String bounds;
        public Parametric(String xFunc, String yFunc, String zFunc, float u1,
            float u2, float v1, float v2, Point3 loc)
        {
            this.xFunc = xFunc;
            this.yFunc = yFunc;
            this.zFunc = zFunc;
            this.u1 = u1;
            this.u2 = u2;
            this.v1 = v1;
            this.v2 = v2;
            this.loc = loc;
            this.texture = new POVColor("Green");
        }

        public Parametric(String xFunc, String yFunc, String zFunc, float u1,
            float u2, float v1, float v2, Point3 loc, PovTexture texture)
        {
            this.xFunc = xFunc;
            this.yFunc = yFunc;
            this.zFunc = zFunc;
            this.u1 = u1;
            this.u2 = u2;
            this.v1 = v1;
            this.v2 = v2;
            this.loc = loc;
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
            l.Add("parametric {");
            l.Add("function {" + this.xFunc + "} ");
            l.Add("function {" + this.yFunc + "} ");
            l.Add("function {" + this.zFunc + "} ");
            l.Add("<"+u1+","+u2+">");
            l.Add("<"+v1+","+v2+">");
            l.Add("precompute 10 x,y,z");
            l.Add("   translate" + this.loc.render()[0]);
            l.AddRange(this.texture.render());
            l.Add("}");
            return l;
        }
    }
}
