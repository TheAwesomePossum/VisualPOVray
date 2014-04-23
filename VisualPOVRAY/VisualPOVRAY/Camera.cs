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
        private double _bumps;
        private String _mesh;

        public Camera(Point3 location, Point3 look_at, double bumps = 0, String mesh = null)
        {
            //to add a mesh to the camera use the mesh identifier in the constructor
            //to make the image appear as if through curved glass increase the number of bumps
            this.location = location;
            this.look_at = look_at;
            _bumps = bumps;
            _mesh = mesh;
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
            if (_mesh != null)
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

    }
}
