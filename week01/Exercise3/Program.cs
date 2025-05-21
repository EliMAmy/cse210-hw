using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        string again = "yes";
        int tries = 0;

        while (again == "yes")
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int yourGuess = int.Parse(guess);

            if (yourGuess > magicNumber)
            {
                Console.WriteLine("Lower");
                tries = tries + 1;

            }
            else if (yourGuess < magicNumber)
            {
                Console.WriteLine("Higher");
                tries = tries + 1;

            }
            else if (yourGuess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                tries = tries + 1;
                Console.WriteLine($"The number of tries is {tries}");
                Console.Write("Do you want to play again? yes/no: ");
                string playAgain = Console.ReadLine();
                if (playAgain == "yes")
                {
                    Random randomGeneratornew = new Random();
                    int newNumber = randomGeneratornew.Next(1, 50);
                    tries = 0;
                    again = "yes";
                }
                else
                {
                    again = "no";
                }

                }
            }
        Console.WriteLine($"The number of tries is {tries}");
    }
        
    }
