using System;

namespace Exercise23
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration of variables
            double arg1, arg2, result;

            //check the number of arguments given and finish if not enough
            if (args.Length != 3)
            {
                Console.WriteLine("Not enough arguments given.");
                return;
            }
            if (!(args[0] == "+" || args[0] == "-" || args[0] == "x" ||
            args[0] == "/" || args[0] == "p"))
            {
                Console.WriteLine("Operation not recognized.");
                return;
            }

            //convert arguments to doubles
            arg1 = double.Parse(args[1]);
            arg2 = double.Parse(args[2]);

            //do the calculation ask
            result = args[0] switch
            {
                "+" => arg1 + arg2,
                "-" => arg1 - arg2,
                "/" => arg1 / arg2,
                "x" => arg1 * arg2,
                "p" => Math.Pow(arg1, arg2),
                _ => 0,
            };
            //print result
            Console.WriteLine(result);
        }
    }
}