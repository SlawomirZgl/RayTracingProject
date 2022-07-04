using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing.Structures
{
    public struct RgbStruct
    {
        public double R { get; set; }
        public double G { get; set; }
        public double B { get; set; }
        public static readonly RgbStruct White = new RgbStruct(1, 1, 1);
        public static readonly RgbStruct Black = new RgbStruct(0, 0, 0);
        public RgbStruct(double r, double g, double b)
        {
            R = r;
            G = g;
            B = b;
        }
        public static implicit operator RgbStruct(Color color)
        { 
            return new RgbStruct(color.R / 255.0, color.G / 255.0, color.B / 255.0); 
        }
        public static RgbStruct operator +(RgbStruct col1, RgbStruct col2)
        { 
            return new RgbStruct(col1.R + col2.R, col1.G + col2.G, col1.B + col2.B);
        }
        public static RgbStruct operator *(RgbStruct col1, double val)
        { 
            return new RgbStruct(col1.R * val, col1.G * val, col1.B * val); 
        }
        public static RgbStruct operator *(RgbStruct col1, RgbStruct col2)
        {
            return new RgbStruct(col1.R * col2.R, col1.G * col2.G, col1.B * col2.B);
        }
        public static RgbStruct operator /(RgbStruct col1, double val)
        { 
            return col1 * (1 / val); 
        }
        

    }
}
