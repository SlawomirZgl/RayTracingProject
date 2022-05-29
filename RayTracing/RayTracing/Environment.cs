using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    class Environment
    {
        Vector gravity;
        Vector wind;
        public Environment(Vector gravity,Vector wind) {
            this.gravity = gravity;
            this.wind = wind;

        }
    }
}
