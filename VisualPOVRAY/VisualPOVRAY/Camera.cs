using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Camera : PovObj
    {
        private Point3 location, look_at;
        private Signal<float> _bumps;
        private Signal<String> _mesh;
        bool reactive;

        public Camera(Point3 location = null, Point3 look_at = null, float bumps = 0.0f, Signal<float> bumpsr = null, String mesh = null, Signal<String> meshr = null, bool reactive = false)
        {
            //to add a mesh to the camera use the mesh identifier in the constructor
            //to make the image appear as if through curved glass increase the number of bumps
            this.location = location ?? new Point3(0, 2, -3, reactive: reactive);
            this.look_at = look_at ?? new Point3(0, 1, 2, reactive: reactive);
            _bumps = bumpsr ?? new Lift0f(bumps);
            _mesh = meshr ?? new Lift0s(mesh);
            this.reactive = reactive;
        }

        public void changeView(Point3 look_at)
        {
            this.look_at = look_at;
        }

        public void move(Point3 loc)
        {
            this.location = loc;
        }

        public List<string> render()
        {
            List<string> lines = new List<string>();
            lines.Add("camera {");
            if (_mesh.ToString() != null)
            {
                lines.Add("mesh_camera {");
                lines.Add("1");
                lines.Add("distribution #1");
                lines.Add("_mesh");
            }
            lines.Add("    location " + this.location.render()[0]);
            lines.Add("    look_at " + this.look_at.render()[0]);
            lines.Add("normal {bumps " + _bumps + "}");
            lines.Add(" }");
            return lines;
        }

        public void update(float time)
        {
            if (reactive)
            {
                this.location.update(time);
                this.look_at.update(time);
                this._bumps.now(time);
                this._mesh.now(time);
            }
        }
    }
}
