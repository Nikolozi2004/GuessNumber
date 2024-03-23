using System;

class GuessingGame
{
    static void Main(string[] args)
    {
        var rand = new Random();
        var secretNumber = rand.Next(1, 101);
        var attempts = 0;
        var correctGuess = false;

        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("I've picked a number between 1 and 100. Can you guess it?");

        while (!correctGuess)
        {
            Console.Write("Enter your guess: ");
            if (!int.TryParse(Console.ReadLine(), out int guess))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            attempts++;

            int difference = guess - secretNumber;

            if (Math.Abs(difference) <= 10)
            {
                Console.WriteLine("You're very close to the number!");
            }

            if (guess == secretNumber)
            {
                correctGuess = true;
            }
            else if (difference < 0)
            {
                Console.WriteLine("High! Try again.");
            }
            else
            {
                Console.WriteLine("Low! Try again.");
            }
        }

        Console.WriteLine($"Congratulations! You guessed it in {attempts} attempts!");
    }
}
