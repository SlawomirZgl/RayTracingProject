using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing.Cameras
{
    class OrthonormalBase
    {
        Vector u;
        Vector v;
        Vector w;

        public OrthonormalBase(Vector eye, Vector watch, Vector up)
        {
            w = eye - watch;
            w = w.Normalized();
            u = Vector.Cross(up, w);
            u = u.Normalized();
            v = Vector.Cross(w, u);
        }

        public static Vector operator *(OrthonormalBase onb, Vector v)
        {
            return (onb.u * v.X + onb.v * v.Y + onb.w * v.Z);
        }
    }
}
