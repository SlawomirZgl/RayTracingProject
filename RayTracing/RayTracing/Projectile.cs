using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
   public class Projectile
    {
        Point position;
        Vector velocity;
        public Projectile(Point position,Vector velocity)
        {
            this.position = position;
            this.velocity = velocity;
        }
    }
}
