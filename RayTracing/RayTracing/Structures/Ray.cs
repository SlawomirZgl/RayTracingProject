using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    struct Ray
    {
        public const double Epsilon = 0.0001;
        public const double Huge = double.MaxValue;
        Vector origin;
        Vector direction;
        public Ray(Vector origin, Vector direction) 
        {
            this.origin = origin;
            this.direction = direction.Normalized();
        }
        public Vector Origin { get { return this.origin; } }
        public Vector Direction { get { return this.direction; } }
    }
}
