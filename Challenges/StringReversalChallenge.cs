using System;

namespace APT1030C_Coding_Challenge
{
    public class StringReversalChallenge
    {
        public static void Run()
        {
            // Prompt the user for input
            Console.WriteLine("Welcome to the String Reversal Challenge!");
            Console.Write("Enter a string to reverse: ");
            string userInput = Console.ReadLine();

            // Check if user input is empty or null
            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Invalid input. Please enter a non-empty string.");
                return;
            }

            // Prompt the user to choose an option
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Reverse the entire string");
            Console.WriteLine("2. Reverse each word in the string");
            Console.Write("Enter your choice (1 or 2): ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || (choice != 1 && choice != 2))
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                return;
            }

            // Process based on the user's choice
            if (choice == 1)
            {
                // Reverse the entire string
                string reversedString = ReverseString(userInput);
                Console.WriteLine("Reversed string: " + reversedString);
            }
            else if (choice == 2)
            {
                // Reverse each word in the string
                string reversedWords = ReverseWords(userInput);
                Console.WriteLine("String with each word reversed: " + reversedWords);
            }

            Console.ReadKey();
        }

        private static string ReverseString(string s)
        {
            // Convert the string to a character array
            char[] charArray = s.ToCharArray();

            // Reverse the character array
            Array.Reverse(charArray);

            // Create a new string from the reversed character array
            return new string(charArray);
        }

        private static string ReverseWords(string s)
        {
            // Split the string into words using space as the delimiter
            string[] words = s.Split(' ');

            // Reverse each word in the array
            for (int i = 0; i < words.Length; i++)
            {
                char[] wordArray = words[i].ToCharArray();
                Array.Reverse(wordArray);
                words[i] = new string(wordArray);
            }

            // Join the reversed words back into a single string
            return string.Join(" ", words);
        }
    }
}
