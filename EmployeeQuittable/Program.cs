using System;

namespace EmployeeQuittable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Heading so it's clear what the program is showing
            Console.WriteLine("Interface and Polymorphism Demonstration");
            Console.WriteLine();

            // THIS LINE IS THE POLYMORPHISM.
            // The variable on the left is declared as IQuittable, which is the
            // INTERFACE type, but the object being built on the right is an
            // Employee. C# allows this because Employee implements IQuittable,
            // so an Employee genuinely is a kind of IQuittable.
            IQuittable quittableEmployee = new Employee("Jordan", "Reyes", 4815);

            // Calling Quit() through that interface variable. At runtime C#
            // checks what the object really is, finds an Employee, and runs
            // Employee's version of Quit(). The variable's type decided what
            // could be called; the object's real type decided what ran.
            quittableEmployee.Quit();
            Console.WriteLine();

            // Worth showing what using the interface type costs you. Through
            // quittableEmployee only Quit() can be reached, because Quit() is
            // the one and only thing IQuittable promises. GetFullName()
            // belongs to Employee, so getting at it means casting back to
            // Employee first. Uncommenting the next line would not compile:
            // quittableEmployee.GetFullName();
            Employee backToEmployee = (Employee)quittableEmployee;

            Console.WriteLine("Cast back to Employee to reach a member the interface does not define:");
            Console.WriteLine("Full name is " + backToEmployee.GetFullName() + ".");
            Console.WriteLine();

            // Stops the console window closing the instant the program ends
            Console.WriteLine("Press Enter to close.");
            Console.ReadLine();
        }
    }
}
