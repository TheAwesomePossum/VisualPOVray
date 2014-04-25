using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    public class Lift0s : Signal<string>
    {
        public string value;

        public Lift0s(string value)
        {
            this.value = value;
        }

        public string now(float currentTime)
        {
            return value;
        }

        public override string ToString()
        {
            return value;
        }
    }
}
