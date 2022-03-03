using System;

namespace Exercise19
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration of variables
            string inputHighScore, inputCorrentScore, response;
            string respNew = "New high score!";
            string respKeep = "Keep trying.";
            int highScore, correntScore;

            //read input of player
            Console.WriteLine("Write (as intergers) the highscore of the game" +
            " and the players corrent score:");
            inputHighScore = Console.ReadLine();
            inputCorrentScore = Console.ReadLine();

            //check high score
            highScore = int.Parse(inputHighScore);
            correntScore = int.Parse(inputCorrentScore);
            response = (correntScore > highScore) ? respNew : respKeep;

            //print correct response
            Console.WriteLine(response);

        }
    }
}
