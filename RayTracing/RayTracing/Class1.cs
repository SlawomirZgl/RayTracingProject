using RayTracing.Cameras;
using RayTracing.Materials;
using RayTracing.Objects;
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
            IMaterial redMat = new PerfectOne(Color.Red);
            IMaterial greenMat = new PerfectOne(Color.Green);
            IMaterial blueMat = new PerfectOne(Color.Blue);
            IMaterial grayMat = new PerfectOne(Color.Gray);
            IMaterial yellowMaT = new PerfectOne(Color.Yellow);
            IMaterial whiteMat = new PerfectOne(Color.White);
            IMaterial hotPinkMat = new PerfectOne(Color.HotPink);
            IMaterial blackMat = new PerfectOne(Color.Black);

            World world = new World(Color.LightBlue);

            world.Add(new Sphere(new Vector(-4, 0, 0), 3, whiteMat));
            world.Add(new Sphere(new Vector(4, 1, 0), 2, hotPinkMat));
            world.Add(new Sphere(new Vector(-4, 0, 0), 3, whiteMat));
            world.Add(new Sphere(new Vector(4, 0, 0), 3, yellowMaT));
            world.Add(new Sphere(new Vector(0, 0, 3), 2, whiteMat));
            
            world.Add(new Plane(new Vector(0, -2, 0), new Vector(0, 1, 0), grayMat));
            world.AddLight(new LightTypePoint(new Vector(5, 5, -5), Color.White));

            /* world.Add(new Sphere(new Vector(-4, 0, 0), 2, Color.Red));
             world.Add(new Sphere(new Vector(4, 0, 0), 2, Color.Green));
             world.Add(new Sphere(new Vector(0, 0, 3), 2, Color.Blue));*/

            //ICamera camera = new OrtogonalCamera(new Vector(0, 0, -5), 0, new Vector(5, 5));
            ICamera camera = new Pinhole(new Vector(0,-1, -10), new Vector(0, 0, 0), new Vector(0, -1, 0), 1);
            Raytracer tracer = new Raytracer();
          
            Bitmap image = tracer.RayTrace(world, camera, new Size(2532,2543));
           
            Console.WriteLine("Start...");
            image.Save("C:\\Users\\Graca\\Documents\\GitHub\\test3.png"); //Graca
           // image.Save("D:\\STUDIA\\Semestr VI\\PRIR\\Projekt\\test2.png"); //Slawek
           //image.Save("C:\\Users\\Dawid\\Desktop\\szkolka\\PK\\RayTracingProject\\RayTracing\\test2.png");// Dawid

            Console.WriteLine("Koniec");
        }
    }
}
