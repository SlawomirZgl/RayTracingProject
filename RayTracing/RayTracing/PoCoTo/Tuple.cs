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
     

        public Tuple(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
           
        }
        public double Magnitude()
        {
            return Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
        }
        public static bool operator ==(Tuple a,Tuple b )
        {
            if (Utility.Equality(a.x, b.x) &&
                Utility.Equality(a.y, b.y) &&
                Utility.Equality(a.z, b.z))
             
            {
                return true;
            }
            return false;

        }
        public static bool operator !=(Tuple a, Tuple b)
        {
            if (Utility.Equality(a.x, b.x) &&
                Utility.Equality(a.y, b.y) &&
                Utility.Equality(a.z, b.z) )
             
            {
                return false;
            }
            return true;

        }
    }
}
 