using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    class Raytracer
    {
        public Bitmap Raytrace(World world, ICamera camera, Size imageSize)
        {
            Bitmap bmp = new Bitmap(imageSize.Width, imageSize.Height);
            for (int x = 0; x < imageSize.Width; x++)
                for (int y = 0; y < imageSize.Height; y++)
                {
                  
                    Vector pictureCoordinates = new Vector(
                    ((x + 0.5) / (double)imageSize.Width) * 2 - 1,
                    ((y + 0.5) / (double)imageSize.Height) * 2 - 1);
                   
                    Ray ray = camera.GetRayTo(pictureCoordinates);
                    HitInfo info = world.TraceRay(ray);
                  
                    Color color;
                    if (info.HitObject) { color = info.Color; }
                    else { color = world.BackgroundColor; }
                    bmp.SetPixel(x, y, color);
                }
            return bmp;
        }
    }
}
