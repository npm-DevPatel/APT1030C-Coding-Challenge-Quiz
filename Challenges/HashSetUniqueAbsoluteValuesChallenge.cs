namespace APT1030C_Coding_Challenge
{
    public class HashSetUniqueAbsoluteValuesChallenge
    {
        public static void Run()
        {
            // Prompt user to enter the number of elements
            Console.WriteLine("Enter the number of elements:");
            if (!int.TryParse(Console.ReadLine(), out int numberOfElements) || numberOfElements <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            // Create an array to store the user-input numbers
            int[] numbers = new int[numberOfElements];

            // Prompt user to enter each element
            Console.WriteLine("Enter the numbers (one per line):");
            for (int i = 0; i < numberOfElements; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--; // Retry the current index
                }
            }

            // Create a HashSet to store unique absolute values
            HashSet<int> uniqueAbsValues = new HashSet<int>();

            // Iterate through the array and add absolute values to the HashSet
            foreach (int number in numbers)
            {
                uniqueAbsValues.Add(Math.Abs(number));
            }

            // Output the number of unique absolute values
            Console.WriteLine("Number of unique absolute values: " + uniqueAbsValues.Count);

            // Output the unique absolute values
            Console.WriteLine("Unique absolute values:");
            foreach (int value in uniqueAbsValues)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
