namespace APT1030C_Coding_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a challenge to run:");
            Console.WriteLine("1. Increment and Decrement Challenge");
            Console.WriteLine("2. Converting to Celsius Challenge");
            Console.WriteLine("3. Random Dice Rolls Challenge");
            Console.WriteLine("4. Subscription Discount Challenge");
            Console.WriteLine("5. String Reversal Challenge");
            Console.WriteLine("6. HashSet Unique Absolute Values Challenge");
            Console.WriteLine("7. Jumping Distance Challenge");
            Console.WriteLine("8. Merge Two Sorted Linked Lists Challenge");
            Console.WriteLine("9. Two Sum Challenge");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    IncrementDecrementChallenge.Run();
                    break;
                case "2":
                    ConvertingToCelsiusChallenge.Run();
                    break;
                case "3":
                    RandomDiceRollsChallenge.Run();
                    break;
                case "4":
                    SubscriptionDiscountChallenge.Run();
                    break;
                case "5":
                    StringReversalChallenge.Run();
                    break;
                case "6":
                    HashSetUniqueAbsoluteValuesChallenge.Run();
                    break;
                case "7":
                    JumpingDistanceChallenge.Run();
                    break;
                case "8":
                    MergeTwoSortedLinkedListsChallenge.Run();
                    break;
                case "9":
                    TwoSumChallenge.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.ReadKey();
        }
    }
}
