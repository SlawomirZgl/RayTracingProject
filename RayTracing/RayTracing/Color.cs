using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    class Color
    {
        public double r;
        public double g;
        public double b;
        public Color()
        {
            this.r = 0;
            this.g = 0;
            this.b = 0;
        }
        public Color(Color color)
        {
            this.r = color.r;
            this.g = color.g;
            this.b = color.b;
        }
        
        public Color(double r,double g,double b)
        {
            this.r = r;
            this.g = g;
            this.b = b;

        }
        public static Color operator +(Color a,Color b)
        {
            Color temp = new Color();
            temp.r = a.r + b.r;
            temp.g = a.g + b.g;
            temp.b = a.b + b.b;
            return temp;
        }
        public static Color operator -(Color a, Color b)
        {
            Color temp = new Color();
            temp.r = a.r - b.r;
            temp.g = a.g - b.g;
            temp.b = a.b - b.b;
            return temp;
        }
        public static Color operator *(Color a,double b)
        {
            Color temp = new Color();
            temp.r = a.r * b;
            temp.g = a.g * b;
            temp.b = a.b * b;
            return temp;
        }
        public static Color operator *(double a, Color b)
        {
            Color temp = new Color();
            temp.r = a * b.r;
            temp.g = a * b.g;
            temp.b = a * b.b;
            return temp;
        }
        public static Color operator *(Color a, Color b)
        {
            Color temp = new Color();
            temp.r = a.r * b.r;
            temp.g = a.g * b.g;
            temp.b = a.b * b.b;
            return temp;
        }
    }
}
