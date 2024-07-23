namespace APT1030C_Coding_Challenge
{
    public class SubscriptionDiscountChallenge
    {
        public static void Run()
        {
            // Create an instance of the Random class
            Random random = new Random();

            // Generate a random number of days until expiration between 0 and 11
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            // Determine the discount percentage based on the days until expiration
            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired!");
                return; // Exit the program since the subscription is expired
            }
            else if (daysUntilExpiration == 1)
            {
                discountPercentage = 20;
                Console.WriteLine("Your subscription expires within a day!");
            }
            else if (daysUntilExpiration <= 5)
            {
                discountPercentage = 10;
                Console.WriteLine("Your subscription expires in " + daysUntilExpiration + " days.");
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription expires in " + daysUntilExpiration + " days.");
            }
            else
            {
                Console.WriteLine("Your subscription is not expiring soon.");
            }

            // Output the discount information if applicable
            if (daysUntilExpiration > 0 && discountPercentage > 0)
            {
                Console.WriteLine("Renew now and save " + discountPercentage + "%!");
            }
            else if (daysUntilExpiration > 0 && discountPercentage == 0)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }

            Console.ReadKey();
        }
    }
}
