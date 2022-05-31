using RayTracing.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing.Objects
{
    class LightTypePoint
    {
        public Vector Position { get;  set; }
        public RgbStruct Color { get;  set; }

        public LightTypePoint(Vector position, RgbStruct color)
        {
            Position = position;
            Color = color;
        }
    }
}
