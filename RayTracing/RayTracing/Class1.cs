using RayTracing.Cameras;
using System;
using System.Drawing;

namespace RayTracing
{
    public class Class1
    {
      public static void Main()
        {
            // Vector v = new Vector(1, 2, 3);
            //  Console.WriteLine(v.z);

            World world = new World(Color.LightBlue);

            world.Add(new Sphere(new Vector(0, 4, 15), 5, Color.White));
            world.Add(new Sphere(new Vector(0, 0, 11), 3, Color.Yellow));
            world.Add(new Sphere(new Vector(0, -2, 9), 2, Color.White));
            world.Add(new Sphere(new Vector(1, 0.5, 8), 0.2, Color.Black));
            world.Add(new Sphere(new Vector(-1, 0.5, 8), 0.2, Color.Black));

            /* world.Add(new Sphere(new Vector(-4, 0, 0), 2, Color.Red));
             world.Add(new Sphere(new Vector(4, 0, 0), 2, Color.Green));
             world.Add(new Sphere(new Vector(0, 0, 3), 2, Color.Blue));*/

            //ICamera camera = new OrtogonalCamera(new Vector(0, 0, -5), 0, new Vector(5, 5));
            ICamera camera = new Pinhole(new Vector(3, 15, -1), new Vector(0, 0, 0), new Vector(0, -1, 0), 1);
            Raytracer tracer = new Raytracer();
          
            Bitmap image = tracer.RayTrace(world, camera, new Size(256, 256));
           
            Console.WriteLine("Start...");
            //image.Save("C:\\Users\\Graca\\Documents\\GitHub\\test2.png"); //Graca
            image.Save("D:\\STUDIA\\Semestr VI\\PRIR\\Projekt\\test2.png"); //Slawek
            //image.Save("Sciezka\\sciezka"); //Dawid

            Console.WriteLine("Koniec");
        }
    }
}
