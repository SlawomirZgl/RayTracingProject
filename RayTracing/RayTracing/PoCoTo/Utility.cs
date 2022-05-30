using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public static class Utility
    {
        public static double Epsilon = 0.0001;
        public static bool Equality(double a,double b)
        {
            double temp = a - b;
            if (temp < 0) {
                temp *= -1;
            }

            if (temp < Epsilon) {
                return true;
            }
            return false;   
        }
    }
}
