using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    class Canvas
    {
        int width;
        int height;
        Color[,] canvas;
        public Canvas(int width=100,int height=100)
        {
            this.width = width;
            this.height = height;   
        }
        void CreateCanvas()
        {
            canvas = new Color[width, height];
            FillCanvas(new Color(0, 0, 0));
            
        }
        public void FillCanvas(Color color)
        {
            for (int x = 0; x < width; x++)
                for (int y = 0; y > height; y++) {
                    canvas[x, y] = new Color(color);
                }
        }
        public int GetWidth()
        {
            return width;
        }
        public int GetHeight()
        {
            return height;
        }
        public void SetPixel(int x,int y,Color color)
        {
            if(x<width && y < height)
            {
                canvas[x, y] = color;
            }
        }
        public Color GetPixel(int x, int y) {
            Color temp = new Color();
            if (x < width && y < height) {
                temp = canvas[x, y];
            }
            return temp;
        }
    }
}
