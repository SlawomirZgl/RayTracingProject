using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
   public abstract class Tuple
    {
        public double x;
        public double y;
        public double z;
        public double w;

        public Tuple(double x, double y, double z, double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        public double Magnitude()
        {
            return Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
        }
        public static bool operator ==(Tuple a,Tuple b )
        {
            if (Utility.Equality(a.x, b.x) &&
                Utility.Equality(a.y, b.y) &&
                Utility.Equality(a.z, b.z) &&
                Utility.Equality(a.w, b.w))
            {
                return true;
            }
            return false;

        }
        public static bool operator !=(Tuple a, Tuple b)
        {
            if (Utility.Equality(a.x, b.x) &&
                Utility.Equality(a.y, b.y) &&
                Utility.Equality(a.z, b.z) &&
                Utility.Equality(a.w, b.w))
            {
                return false;
            }
            return true;

        }
    }
}
 