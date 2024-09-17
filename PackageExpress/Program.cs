using System;

namespace PackageExpress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // 2. Prompt user for package weight
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            // 3. Check if the weight exceeds the limit
            if (weight > 50)
            {
                // If weight is greater than 50, display error message and exit
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // 4. Prompt user for package width
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            // 5. Prompt user for package height
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            // 6. Prompt user for package length
            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // 7. Check if the total dimensions exceed the limit
            if ((width + height + length) > 50)
            {
                // If total dimensions are greater than 50, display error message and exit
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // 8. Calculate shipping quote (dimensions * weight / 100)
            double quote = (width * height * length * weight) / 100;

            // 9. Display the quote to the user
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));

            // 10. Thank you message
            Console.WriteLine("Thank you!");

            Console.Read();
        }
    }
}
