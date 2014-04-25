using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    public class Point2 : PovObj
    {
        private Signal<float> xs, ys;
        public float x, y;
        public bool reactive;

        public Point2(Signal<float> xs, Signal<float> ys)
        {
            this.reactive = true;
            this.xs = xs;
            this.ys = ys;           
            this.x = xs.now(0);
            this.y = ys.now(0);            
        }

        public Point2(float x, float y, bool reactive = false)
        {
            this.reactive = reactive;
            this.x = x;
            this.y = y;            
            if (reactive)
            {
                this.xs = new Lift0f(x);
                this.ys = new Lift0f(y);                
            }
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("<" + this.x + ", " + this.y + ">");
            return l;
        }
    
        public void move(Point3 loc)
        {
            this.x = loc.x;
            this.y = loc.y;            
        }

        public void update(float currentTime)
        {
            if (reactive)
            {
                x = xs.now(currentTime);
                y = ys.now(currentTime);
            }
        }
    }
}
