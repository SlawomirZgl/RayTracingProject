using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public struct Vector 
    {
        public double x;
        public double y;
        public double z;

        public Vector(double x = 0.0, double y = 0.0, double z = 0.0) 
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public double Z { get { return z; } set { z = value; } }

        public static Vector operator +(Vector a, Vector b)
        {
            Vector res = new Vector();
            res.x = a.x + b.x;
            res.y = a.y + b.y;
            res.z = a.z + b.z;
         
            return res;
        }
        public static Vector operator -(Vector a, Vector b)
        {
            Vector res = new Vector();
            res.x = a.x - b.x;
            res.y = a.y - b.y;
            res.z = a.z - b.z;
           
            return res;
        }
        public static Vector operator -(Vector a)
        {
            Vector res = new Vector();
            res.x = -a.x;
            res.y = -a.y;
            res.z = -a.z;
        
            return res;
        }
        public static Vector operator *(Vector a, double b)
        {
            Vector temp = new Vector();
            temp.x = a.x * b;
            temp.y = a.y * b;
            temp.z = a.z * b;
           
            return temp;
        }

        public static Vector operator *(double a, Vector b)
        {
            Vector temp = new Vector();
            temp.x = b.x * a;
            temp.y = b.y * a;
            temp.z = b.z * a;
          
            return temp;
        }
        public static Vector operator /(Vector a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            Vector temp = new Vector();
            temp.x = a.x / b;
            temp.y = a.y / b;
            temp.z = a.z / b;

            return temp;          
        }
        public Vector Negate()
        {
            this.x = -this.x;
            this.y = -this.y;
            this.z = -this.z;
           
            return this;
        }

        public Vector Scale(double s)
        {
            this.x *= s;
            this.y *= s;
            this.z *= s;       

            return this;
        }
        public double Dot(Vector a) {
            return (this.x * a.x + this.y * a.y + this.z * a.z);
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
        public double Length()
        {  return Math.Sqrt(X * X + Y * Y + Z * Z);  }
        public double LengthSqr()
        {  return X * X + Y * Y + Z * Z; }
        public Vector Normalized()
        {  return this / this.Length();  }
    }

}
