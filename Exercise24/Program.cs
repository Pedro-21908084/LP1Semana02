using System;

namespace Exercise24
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration of variables
            double num1, num2, result = double.MinValue;
            string input;

            //Read input
            Console.WriteLine("Write an operaion(ex: x + y , ANS to use " +
            "the last result, QUIT to stop application):");
            input = Console.ReadLine();
            
            //Check if quit
            if(input == "QUIT")
                return;
                
            //split string
            string[] inputDivided = input.Split(" ");

            //checks if the operation is valid
            if (!(inputDivided[1] == "+" || inputDivided[1] == "-" || inputDivided[1] == "x" ||
            inputDivided[1] == "/" || inputDivided[1] == "p"))
            {
                Console.WriteLine("Operation not recognized.");
                return;
            }
            //checks if there is an last result
            if ((inputDivided[0] == "ANS" || inputDivided[2] == "ANS") && result == double.MinValue)
            {
                Console.WriteLine("There isn't an last operation to use " +
                "its result.");
                return;
            }

            //convert arguments to doubles
            if (inputDivided[0] == "ANS")
                num1 = result;
            else
                num1 = Convert.ToDouble(inputDivided[0]); //double.Parse(sNum1);
            if (inputDivided[2] == "ANS")
                num2 = result;
            else
                num2 = Convert.ToDouble(inputDivided[2]);

            //do the calculation ask
            result = inputDivided[1] switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "/" => num1 / num2,
                "x" => num1 * num2,
                "p" => Math.Pow(num1, num2),
                _ => 0,
            };
            //print result
            Console.WriteLine(result);
        }
    }
}
