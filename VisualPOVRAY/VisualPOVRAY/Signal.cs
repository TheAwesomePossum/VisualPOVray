using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    public interface Signal<T>
    {

        T now(float currentTime);

    }
}
