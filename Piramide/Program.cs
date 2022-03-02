using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definition of variables
            int size, intInput, lineSize;
            string input;

            //Read player input
            Console.WriteLine("Tell me the tree size:");
            input = Console.ReadLine();
            intInput = int.Parse(input);

            //Calculate size
            size = ImparPorIndex(intInput);

            //Loop to print tree
            for (int i = 1; i <= intInput; i++)
            {
                lineSize = ImparPorIndex(i);

                for (int j = 0; j < size; j++)
                {
                    if (j >= (size / 2 - lineSize / 2) && j < size / 2 + lineSize / 2 + 1)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }

        static int ImparPorIndex(int x)
        {
            return 1 + (x - 1) * 2;
        }
    }
}
