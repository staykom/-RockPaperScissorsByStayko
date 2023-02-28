using System;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {

            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.Write("Choose [r]ock, [p]aper or [s]scissors: ");
            string playerMove = Console.ReadLine().ToLower();

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = Rock;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = Paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = Scissors;
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again...");
                return;
            }
            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);

            string computerMove = "";

            switch (computerRandomNumber)
            {
                case 1:
                    computerMove = Rock;
                    break;
                case 2:
                    computerMove = Paper;
                    break;
                case 3:
                    computerMove = Scissors;
                    break;

            }
            Console.WriteLine($"The Computer chose: {computerMove}.");

            if ((playerMove == Rock && computerMove == Scissors) ||
                (playerMove == Paper && computerMove == Rock) ||
                (playerMove == Scissors && computerMove == Paper))
            {
                Console.WriteLine("You Win!");
            }

            else if ((playerMove == Rock && computerMove == Paper) ||
                (playerMove == Paper && computerMove == Scissors) ||
                (playerMove == Scissors && computerMove == Rock))
            {
                Console.WriteLine("You Lose!");
            }

            else 
            {
                Console.WriteLine("This Game Was A Draw!");
            }



        }
    }
}
