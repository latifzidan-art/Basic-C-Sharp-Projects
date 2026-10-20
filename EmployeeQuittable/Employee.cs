using System;

namespace EmployeeQuittable
{
    // The Employee class, now with ": IQuittable" tacked onto the end. That
    // colon is how a class announces it is implementing an interface. Once
    // it's there, the compiler will refuse to build this file until Employee
    // actually supplies a Quit() method.
    class Employee : IQuittable
    {
        // The details belonging to one employee. These are auto-properties,
        // so the "get; set;" gives each one a hidden backing field without me
        // having to write it out myself.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeId { get; set; }

        // A constructor runs automatically the moment a new Employee is made.
        // It takes the three values passed in and copies them into the
        // properties above, so an Employee can never be created half-empty.
        public Employee(string firstName, string lastName, int employeeId)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeId = employeeId;
        }

        // Joins the two name properties together with a space in between and
        // hands the result back as one string.
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        // This is the method the IQuittable interface demanded. It has to be
        // public, otherwise it wouldn't count as fulfilling the contract and
        // the code would not compile. What it does inside is up to me, so I
        // made it print a short resignation notice.
        public void Quit()
        {
            Console.WriteLine(GetFullName() + " (employee #" + EmployeeId + ") has handed in their resignation.");
            Console.WriteLine("Their last day will be two weeks from today.");
        }
    }
}
