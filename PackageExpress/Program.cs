using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // The greeting line the assignment asks for, word for word
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask how heavy the package is
            Console.WriteLine("Please enter the package weight:");

            // Console.ReadLine() gives us back text, so Convert.ToDouble turns it into a
            // number we can actually do math with
            double weight = Convert.ToDouble(Console.ReadLine());

            // Anything heavier than 50 can't be shipped, so tell them and stop right here
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine(); // keeps the window open long enough to read the message
                return;             // return ends Main, and ending Main ends the program
            }

            // Now the three measurements, one question at a time
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // Add the three measurements up to see how big the package is overall
            double totalSize = width + height + length;

            // If those add up to more than 50 the package is too big, so stop here as well
            if (totalSize > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            // Work out the price. Multiply the three dimensions together, multiply that by
            // the weight, then divide the whole thing by 100
            double quote = (width * height * length * weight) / 100;

            // ToString("C") formats a number as currency, so 528 prints as $528.00
            // instead of just 528
            Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("C"));
            Console.WriteLine("Thank you!");

            // Stops the window closing the second the program finishes
            Console.ReadLine();
        }
    }
}
