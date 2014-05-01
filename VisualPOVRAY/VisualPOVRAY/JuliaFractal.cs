using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class JuliaFractal : PovObj
    {
        public Point3 loc;
        Signal<float> x, y, z, k;
        public Point3 rot;
        PovTexture tex;
        String algebra, function;
        int precision, iterations;
        bool reactive;
        String finish;
        public JuliaFractal(String algebra, String function, int precision, int iterations,
            Point3 location = null, float x = -0.162f, float y = 0.163f, float z = 0.560f, float k = -0.599f, 
            Signal<float> rx = null, Signal<float> ry = null, Signal<float> rz = null, Signal<float> rk = null,
            Point3 rotation = null, PovTexture texture = null, String finish = null, bool reactive = false)
        {
            this.reactive = reactive;
            this.loc = location ?? new Point3(0, 0, 0, reactive: reactive);
            this.rot = rotation ?? new Point3(0, 0, 0, reactive: reactive);
            this.tex = texture ?? new POVColor("Red");
            this.finish = finish ?? "finish {phong .9 reflection .5}";
            this.x = rx ?? new Lift0f(x);
            this.y = ry ?? new Lift0f(y);
            this.z = rz ?? new Lift0f(z);
            this.k = rk ?? new Lift0f(k);
            if (algebra.Equals("quaternion"))
            {
                this.algebra = algebra;
            }
            else if (algebra.Equals(" hypercomplex"))
            {
                this.algebra = algebra;
            }
            else this.algebra = "quaternion";
            this.precision = precision;
            this.iterations = iterations;
            this.function = function;
        }

        

        public void move(Point3 loc)
        {
            this.loc = loc;
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add(" julia_fractal {");
            l.Add("<" + this.x + ", " + this.y + ", " +this.x + ", " + this.y + ">");
            l.Add(this.algebra);
            l.Add("max_iteration " + this.iterations);
            l.Add("precision  " + this.precision);
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
                this.rot.update(currentTime);
                //this.tex.update(currentTime);
                this.x.now(currentTime);
                this.y.now(currentTime);
                this.z.now(currentTime);
                this.k.now(currentTime);
            }
        }
    }
}
