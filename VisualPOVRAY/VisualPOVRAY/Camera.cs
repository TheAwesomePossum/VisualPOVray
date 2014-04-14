using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVray
{
    class Camera : PovObj
    {
        private Point3 location, look_at;

        public Camera(Point3 location, Point3 look_at)
        {
            this.location = location;
            this.look_at = look_at;
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
            lines.Add("    location " + this.location.render()[0]);
            lines.Add("    look_at " + this.look_at.render()[0]);
            lines.Add(" }");
            return lines;
        }

    }
}
