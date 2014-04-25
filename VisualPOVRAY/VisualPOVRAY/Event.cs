using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    public class Event
    {
        private float time;
        public delegate void EventFunc();
        private EventFunc func;

        public Event(float time, EventFunc func)
        {
            this.time = time;
            this.func = func;
        }

        public bool pop(float currentTime)
        {
            if (time <= currentTime)
            {
                this.func();
                return true;
            }
            return false;
        }
    }
}
