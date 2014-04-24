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
        float x,y,z,k;
        PovTexture texture;
        String algebra, function;
        int precision, iterations;

        public JuliaFractal(float x, float y, float z, float k, String algebra, String function, int precision, int iterations, Point3 loc)
        {
            this.loc = loc;
            this.x = x;
            this.y = y;
            this.z = z;
            this.k = k;
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
            this.texture = new POVColor("Red");
        }

        public JuliaFractal(float x, float y, float z, float k, Point3 loc, String algebra, String function, 
            int precision, int iterations, PovTexture texture)
        {
            this.loc = loc;
            this.x = x;
            this.y = y;
            this.z = z;
            this.k = k;
            this.function = function;
            this.texture = texture;
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
            l.Add("   translate" + this.loc.render()[0]);
            l.AddRange(this.texture.render());
            l.Add("}");
            return l;
        }
    }
}
