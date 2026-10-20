using System;

namespace MethodParameters
{
    // This is the class the assignment asks for. All of the actual work lives
    // in here, and Main() further down just builds one of these and uses it.
    class NumberProcessor
    {
        // A void method hands nothing back to whoever called it. It does its
        // job and prints straight to the screen instead of returning a value.
        // It takes two whole numbers (integers) as its parameters.
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // The math operation on the FIRST integer. I chose to square it,
            // so the number gets multiplied by itself and stored in result.
            int result = firstNumber * firstNumber;

            // Print what the math did, otherwise the first number would be
            // changed behind the scenes and nobody would ever see it
            Console.WriteLine("The first number was " + firstNumber + ", and squared it becomes " + result + ".");

            // Now display the SECOND integer to the screen exactly as it came
            // in. No math gets done to this one, the assignment only asks for
            // it to be shown.
            Console.WriteLine("The second number is " + secondNumber + ".");

            // Blank line so the two calls don't run into each other on screen
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // A heading so it's obvious what the program is doing
            Console.WriteLine("Class and Method Demonstration");
            Console.WriteLine();

            // Instantiate the class. The "new" keyword builds an actual object
            // out of the NumberProcessor blueprint, and the variable called
            // processor is what holds on to that object.
            NumberProcessor processor = new NumberProcessor();

            // FIRST CALL - the two numbers are passed in positionally, which
            // just means by their order. 7 goes into firstNumber because it is
            // written first, and 12 goes into secondNumber.
            Console.WriteLine("Call 1 - passing the numbers in order:");
            processor.ProcessNumbers(7, 12);

            // SECOND CALL - the exact same method, but this time each value is
            // labelled with the parameter name it belongs to. Because they are
            // named, the order stops mattering: secondNumber is written first
            // here, and 25 still ends up in firstNumber where it belongs.
            Console.WriteLine("Call 2 - passing the numbers by parameter name:");
            processor.ProcessNumbers(secondNumber: 40, firstNumber: 25);

            // Stops the console window from closing the instant it finishes
            Console.WriteLine("Press Enter to close.");
            Console.ReadLine();
        }
    }
}
