using RayTracing.Objects;
using RayTracing.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing.Materials
{
    public interface IMaterial
    {
        RgbStruct Radiance(LightTypePoint light, HitInfo hit);
    }
}
