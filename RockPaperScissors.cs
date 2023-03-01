using System;
using System.Drawing;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {

        static void Main(string[] args)
        {

            {

                bool isValid = true;

                while (isValid)
                {
                    RockPaperScissorsMethod();

                    string cmd = string.Empty;

                    while (cmd != "y")
                    {

                        cmd = Console.ReadLine().ToLower();
                        Console.WriteLine();

                        if (cmd == "y")
                        {
                            continue;
                        }

                        else if (cmd == "n")
                        {
                            isValid = false;
                            Environment.Exit(0);
                        }

                        else
                        {
                            while (cmd != "y" && cmd != "n")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Invalid Input. Try Again...");
                                Console.ResetColor();

                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.Write($"\nAnother Game?\n[y]es or [n]o");
                                Console.ResetColor();
                                Console.WriteLine();
                                break;

                            }

                        }
                    }

                }

            }
        }

        private static void RockPaperScissorsMethod()
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Choose [r]ock, [p]aper or [s]scissors: ");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            string playerMove = Console.ReadLine().ToLower();
            Console.ResetColor();

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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nInvalid Input. Try Again...");
                Console.ResetColor();

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write($"\nAnother Game?\n[y]es or [n]o\n");
                Console.ResetColor();

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
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"\nThe Computer chose: {computerMove}.\n");
            Console.ResetColor();

            if ((playerMove == Rock && computerMove == Scissors) ||
                (playerMove == Paper && computerMove == Rock) ||
                (playerMove == Scissors && computerMove == Paper))
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("You Win!");
                Console.ResetColor();
            }

            else if ((playerMove == Rock && computerMove == Paper) ||
                (playerMove == Paper && computerMove == Scissors) ||
                (playerMove == Scissors && computerMove == Rock))
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("You Lose!");
                Console.ResetColor();
            }

            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("This Game Was A Draw!");
                Console.ResetColor();
            }

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write($"\nAnother Game?\n[y]es or [n]o\n");
            Console.ResetColor();
        }
    }
}
