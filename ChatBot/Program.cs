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

                //verity's if player wants to exit
                if (input == "EXIT")
                    break;

                //compares the input with available questions to give an awnser
                response = input switch
                {
                    "Who are you?" => "I'm a super advance AI created to " +
                    "awnser your every question.",

                    _ => "Ok maybe im not all knowledgeable.",
                };

                // awnser player
                Console.WriteLine(response);

            }
        }
    }
}
