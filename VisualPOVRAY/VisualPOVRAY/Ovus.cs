using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Ovus : PovObj
    {
        public Point3 loc;
        float topRadius, bottomRadius;
        PovTexture texture;

        public Ovus(Point3 loc, float topRadius, float bottomRadius)
        {
            this.loc = loc;
            this.topRadius = topRadius;
            this.bottomRadius = bottomRadius;
            this.texture = new POVColor("Red");
        }

        public Ovus(Point3 loc, float topRadius, float bottomRadius, PovTexture texture)
        {
            this.loc = loc;
            this.topRadius = topRadius;
            this.bottomRadius = bottomRadius;
            this.texture = texture;
        }

        public void move(Point3 loc)
        {
            this.loc = loc;
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("ovus {");
            l.Add(this.topRadius + ", " + this.bottomRadius);
            l.Add("translate " + this.loc.render()[0]);
            l.AddRange(this.texture.render());
            l.Add("}");
            return l;
        }
    }
}
