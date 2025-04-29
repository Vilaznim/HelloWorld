using System;

namespace Day5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Guess-the-Number!");
            PlayGame();
        }

        // Core game loop
        static void PlayGame()
        {
            var rand = new Random();
            int secret = rand.Next(1, 51);  // 1–50
            int guess;
            int attempts = 0;
            int hints = -1;

            Console.WriteLine("I have a number between 1 and 50.");
            do
            {
                Console.Write("Your guess: ");
                string input = Console.ReadLine();

                // TryParsePositive uses an out parameter
                if (!TryParsePositive(input, out guess))
                {
                    Console.WriteLine("Please enter a valid positive integer.");
                    continue;
                }

                
                hints++;
                attempts++;
                if (guess < secret)        Console.WriteLine("Too low!");
                else if (guess > secret)   Console.WriteLine("Too high!");
                else                       Console.WriteLine("Correct!");
            }
            
            while (guess != secret);

            Console.WriteLine($"You got it in {attempts} attempts and {hints} hints!");
        }

        // from earlier: parse & validate
        static bool TryParsePositive(string input, out int result)
        {
            if (int.TryParse(input, out int tmp) && tmp > 0)
            {
                result = tmp;
                return true;
            }
            result = 0;
            return false;
        }
    }
}
