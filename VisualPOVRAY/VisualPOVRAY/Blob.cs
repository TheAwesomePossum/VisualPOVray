using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    public class Blob:PovObj
    {
        public List<PovObj> blob;
        public Point3 rot,trans;
        public float threshold;

        public Blob(float threshold = .06f, Point3 rotate = null, Point3 translate = null, List<PovObj> blob = null)
        {
            this.threshold = threshold;
            this.rot = rotate ?? new Point3(0,0,0);
            this.trans = translate ?? new Point3(0, 0, 0);
            this.blob = blob ?? new List<PovObj>();
        }
        public void add(PovObj obj)
        {
            blob.Add(obj);
        }

        public List<string> render()
        {
            List<string> rend = new List<string>();
            rend.Add("blob {");
            rend.Add("    threshold " + threshold);
            foreach (PovObj obj in blob)
            {
                List<string> temp = obj.render();
                for (int i = 0; i < temp.Count; i++)
                {
                    if (i == 1)
                    {
                        rend.Add("    " + temp[i] + ", 1");
                    }
                    else
                    {
                        rend.Add("    " + temp[i]);
                    }
                }
            }
            rend.Add("    rotate " + rot.render()[0]);
            rend.Add("    translate " + trans.render()[0]);
            rend.Add("}");
            return rend;
        }
    }
}
