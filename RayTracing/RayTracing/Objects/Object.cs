﻿using RayTracing.Materials;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public abstract class Object
    {
        public Color Color { get; set; }
        public IMaterial material { get; set; }
        public abstract bool HitTest(Ray ray, ref double distance, ref Vector normal);
    }
}
