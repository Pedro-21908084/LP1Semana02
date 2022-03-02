using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 0;

            //espero que x=2 e y=2
            y= ++x;

            Console.WriteLine($"x = {x} e y = {y}");
        }
    }
}
