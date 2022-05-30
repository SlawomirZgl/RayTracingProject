using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing.Cameras
{
    class Pinhole : ICamera
    {
        OrthonormalBase onb;
        Vector origin;
        double distance;

        public Pinhole(Vector origin, Vector watch, Vector up, double distance)
        {
            this.onb = new OrthonormalBase(origin, watch, up);
            this.origin = origin;
            this.distance = distance;
        }

        public Ray GetRayTo(Vector relativeLocation)
        {
            return new Ray(origin, RayDirection(relativeLocation));
        }
        Vector RayDirection(Vector vector)
        {
            return onb * new Vector(vector.X, vector.Y, -distance);
        }
    }
}
