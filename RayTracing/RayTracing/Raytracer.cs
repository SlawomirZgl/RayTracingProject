using RayTracing.Materials;
using RayTracing.Structures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RayTracing
{
    class Raytracer
    {
        public Bitmap RayTrace(World world, ICamera camera, Size imageSize)
        {
            unsafe
            {
                Bitmap bmp = new Bitmap(imageSize.Width, imageSize.Height,PixelFormat.Format24bppRgb);

             BitmapData bitmapData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);

                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(bmp.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;
                byte* PtrFirstPixel = (byte*)bitmapData.Scan0;
                Parallel.For(0, heightInPixels, y =>
                {
                    byte* currentLine = PtrFirstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        Vector pictureCoordinates = new Vector(
                        ((x + 0.5) / (double)widthInBytes) * 2 - 1,
                        ((y + 0.5) / (double)heightInPixels) * 2 - 1);

                        Ray ray = camera.GetRayTo(pictureCoordinates);
                        Color color = StripColor(ShadeRay(world, ray));
                        currentLine[x] = (byte)color.B;
                        currentLine[x+1] = (byte)color.G;
                        currentLine[x+2] = (byte)color.R;
                    }
                }
                );
                bmp.UnlockBits(bitmapData);
                return bmp;
            }
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
