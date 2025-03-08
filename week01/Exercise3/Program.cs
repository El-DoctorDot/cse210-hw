using System;

class Program
{
    static void Main(string[] args)
    {   

        Random randomGeneretor = new Random();
        string playAgain;

        do
        {
            int magicNumber = randomGeneretor.Next(1, 100);
            int guess = -1;
        


            while (guess != magicNumber)
            {
                Console.Write(" What is the magic number?  ");
                string input = Console.ReadLine();
                guess = int.Parse(input);

                Console.Write(" What is your guess?");
                string answer = Console.ReadLine();
                guess = int.Parse(answer);

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher!");
                }
                else if (guess > magicNumber)
                {   
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            
            Console.WriteLine("Do you want to play again? (yes/no)");
            playAgain = Console.ReadLine();

        } while (playAgain == "yes");

        Console.WriteLine("Goodbye!");
    }
}