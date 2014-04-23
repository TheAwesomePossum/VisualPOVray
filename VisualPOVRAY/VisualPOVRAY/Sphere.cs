﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Sphere : PovObj
    {
        public Point3 loc;
        float rad;
        public Point3 trans;
        public Point3 rot;
        PovTexture tex;

        public Sphere(Point3 location = null, float radius = 1.0f, Point3 translate = null, Point3 rotation = null, PovTexture texture = null)
        {
            this.loc = location ?? new Point3(0,0,0);
            this.rad = radius;
            this.trans = translate ?? new Point3(0, 0, 0);
            this.rot = rotation ?? new Point3(0, 0, 0);
            this.tex = texture ?? new POVColor("Red");
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("sphere {");
            l.Add("    " + this.loc.render()[0] + ", " + this.rad);
            l.AddRange(this.tex.render());
            l.Add("    rotate " + this.rot.render()[0]);
            l.Add("    translate " + this.trans.render()[0]);
            l.Add("}");
            return l;
        }

        public void move(Point3 transform)
        {
            this.trans = transform;
        }

    }
}
