using System;
using System.ComponentModel;

namespace ConsoleMastermind
{
    class Mastermind
    {
        public static void RunMastermind()
        {
            int codeLength = 0;
            int guessCount = 0;
            bool success = false;
            while (!success)
            {
                Console.WriteLine("Enter the desired code length:");
                success = int.TryParse(Console.ReadLine(), out codeLength);
                if (!success || codeLength < 1)
                {
                    success = false;
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            success = false;
            while (!success)
            {
                Console.WriteLine("Enter the number of guesses you would like to have:");
                success = int.TryParse(Console.ReadLine(), out guessCount);
                if (!success || guessCount < 1)
                {
                    success = false;
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            Random random = new();
            int[] secretCode = new int[codeLength];

            for (int i = 0; i < codeLength; i++)
            {
                secretCode[i] = random.Next(1, 9);
            }

            _ = new int[codeLength];
            bool isCorrect = false;
            Console.WriteLine($"The Secret Code Has Been Set with a length of {codeLength}, you have {guessCount} attempts to try and crack it!!!");
            while (guessCount > 0)
            {

                bool[] redVisited = new bool[codeLength];
                bool[] whiteVisited = new bool[codeLength];
                bool validCode = true;
                Console.WriteLine("Enter your guess for the secret code on one line separated by spaces:");
                string[] input = Console.ReadLine().Split(' ');


                int[] userGuess = new int[input.Length];

                if (userGuess.Length == codeLength)
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (!int.TryParse(input[i], out userGuess[i]) || userGuess[i] < 1 || userGuess[i] > 8)
                        {
                            Console.WriteLine("Invalid input. Please enter a number between 1 and 8.");
                            i = input.Length;
                            validCode = false;
                        }

                    }

                    int redPegs = 0, whitePegs = 0;
                    for (int i = 0; i < codeLength; i++)
                    {
                        if (userGuess[i] == secretCode[i])
                        {
                            redPegs++;
                            redVisited[i] = true;
                            continue;
                        }
                    }
                    for (int i = 0; i < codeLength; i++)
                    {
                        if (redVisited[i])
                        {
                            continue;
                        }

                        for (int j = 0; j < secretCode.Length; j++)
                        {
                            if (j == i)
                            {
                                continue;
                            }


                            if (!redVisited[j] && !whiteVisited[j] && secretCode[j] == userGuess[i])
                            {
                                whitePegs++;
                                whiteVisited[j] = true;
                                break;
                            }
                        }
                    }

                    if (redPegs == secretCode.Length)
                    {
                        Console.WriteLine("\nCongratulations! You guessed the secret code correctly.\n");
                        RevealSecret();
                        break;
                    }

                    else
                    {
                        if (validCode)
                        {
                            guessCount--;
                            Console.WriteLine($"You got {redPegs} red peg(s) and {whitePegs} white peg(s)\n");
                            Console.WriteLine($"You have {guessCount} guess(es) remaining\n");
                        }

                        if (guessCount == 0 && !isCorrect)
                        {
                            Console.WriteLine("You lose! Better luck next time!");
                            RevealSecret();
                            break;
                        }
                    }
                }
            }
            void RevealSecret()
            {
                Console.Write("The secret code was: ");
                foreach (int i in secretCode)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        static void Main(string[] args)
        {
            RunMastermind();
        } // end main()
    }
}


