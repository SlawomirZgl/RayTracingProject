using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    class HitInfo
    {
        public Object HitObject { get; set; }
        public World world { get; set; }
        public Vector Normal { get; set; }
        public Vector HitPoint { get; set; }
        public Ray Ray { get; set; }

    }
}
