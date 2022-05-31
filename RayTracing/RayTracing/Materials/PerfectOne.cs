using RayTracing.Objects;
using RayTracing.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing.Materials
{
    class PerfectOne :IMaterial
    {
        RgbStruct color;

        public PerfectOne(RgbStruct color)
        {
            this.color = color;
        }
       public RgbStruct Radiance(LightTypePoint light, HitInfo hit)
        {
            Vector Direction = (light.Position - hit.HitPoint).Normalized();
            double diffuseNumber = Direction.Dot(hit.Normal);
            if (diffuseNumber < 0)
                return RgbStruct.Black;
            return light.Color * color * diffuseNumber;
        }

    }
}
