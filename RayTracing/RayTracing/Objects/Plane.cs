using RayTracing.Materials;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing.Objects
{
    class Plane : Object
    {
        Vector point;
        Vector norm;

        public Plane(Vector point, Vector norm, IMaterial material)
        {
            this.point = point;
            this.norm = norm;
            base.material = material;
        }

        public override bool HitTest(Ray ray, ref double distance,ref Vector normal)
        {
            double t = (point - ray.Origin).Dot(norm) / ray.Direction.Dot(norm);
            if(t>Ray.Epsilon)
            {
                distance = t;
                normal = norm;
                return true;
            }
            return false;
        }
    }
}
