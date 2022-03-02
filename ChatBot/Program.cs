using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, response;

            Console.WriteLine("Hello there, with all my knowledge i shall " +
            "answer to all your questions!");

            //Runs forever
            while (true)
            {
                Console.WriteLine("Ask a question(EXIT to stop the program):");
                //read player inputs
                input = Console.ReadLine();

                //verifies if player wants to exit
                if (input == "EXIT")
                    break;

                //compares the input with available questions to give an awnser
                response = input switch
                {
                    "Who are you?" => "I'm a super advance AI created to " +
                    "awnser your every question.",
                    "What's 2 + 2?" => "4.",
                    "What year are we?" => "We are in 2022.",
                    "Can you buy coca cola everywhere?" => "no, in cuba and" + 
                    " north korea coca cola isn't available.",
                    "What's the meaning of life?" => "42",
                    "witch came first, the egg or the chicken?" => "The egg.",
                    "Is time travel possible?" => "Yes, going closer to the" + 
                    " speed of light makes you travel faster to the future " + 
                    "than normal people on earth.",
                    _ => "Ok maybe im not all knowledgeable.",
                };

                // awnser player
                Console.WriteLine(response);

            }
        }
    }
}
