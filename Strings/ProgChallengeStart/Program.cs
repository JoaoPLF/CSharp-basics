using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            int guess = -1;
            int attempts = 0;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            do {
                string guessStr = Console.ReadLine();

                try {
                    guess = int.Parse(guessStr);
                    attempts += 1;

                    if (guess == -1) {
                        Console.WriteLine($"Too bad, I was thinking of {theNumber}.");
                        break;
                    }

                    if (guess == theNumber) {
                        Console.WriteLine($"You got it in {attempts} guesses.");
                    }
                    else {
                        Console.WriteLine("{0} than that.", guess > theNumber ? "Lower" : "Higher");
                    }
                }
                catch {
                    Console.WriteLine("That doesn't look like a number. Try again.");
                }
            } while (guess != theNumber);
        }
    }
}
