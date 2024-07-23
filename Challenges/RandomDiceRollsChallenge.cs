using System;

namespace APT1030C_Coding_Challenge
{
    public class RandomDiceRollsChallenge
    {
        public static void Run()
        {
            // Create an instance of the Random class
            Random dice = new Random();

            // Prompt the user to set a target score
            Console.WriteLine("Welcome to the Dice Rolling Game!");
            Console.Write("Enter the target score to win: ");
            if (!int.TryParse(Console.ReadLine(), out int targetScore) || targetScore <= 0)
            {
                Console.WriteLine("Invalid target score. Please enter a positive number.");
                return;
            }

            int playerScore = 0;
            int computerScore = 0;

            // Game loop: Continue rolling until one of the players reaches the target score
            while (playerScore < targetScore && computerScore < targetScore)
            {
                // Player's turn
                Console.WriteLine("\nYour turn:");
                playerScore += RollDice(dice);
                Console.WriteLine($"Your current score: {playerScore}");

                // Check if the player reached the target score
                if (playerScore >= targetScore)
                {
                    Console.WriteLine("Congratulations! You reached the target score and won!");
                    break;
                }

                // Computer's turn
                Console.WriteLine("\nComputer's turn:");
                computerScore += RollDice(dice);
                Console.WriteLine($"Computer's current score: {computerScore}");

                // Check if the computer reached the target score
                if (computerScore >= targetScore)
                {
                    Console.WriteLine("The computer reached the target score and won!");
                    break;
                }
            }

            Console.WriteLine($"Final Scores - Player: {playerScore}, Computer: {computerScore}");
            Console.ReadKey();
        }

        private static int RollDice(Random dice)
        {
            // Roll three dice, each producing a number between 1 and 6
            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            // Calculate the total of the dice rolls
            int total = roll1 + roll2 + roll3;

            // Output the dice rolls
            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            // Check if all three dice are the same (triples)
            if (roll1 == roll2 && roll2 == roll3)
            {
                Console.WriteLine("You rolled triples! +6 bonus to total!");
                total += 6;
            }
            // Check if any two dice are the same (doubles)
            else if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }

            return total;
        }
    }
}
