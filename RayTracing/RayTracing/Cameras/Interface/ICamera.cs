using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    interface ICamera
    {
        Ray GetRayTo(Vector relativeLocation);
    }
}
