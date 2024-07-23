namespace APT1030C_Coding_Challenge
{
    public class ConvertingToCelsiusChallenge
    {
        public static void Run()
        {
            // Convert a hardcoded Fahrenheit temperature to Celsius
            int fahrenheit1 = 94;
            decimal temperature1 = ((fahrenheit1 - 32) * 5m / 9m);
            Console.WriteLine("The temperature is " + temperature1 + " degrees Celsius");

            // Convert another hardcoded Fahrenheit temperature to Celsius and round the result
            int fahrenheit2 = 94;
            decimal temperature2 = ((fahrenheit2 - 32m) * 5m / 9m);
            Console.WriteLine("The temperature is " + Math.Round(temperature2) + " degrees Celsius");

            // Handling user input for Fahrenheit to Celsius conversion
            Console.WriteLine("Enter a temperature in Fahrenheit to convert to Celsius:");
            if (!int.TryParse(Console.ReadLine(), out int userFahrenheit))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }
            decimal userTemperature = ((userFahrenheit - 32m) * 5m / 9m);
            Console.WriteLine("The temperature is " + userTemperature + " degrees Celsius");
            Console.WriteLine("The temperature rounded is " + Math.Round(userTemperature) + " degrees Celsius");

            Console.ReadKey();
        } 


    } 
}
