using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operator Overloading Demonstration");
            Console.WriteLine();

            // Instantiate the first Employee and assign values to each of its
            // three properties one at a time.
            Employee employeeOne = new Employee();
            employeeOne.Id = 101;
            employeeOne.FirstName = "Jordan";
            employeeOne.LastName = "Reyes";

            // Instantiate a second Employee. This one deliberately has the
            // SAME Id as the first but a completely different name, which is
            // what proves the overload is really comparing Id and nothing
            // else about the object.
            Employee employeeTwo = new Employee();
            employeeTwo.Id = 101;
            employeeTwo.FirstName = "Alex";
            employeeTwo.LastName = "Carter";

            // A third Employee with a different Id, so the false side of the
            // comparison can be shown as well.
            Employee employeeThree = new Employee();
            employeeThree.Id = 202;
            employeeThree.FirstName = "Sam";
            employeeThree.LastName = "Diallo";

            // Print who is being compared
            Console.WriteLine("Employee one:   " + employeeOne);
            Console.WriteLine("Employee two:   " + employeeTwo);
            Console.WriteLine("Employee three: " + employeeThree);
            Console.WriteLine();

            // These are two separate objects sitting in two different places
            // in memory. Without the overload, == would compare those memory
            // locations and always come back False here.
            Console.WriteLine("Are one and two literally the same object in memory?");
            Console.WriteLine("  ReferenceEquals: " + ReferenceEquals(employeeOne, employeeTwo));
            Console.WriteLine();

            // COMPARING WITH THE OVERLOADED == OPERATOR.
            // Both employees carry Id 101, so this reports True even though
            // their names are different and they are separate objects.
            Console.WriteLine("Comparing employee one and employee two (both Id 101):");
            Console.WriteLine("  employeeOne == employeeTwo  ->  " + (employeeOne == employeeTwo));

            // And the != operator, which should be the exact opposite
            Console.WriteLine("  employeeOne != employeeTwo  ->  " + (employeeOne != employeeTwo));
            Console.WriteLine();

            // Now the same two operators against an employee with a different
            // Id, which flips both results around.
            Console.WriteLine("Comparing employee one and employee three (Id 101 vs 202):");
            Console.WriteLine("  employeeOne == employeeThree  ->  " + (employeeOne == employeeThree));
            Console.WriteLine("  employeeOne != employeeThree  ->  " + (employeeOne != employeeThree));
            Console.WriteLine();

            // Equals was overridden to follow the same rule as ==, so it
            // agrees with the operator rather than contradicting it
            Console.WriteLine("Equals follows the same rule as the == operator:");
            Console.WriteLine("  employeeOne.Equals(employeeTwo)  ->  " + employeeOne.Equals(employeeTwo));
            Console.WriteLine();

            // Null is handled safely instead of crashing
            Employee noEmployee = null;
            Console.WriteLine("Comparing against null does not crash:");
            Console.WriteLine("  employeeOne == null  ->  " + (employeeOne == noEmployee));
            Console.WriteLine();

            // Stops the console window closing the instant the program ends
            Console.WriteLine("Press Enter to close.");
            Console.ReadLine();
        }
    }
}
