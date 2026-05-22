using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the mandatory welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for weight and convert input string to integer
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Check if weight exceeds 50lbs
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End the program immediately
            }

            // Prompt user for dimensions
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // Check if the sum of dimensions exceeds 50
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End the program immediately
            }

            // Calculate the quote: (Width * Height * Length * Weight) / 100
            // We use decimal to ensure currency precision
            decimal quote = (decimal)(width * height * length * weight) / 100;

            // Display the final quote formatted as currency
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
            Console.WriteLine("Thank you!");

            // Keep console open until a key is pressed
            Console.ReadLine();
        }
    }
}

