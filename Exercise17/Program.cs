using System;

namespace Exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration od variables
            string input, response = "";
            int intInput;

            //read player input
            Console.WriteLine("Hello, please give me a number:");
            input = Console.ReadLine();

            //check the number
            intInput = int.Parse(input);
            if (intInput % 3 == 0)
                response += "Fizz";
            if (intInput % 5 == 0)
                response += "Buzz";
            if (intInput % 3 != 0 && intInput % 5 != 0)
                response = input;
            response += "!";

            //print result
            Console.WriteLine(response);

        }
    }
}
