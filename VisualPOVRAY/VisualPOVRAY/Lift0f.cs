using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    public class Lift0f : Signal<float>
    {
        private float value;

        public Lift0f(float v)
        {
            this.value = v;
        }

        public float now(float currentTime)
        {
            return value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
