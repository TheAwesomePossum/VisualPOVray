using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    public class Point3 : PovObj
    {
        private Signal<float> xs, ys, zs;
        public float x, y, z;
        public bool reactive;

        public Point3(Signal<float> xs, Signal<float> ys, Signal<float> zs)
        {
            this.reactive = true;
            this.xs = xs;
            this.ys = ys;
            this.zs = zs;
            this.x = xs.now(0);
            this.y = ys.now(0);
            this.z = zs.now(0);
        }

        public Point3(float x, float y, float z, bool reactive = false)
        {
            this.reactive = reactive;
            this.x = x;
            this.y = y;
            this.z = z;
            if (reactive)
            {
                this.xs = new Lift0f(x);
                this.ys = new Lift0f(y);
                this.zs = new Lift0f(z);
            }
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("<" + this.x + ", " + this.y + ", " + this.z + ">");
            return l;
        }
    
        public void move(Point3 loc)
        {
            this.x = loc.x;
            this.y = loc.y;
            this.z = loc.z;
        }

        public void update(float currentTime)
        {
            if (reactive)
            {
                x = xs.now(currentTime);
                y = ys.now(currentTime);
                z = zs.now(currentTime);
            }
        }
        
        public Point3 crossproduct(Point3 vec) //vector perpendicular to given vectors
        {
            if (this != null && vec != null)
            {
                Point3 results = new Point3(0, 0, 0);
                results.x = this.y * vec.z - this.z * vec.y;
                results.y = this.z * vec.x - this.x * vec.z;
                results.z = this.x * vec.y - this.y * vec.x;
                return results;
            }
            else
            {
                return null;
            }
        }
        
    }
}
