using System;

namespace guessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter your name");
            string myName = Console.ReadLine();
            Console.WriteLine("Hello {0},", myName);
            Console.ResetColor();

            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Guess a number between 1 and 10"); //1 - 20
                Console.ResetColor();

                while (guess != correctNumber)
                {

                    string userGuess = Console.ReadLine();

                    if (!int.TryParse(userGuess, out guess))
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a number");
                        Console.ResetColor();

                    }

                    guess = Int32.Parse(userGuess);

                    if (guess != correctNumber)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number, try again");
                        Console.ResetColor();

                    }

                    if (guess < correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("You need to go higher");
                        Console.ResetColor();
                    }

                    else if (guess > correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("You need to go lower");
                        Console.ResetColor();
                    }

                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You guessed it right, number {0} is correct", correctNumber);
                Console.WriteLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Would you like to play again: Y or N");
                Console.ResetColor();

                string userAnswer = Console.ReadLine().ToUpper();

                if (userAnswer == "Y")
                {
                    continue;
                }

                else if (userAnswer == "N")
                {
                    return;
                }

                else
                {
                    return;
                }   
                    
            }

        }
    }
}
