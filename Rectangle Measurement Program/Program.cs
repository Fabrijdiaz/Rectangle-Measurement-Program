using System;

namespace Rectangle_Measurement_Program
{
    public class Rectangle
    {
        public int width;
        public int length;

        public Rectangle()
        {
            width = 0;
            length = 0;
        }

    }

    public class Utility
    {
        public static int GetRectangleArea(int w, int l)
        {
            int area = w * l;
            return area;
        }
        public static int GetRectanglePerimeter(int w, int l)
        {
            int perimeter = 2 * (w + l);
            return perimeter;
        }
    }

    class Program
    {
        public static Random random;

        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            random = new Random();
            int w = 0;
            int l = 0;

            MakeRectangle(out w, out l);

            int area = w * l;
            int perimeter = 2 * (w + l);

            Console.WriteLine("Length: " + l);
            Console.WriteLine("Width: " + w);
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
        }

        public static void MakeRectangle(out int w, out int l)
        {
            w = random.Next(1, 100);
            l = random.Next(1, 10);
        }
    }
}