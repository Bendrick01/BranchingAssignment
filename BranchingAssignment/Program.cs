using System;

class Program
{
    static void Main()
    {
        // Display the welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user for package weight
        Console.WriteLine("Please enter the package weight:");
        int weight = Convert.ToInt32(Console.ReadLine());

        // Check if weight is greater than 50
        if (weight > 50)
        {
            // Display error message and end the program
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Prompt user for package width
        Console.WriteLine("Please enter the package width:");
        int width = Convert.ToInt32(Console.ReadLine());

        // Prompt user for package height
        Console.WriteLine("Please enter the package height:");
        int height = Convert.ToInt32(Console.ReadLine());

        // Prompt user for package length
        Console.WriteLine("Please enter the package length:");
        int length = Convert.ToInt32(Console.ReadLine());

        // Calculate total dimensions
        int dimensionsTotal = width + height + length;

        // Check if dimensions total is greater than 50
        if (dimensionsTotal > 50)
        {
            // Display error message and end the program
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate quote based on dimensions and weight
        decimal quote = (width * height * length * weight) / 100.0m;

        // Display the quote to the user as a dollar amount
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

        // Display thank you message
        Console.WriteLine("Thank you!");
    }
}

