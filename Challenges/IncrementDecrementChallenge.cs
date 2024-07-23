namespace APT1030C_Coding_Challenge
{
    public class IncrementDecrementChallenge
    {
        public static void Run()
        {
            // Display a menu to the user
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Increment a number");
            Console.WriteLine("2. Decrement a number");
            Console.WriteLine("3. Exit");

            // Read the user's choice
            if (!int.TryParse(Console.ReadLine(), out int choice) || (choice < 1 || choice > 3))
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
                return;
            }

            // Handle the user's choice
            switch (choice)
            {
                case 1:
                    HandleIncrement();
                    break;

                case 2:
                    HandleDecrement();
                    break;

                case 3:
                    Console.WriteLine("Exiting...");
                    return;
            }

            Console.ReadKey();
        }

        private static void HandleIncrement()
        {
            // Handling user input for increment
            Console.WriteLine("Enter a number to increment:");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                // Increment the user's number
                userInput++;
                Console.WriteLine("Your number after increment: " + userInput);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        private static void HandleDecrement()
        {
            // Handling user input for decrement
            Console.WriteLine("Enter a number to decrement:");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                // Decrement the user's number
                userInput--;
                Console.WriteLine("Your number after decrement: " + userInput);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
