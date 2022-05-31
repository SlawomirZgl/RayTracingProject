using RayTracing.Materials;
using RayTracing.Structures;
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
        public Bitmap RayTrace(World world, ICamera camera, Size imageSize)
        {
            Bitmap bmp = new Bitmap(imageSize.Width, imageSize.Height);
            for (int x = 0; x < imageSize.Width; x++)
                for (int y = 0; y < imageSize.Height; y++)
                {                  
                    Vector pictureCoordinates = new Vector(
                    ((x + 0.5) / (double)imageSize.Width) * 2 - 1,
                    ((y + 0.5) / (double)imageSize.Height) * 2 - 1);
                   
                    Ray ray = camera.GetRayTo(pictureCoordinates);
                    bmp.SetPixel(x, y, StripColor(ShadeRay(world,ray)));
                }
            return bmp;
        }
        public RgbStruct ShadeRay(World world, Ray ray)
        {
            HitInfo info = world.TraceRay(ray);
            if (info.HitObject == null) { return world.BackgroundColor; }
            RgbStruct finalColor = RgbStruct.Black;
            IMaterial material = info.HitObject.material;
            foreach (var light in world.Lights)
            {
                finalColor += material.Radiance(light, info);
            }
            return finalColor;
        }
        Color StripColor(RgbStruct colorInfo)
        {
            colorInfo.R = colorInfo.R < 0 ? 0 : colorInfo.R > 1 ? 1 : colorInfo.R;
            colorInfo.G = colorInfo.G < 0 ? 0 : colorInfo.G > 1 ? 1 : colorInfo.G;
            colorInfo.B = colorInfo.B < 0 ? 0 : colorInfo.B > 1 ? 1 : colorInfo.B;
            return Color.FromArgb((int)(colorInfo.R * 255),
            (int)(colorInfo.G * 255),
            (int)(colorInfo.B * 255));
        }

    }
}
