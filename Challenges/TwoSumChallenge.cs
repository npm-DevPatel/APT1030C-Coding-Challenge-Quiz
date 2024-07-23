using System;
using System.Linq;

namespace APT1030C_Coding_Challenge
{
    public class TwoSumChallenge
    {
        public static void Run()
        {
            // Create a Random object
            Random random = new Random();

            // Generate a random array of numbers and a target sum
            int[] nums = GenerateRandomArray(10, 1, 20);
            int target = random.Next(10, 30);

            Console.WriteLine("Welcome to the Two Sum Game!");
            Console.WriteLine($"Target Sum: {target}");
            Console.WriteLine("Try to guess two numbers from the array that add up to the target sum.");

            // Display the array for the user
            Console.WriteLine("Array: " + string.Join(", ", nums));

            bool hasGuessedCorrectly = false;
            while (!hasGuessedCorrectly)
            {
                // Get user input
                Console.Write("Enter the first number: ");
                if (!int.TryParse(Console.ReadLine(), out int guess1) || !nums.Contains(guess1))
                {
                    Console.WriteLine("Invalid number. Try again.");
                    continue;
                }

                Console.Write("Enter the second number: ");
                if (!int.TryParse(Console.ReadLine(), out int guess2) || !nums.Contains(guess2) || guess2 == guess1)
                {
                    Console.WriteLine("Invalid number. Try again.");
                    continue;
                }

                // Check if the sum of the two guessed numbers matches the target
                if (guess1 + guess2 == target)
                {
                    Console.WriteLine($"Congratulations! The numbers {guess1} and {guess2} add up to {target}.");
                    hasGuessedCorrectly = true;
                }
                else
                {
                    Console.WriteLine("Wrong guess. Try again.");
                }
            }

            Console.ReadKey();
        }

        private static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }
            return array;
        }
    }
}
