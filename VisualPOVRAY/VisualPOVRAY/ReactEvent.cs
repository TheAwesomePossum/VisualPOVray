using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fn = VisualPOVRAY.Functions;

namespace VisualPOVRAY
{
    class ReactEvent : Event
    {
        fn.ReactFunc rf;
        fn.EventFunc ef;
        public ReactEvent(fn.ReactFunc rf, fn.EventFunc ef)
        {
            this.rf = rf;
            this.ef = ef;
        }

        public bool pop(float currentTime)
        {
            return rf(currentTime);
        }
    }
}
