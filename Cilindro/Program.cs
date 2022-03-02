using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration of variables
            float pi = (float) Math.PI;
            float height;
            string sHeight;
            float radius;
            string sRadius;
            float volume;
            float surfaceArea;

            //player input
            Console.WriteLine("Hello, please tell me the cylinder's height:");
            sHeight = Console.ReadLine();
            Console.WriteLine("Good, now tell me the cylinder's radius:");
            sRadius = Console.ReadLine();

            //convert string to float
            height = float.Parse(sHeight);
            radius = float.Parse(sRadius);

            //calculations
            volume = pi * (float)Math.Pow(radius, 2) * height;
            surfaceArea = 2 * radius * (radius + height);

            //print results
            Console.WriteLine($"A cylinder with a height of {height}, and a" +
            $" radius of {radius}, has a volume of {volume} and the surface" +
            $" area of {surfaceArea}.");
        }
    }
}
