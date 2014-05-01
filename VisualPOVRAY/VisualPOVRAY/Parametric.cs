using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Parametric : PovObj
    {
        Signal<float> u1, u2, v1, v2;
        public Point3 loc;
        public Point3 trans;
        public Point3 rot;
        PovTexture tex;
        bool reactive; 
        String xFunc, yFunc, zFunc;
        public String bounds;
        String finish;
        public Parametric(String xFunc, String yFunc, String zFunc,
            Point3 location = null, float u1 = 0f, float u2 = 7f, float v1 = 0f, float v2 = 7f, Signal<float> ru1 = null,
            Signal<float> ru2 = null, Signal<float> rv1 = null, Signal<float> rv2 = null,String bounds = "{box {<-1,-1,-1>*2*pi,<1,8/3,1>*2*pi}}", 
            Point3 translate = null, Point3 rotation = null, PovTexture texture = null, String finish = null, bool reactive = false)
        {
            this.reactive = reactive;
            this.xFunc = xFunc;
            this.yFunc = yFunc;
            this.zFunc = zFunc;
            this.bounds = bounds;
            this.u1 = ru1 ?? new Lift0f(u1);
            this.u2 = ru2 ?? new Lift0f(u2);
            this.v1 = rv1 ?? new Lift0f(v1);
            this.v2 = rv2 ?? new Lift0f(v2);
            this.finish = finish ?? "finish {phong .9 reflection .5}";
            this.loc = location ?? new Point3(0, 0, 0, reactive: reactive);
            this.trans = translate ?? new Point3(0, 0, 0, reactive: reactive);
            this.rot = rotation ?? new Point3(0, 0, 0, reactive: reactive);
            this.tex = texture ?? new POVColor("Red");
            
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
            l.Add("<"+u1+","+v1+">");
            l.Add("<"+u2+","+v2+">");
            l.Add("precompute 20 x,y,z");
            l.Add("contained_by " + bounds);
            l.Add("translate" + this.loc.render()[0]);
            l.AddRange(this.tex.render());
            l.Add(finish);
            l.Add("}");
            return l;
        }


        public void update(float currentTime)
        {
            if (reactive)
            {
                this.loc.update(currentTime);
                this.trans.update(currentTime);
                this.rot.update(currentTime);
                this.u1.now(currentTime);
                this.u2.now(currentTime);
                this.v1.now(currentTime);
                this.v2.now(currentTime);
            }
        }
    }
}
