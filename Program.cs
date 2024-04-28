using System;
using System.Diagnostics;
namespace MasterMind
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.Title = "Master Mind";
                Console.WriteLine("Hello, Friend! Wellcome to The Game\n" +
                    "Game Guide : The computer will choose a number randomly, you have 10 chances to guess the number chosen by the computer."
                    + "Let's go !");
                Console.WriteLine("Color Guide :");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Green color: Your guessed number is correct and in its right place.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Yellow color: Your guessed number is correct and in the wrong place, move your number.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Red color: Your guessed number is incorrect.");
                Console.ResetColor();
                Console.WriteLine("Choose your game level: 1=> Easy(3_Digit) 2=> Medium(4_Digit) 3=> Hard(5_Digit)");
                Random random = new Random();
                int counter = 0, maxCount = 10;
                double minValue = 10;
                int digit = 3;
                try
                {
                    int level = int.Parse(Console.ReadLine());
                    while (true)
                    {
                        if (level == 1)
                        {
                            Console.WriteLine($"You chose the easy level, the guess number is {digit} digits.");
                            minValue = Math.Pow(minValue, 2);
                        }
                        else if (level == 2)
                        {
                            Console.WriteLine($"You chose the medium level, the guess number is {digit + 1} digits.");
                            minValue = Math.Pow(minValue, 3);
                        }
                        else if (level == 3)
                        {
                            Console.WriteLine($"You chose the hard level, the guess number is {digit + 2} digits.");
                            minValue = Math.Pow(minValue, 4);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The game level you selected is wrong.");
                            Console.ResetColor();
                            break;
                        }
                        int minValueInt = Convert.ToInt32(minValue);
                        string pcGuess = random.Next(minValueInt, minValueInt * 10).ToString();
                        while (true)
                        {
                            counter++;
                            if (counter <= maxCount)
                            {
                                Console.Write($"your {counter} guess :");
                                string userguess = Console.ReadLine();
                                if (userguess.Length != pcGuess.Length)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"Your chosen level {level} , please the number you guess corresponds to the selected level.");
                                    Console.ResetColor();
                                    continue;
                                }
                                if (pcGuess == userguess)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("YOU WIN");
                                    Console.ResetColor();
                                    break;
                                }
                                for (int i = 0; i < pcGuess.Length; i++)
                                {
                                    if (pcGuess[i] == userguess[i])
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(userguess[i]);
                                    }
                                    else if (i == 0)
                                    {
                                        if (pcGuess[0] == userguess[0])
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write(userguess[0]);
                                        }
                                        else if (userguess[0] == pcGuess[1] || userguess[0] == pcGuess[2])
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write(userguess[0]);
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write(userguess[0]);
                                        }
                                    }
                                    else if (i == 1)
                                    {
                                        if (userguess[1] == pcGuess[1])
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write(userguess[1]);
                                        }
                                        else if (userguess[1] == pcGuess[0] || userguess[1] == pcGuess[2])
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write(userguess[1]);
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write(userguess[1]);
                                        }
                                    }
                                    else if (i == 2)
                                    {
                                        if (userguess[2] == pcGuess[2])
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write(userguess[2]);
                                        }
                                        else if (userguess[2] == pcGuess[0] || userguess[2] == pcGuess[1])
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write(userguess[2]);
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write(userguess[2]);
                                        }
                                    }
                                    else if (i == 3)
                                    {
                                        if (userguess[3] == pcGuess[3])
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write(userguess[3]);
                                        }
                                        else if (userguess[3] == pcGuess[0] || userguess[3] == pcGuess[1] || userguess[3] == pcGuess[2] || userguess[3] == pcGuess[4])
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write(userguess[3]);
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write(userguess[3]);
                                        }
                                    }
                                    else if (i == 4)
                                    {
                                        if (userguess[4] == pcGuess[4])
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write(userguess[4]);
                                        }
                                        else if (userguess[4] == pcGuess[0] || userguess[4] == pcGuess[1] || userguess[4] == pcGuess[2] || userguess[4] == pcGuess[3])
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write(userguess[4]);
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write(userguess[4]);
                                        }
                                    }
                                }
                                Console.ResetColor();
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"YOU LOST");
                                Console.ResetColor();
                                break;
                            }
                        }
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (ex.GetType() == typeof(FormatException))
                        Console.WriteLine("The value entered is invalid and you must enter your chosen level as a number!");
                    else if (ex.GetType() == typeof(OverflowException))
                        Console.WriteLine("The entered number is invalid!");
                    else
                        Console.WriteLine("An error has occurred!");
                    Console.ResetColor();
                }
                Console.Write(" If you want to play again press 1 and otherwise press AnyKey : ");
                var playAgain = Console.ReadLine();
                if (playAgain == "1")
                    continue;
                else
                    break;
            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nThank you for being with me, hope to see you again... BYE *_* ");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
