using System;

namespace APT1030C_Coding_Challenge
{
    public class JumpingDistanceChallenge
    {
        public static void Run()
        {
            // Welcome message
            Console.WriteLine("Welcome to the Jumping Distance Challenge!");

            while (true)
            {
                // Get user input for starting position, target position, and distance per jump
                Console.WriteLine("Enter the starting position (X):");
                if (!int.TryParse(Console.ReadLine(), out int X))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    continue;
                }

                Console.WriteLine("Enter the target position (Y):");
                if (!int.TryParse(Console.ReadLine(), out int Y))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    continue;
                }

                Console.WriteLine("Enter the distance per jump (D):");
                if (!int.TryParse(Console.ReadLine(), out int D) || D <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer for the jump distance.");
                    continue;
                }

                int jumpProgress = X;
                int count = 0;

                // Simulate jumps
                Console.WriteLine($"Starting the jump from position {X} to reach the target position {Y}.");
                while (jumpProgress < Y)
                {
                    jumpProgress += D; // Make a jump
                    count++; // Increment the jump count
                    Console.WriteLine($"Jump {count}: Current position is {jumpProgress}.");
                }

                // Output the total number of jumps
                Console.WriteLine($"Congratulations! You reached or exceeded the target position in {count} jumps.");

                // Ask the user if they want to play again
                Console.WriteLine("Would you like to play again? (yes/no)");
                string playAgain = Console.ReadLine()?.ToLower();

                if (playAgain != "yes")
                {
                    Console.WriteLine("Thank you for playing! Goodbye.");
                    break; // Exit the loop and end the game
                }
            }

            Console.ReadKey();
        }
    }
}
