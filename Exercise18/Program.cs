using System;

namespace Exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of variables
            string input, response;
            int charCount = 0;

            //read input from player
            Console.WriteLine("Write a sentence:");
            input = Console.ReadLine();

            //count char in input
            charCount = input.Length;

            //chose correct response
            if (charCount >= 0 && charCount < 5)
                response = "That's not very meaningful, is it?";
            else if (charCount <= 20)
                response = "Ok, if you say so.";
            else
                response = "Too long to read.";

            //print response
            Console.WriteLine(response);

        }
    }
}
