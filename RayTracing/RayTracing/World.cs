using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    class World
    {
        List<Object> objects;
        public World(Color background)
        {
            this.BackgroundColor = background;
            this.objects = new List<Object>();
        }
        public void Add(Object obj)
        {
            objects.Add(obj);
        }
        public HitInfo TraceRay(Ray ray)
        {
            HitInfo result = new HitInfo();
            double minimalDistance = Ray.Huge; 
            double hitDistance = 0; 
            foreach (var obj in objects)
            {
                if (obj.HitTest(ray, ref hitDistance) &&
                hitDistance < minimalDistance)
                {
                    minimalDistance = hitDistance; 
                    result.HitObject = true;
                    result.Color = obj.Color; 
                }
            }
            return result;
        }
        public Color BackgroundColor { get; private set; }
    }
}


