using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    public class Intersection:PovObj
    {
        public PovObj o1, o2;
        bool reactive;

        public Intersection(PovObj o1, PovObj o2, bool reactive = false)
        {
            this.reactive = reactive;
            this.o1 = o1;
            this.o2 = o2;   
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("intersection {");
            l.AddRange(this.o1.render());
            l.AddRange(this.o2.render());
            l.Add("}");
            return l;
        }



        public void update(float time)
        {
            if (reactive)
            {
                o1.update(time);
                o2.update(time);
            }
        }
    }
}
