using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public class Vector : Tuple
    {
        Vector() : base(0.0, 0.0, 0.0, 0.0)
        { }
        public Vector(double x = 0.0, double y = 0.0, double z = 0.0, double w = 0.0) : base(x, y, z, w)
        {

        }
        public static Vector operator +(Vector a, Vector b)
        {
            Vector res = new Vector();
            res.x = a.x + b.x;
            res.y = a.y + b.y;
            res.z = a.z + b.z;
            res.w = a.w + b.w;
            return res;

        }
        public static Vector operator -(Vector a, Vector b)
        {
            Vector res = new Vector();
            res.x = a.x - b.x;
            res.y = a.y - b.y;
            res.z = a.z - b.z;
            res.w = a.w - b.w;
            return res;

        }
        public static Vector operator -(Vector a)
        {
            Vector res = new Vector();
            res.x = -a.x;
            res.y = -a.y;
            res.z = -a.z;
            res.w = -a.w;
            return res;
        }
        public static Vector operator *(Vector a, double b)
        {
            Vector temp = new Vector();
            temp.x = a.x * b;
            temp.y = a.y * b;
            temp.z = a.z * b;
            temp.w = a.w * b;
            return temp;
        }

        public static Vector operator *(double a, Vector b)
        {
            Vector temp = new Vector();
            temp.x = b.x * a;
            temp.y = b.y * a;
            temp.z = b.z * a;
            temp.w = b.w * a;
            return temp;
        }
        public static Vector operator *(Vector a, double b)
        {
            Vector temp = new Vector();
            temp.x = a.x * b;
            temp.y = a.y * b;
            temp.z = a.z * b;
            temp.w = a.w * b;
            return temp;
        }
        public Vector Negate()
        {
            this.x = -this.x;
            this.y = -this.y;
            this.z = -this.z;
            this.w = -this.w;
            return this;
        }

        public Vector Scale(double s)
        {
            this.x *= s;
            this.y *= s;
            this.z *= s;
            this.w *= s;

            return this;
        }

        public Vector Cross(Vector b)
        {
            Vector res = new Vector();
            res.x = this.y * b.z - this.z * b.y;
            res.y = this.z * b.x - this.x * b.z;
            res.z = this.x * b.y - this.y * b.x;
            return res;
        }

        public static Vector Cross(Vector a, Vector b)
        {
            Vector res = new Vector();
            res.x = a.y * b.z - a.z * b.y;
            res.y = a.z * b.x - a.x * b.z;
            res.z = a.x * b.y - a.y * b.x;
            return res;
        }
    }
     
}
