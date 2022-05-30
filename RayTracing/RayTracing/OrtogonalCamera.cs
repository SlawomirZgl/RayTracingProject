using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    class OrtogonalCamera:ICamera
    {
        public Vector EyePosition { get; set; }
        public double Angle { get; set; }
        public Vector CameraSize { get; set; }
        public OrtogonalCamera(Vector eye, double angle, Vector size)
        {
            this.EyePosition = eye;
            this.Angle = angle;
            this.CameraSize = size;
        }
        public Ray GetRayTo(Vector pictureLocation)
        {
            Vector direction = new Vector(
                Math.Sin(Angle),
                0,
                Math.Cos(Angle));
            direction = direction.Normalized();
            Vector offsetFromCenter = new Vector(
                pictureLocation.X * CameraSize.X,
                pictureLocation.Y * CameraSize.Y); 
            Vector position = new Vector(
                EyePosition.X + offsetFromCenter.X * Math.Cos(Angle),
                EyePosition.Y + offsetFromCenter.Y,
                EyePosition.Z + offsetFromCenter.X * Math.Sin(Angle));
            return new Ray(position,direction);
        }

    }
}
