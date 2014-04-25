using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    public class Lift0b : Signal<Boolean>
    {
        Boolean value;

        public Lift0b(Boolean value)
        {
            this.value = value;
        }

        public bool now(float currentTime)
        {
            return value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
