using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    public class Liftf : Signal<float>
    {
        private Signal<float> value;
        private float curVal;
        private float updTime;
        public delegate float SigUp(float currentTime, float curVal, Signal<float> value);
        private SigUp sigUp;

        public Liftf(Signal<float> value, SigUp sigUp, float initValue = 0f)
        {
            this.value = value;
            this.curVal = initValue;
            this.sigUp = sigUp;
            this.updTime = 0;
        }

        public float now(float currentTime)
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
            return curVal.ToString();
        }
    }
}
