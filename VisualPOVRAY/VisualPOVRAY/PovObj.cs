using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVray
{
    interface PovObj
    {
        void move(Point3 loc);
        List<string> render();
    }
}
