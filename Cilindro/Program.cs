﻿using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration of variables
            float pi = 3.1415926f;
            float height;
            string sHeight;
            float radius;
            string sRadius;
            float volume = 0;
            float surfaceArea = 0;

            //player input
            Console.WriteLine("Hello, please tell me the cylinder's height:");
            sHeight = Console.ReadLine();
            Console.WriteLine("Good, now tell me the cylinder's radius:");
            sRadius = Console.ReadLine();

            //convert string to float
            height = float.Parse(sHeight);
            radius = float.Parse(sRadius);

            //calculations

            //print results
            Console.WriteLine($"A cylinder with a height of {height}, and a" +
            $" radius of {radius}, has a volume of {volume} and the surface" +
            $" area of {surfaceArea}.");
        }
    }
}
