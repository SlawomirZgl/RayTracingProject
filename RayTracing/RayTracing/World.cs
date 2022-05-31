using RayTracing.Objects;
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
        List<LightTypePoint> lights;
        public World(Color background)
        {
            this.BackgroundColor = background;
            this.objects = new List<Object>();
            this.lights = new List<LightTypePoint>();
        }
        public void Add(Object obj)
        {
            objects.Add(obj);
        }
        public void AddLight(LightTypePoint light)
        {
            lights.Add(light);
        }
        public HitInfo TraceRay(Ray ray)
        {
            HitInfo result = new HitInfo();
            Vector normal = default(Vector);
            double minimalDistance = Ray.Huge;
            double hitDistance = 0;

            foreach (var obj in objects)
            {
                if (obj.HitTest(ray, ref hitDistance,ref normal) && hitDistance < minimalDistance)
                {
                    minimalDistance = hitDistance; 
                    result.HitObject = obj;
                    result.Normal =normal; 
                }
                if (result.HitObject != null)
                {
                    result.HitPoint = ray.Origin + ray.Direction * minimalDistance;
                    result.Ray = ray;
                    result.world = this;
                }


            }
            return result;
        }
        public Color BackgroundColor { get; private set; }
        public List<Object> Objects { get { return objects; } }
        public List<LightTypePoint> Lights { get { return lights; } }

    }
}


