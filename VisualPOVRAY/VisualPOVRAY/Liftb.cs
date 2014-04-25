using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    class Liftb : Signal<Boolean>
    {
        public Boolean curVal;
        public Signal<Boolean> value;
        public delegate Boolean SigUp(float currentTime, bool curVal, Signal<bool> value);
        public SigUp sigUp;
        public float updTime;

        public Liftb(Signal<Boolean> value, SigUp sigUp, Boolean initValue = false)
        {
            this.value = value;
            this.curVal = initValue;
            this.sigUp = sigUp;
            this.updTime = 0f;
        }

        public bool now(float currentTime)
        {
            if (this.updTime != currentTime)
            {
                this.curVal = sigUp(currentTime, curVal, value);
                this.updTime = currentTime;
            }
            return curVal;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
