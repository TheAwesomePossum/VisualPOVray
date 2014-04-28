using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    public class Merge : PovObj
    {
        public PovObj o1;
        public PovObj[] o2;
        bool reactive;

        public Merge(PovObj o1, PovObj[] o2, bool reactive = false)
        {
            this.reactive = reactive;
            this.o1 = o1;
            this.o2 = o2;
        }
       
        public Merge(PovObj o1, PovObj o2, bool reactive = false)
        {
            this.reactive = reactive;
            this.o1 = o1;
            this.o2 = new PovObj[1];
            this.o2[0] = o2;
        }


        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("merge {");
            l.AddRange(this.o1.render());
            foreach (PovObj o in o2)
            {
                l.AddRange(o.render());
            }
            l.Add("}");
            return l;
        }


        public void update(float time)
        {
            if (reactive)
            {
                o1.update(time);
                foreach (PovObj o in o2)
                {
                    o.update(time);
                }
            }
        }
    }
}
