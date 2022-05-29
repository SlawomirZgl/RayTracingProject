using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public class Point : Tuple
    {
        Point() : base(0.0, 0.0, 0.0, 1.0)
        { }
        public Point(double x = 0.0, double y = 0.0, double z = 0.0, double w = 1.0) : base(x, y, z, w)
        {

        }
        public static Point operator +(Point a, Point b)
        {
            Point res = new Point();
            res.x = a.x + b.x;
            res.y = a.y + b.y;
            res.z = a.z + b.z;
            res.w = a.w + b.w;
            return res;

        }

        public static Point operator +(Vector a, Point b)
        {
            Point res = new Point();
            res.x = a.x + b.x;
            res.y = a.y + b.y;
            res.z = a.z + b.z;
            res.w = a.w + b.w;
            return res;

        }

        public static Point operator +(Point a, Vector b)
        {
            Point res = new Point();
            res.x = a.x + b.x;
            res.y = a.y + b.y;
            res.z = a.z + b.z;
            res.w = a.w + b.w;
            return res;
        }

        public static Vector operator -(Point a, Point b)
        {
            Vector res = new Vector();
            res.x = a.x - b.x;
            res.y = a.y - b.y;
            res.z = a.z - b.z;
            res.w = a.w - b.w;
            return res;
        }

        public static Point operator -(Vector a, Point b)
        {
            Point res = new Point();
            res.x = a.x - b.x;
            res.y = a.y - b.y;
            res.z = a.z - b.z;
            res.w = a.w - b.w;
            return res;

        }

        public static Point operator -(Point a, Vector b)
        {
            Point res = new Point();
            res.x = a.x - b.x;
            res.y = a.y - b.y;
            res.z = a.z - b.z;
            res.w = a.w - b.w;
            return res;
        }
        public static Point operator -(Point a)
        {
            Point res = new Point();
            res.x = -a.x;
            res.y = -a.y;
            res.z = -a.z;
            res.w = -a.w;
            return res;
        }
        public Point Negate()
        {
            this.x = -this.x;
            this.y = -this.y;
            this.z = -this.z;
            this.w = -this.w;
            return this;
        }

        public static Point operator *(Point a, double b)
        {
            Point res = new Point();
            res.x = a.x * b;
            res.y = a.y * b;
            res.z = a.z * b;
            res.w = a.w * b;
            return res;
        }

        public static Point operator *(double a, Point b)
        {
            Point res = new Point();
            res.x = b.x * a;
            res.y = b.y * a;
            res.z = b.z * a;
            res.w = b.w * a;
            return res;
        }

        public Point Scale(double s)
        {
            this.x *= s;
            this.y *= s;
            this.z *= s;
            this.w *= s;

            return this;
        }

    }
}
