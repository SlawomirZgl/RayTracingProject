using RayTracing.Materials;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    class Sphere : Object
    {
        Vector center;
        double radius;
        public Sphere(Vector center,double radius, IMaterial material)
        {
            this.center = center;
            this.radius = radius;
            base.material = material;
        }
        public override bool HitTest(Ray ray, ref double minDistance,ref Vector normal)
        {
            double t;
            Vector distance = ray.Origin - center;
            double a = ray.Direction.LengthSqr();
            double b = (distance * 2).Dot(ray.Direction);
            double c = distance.LengthSqr() - radius * radius;
            double disc = b * b - 4 * a * c;
            if (disc < 0) { return false; }
            double discSq = Math.Sqrt(disc);
            double denom = 2 * a;
            t = (-b - discSq) / denom;
            if (t < Ray.Epsilon)
            { t = (-b + discSq) / denom; }
            if (t < Ray.Epsilon)
            { return false; }
            Vector hitPoint = (ray.Origin + ray.Direction * t);
            normal = (hitPoint - center).Normalized();//Tu powinno byc normalized ale nie chce chwycic
            minDistance = t;
            return true;
        }
    }
}
