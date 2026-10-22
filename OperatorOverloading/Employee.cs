using System;

namespace OperatorOverloading
{
    // The Employee class. Normally comparing two objects with == only asks
    // "are these the exact same object in memory?", so two separate employees
    // would never come back equal. The operators further down change that so
    // the comparison looks at the Id property instead.
    class Employee
    {
        // The three properties the assignment asks for. The "get; set;" makes
        // these auto-properties, so C# builds the hidden storage for me.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overloading the == operator. It has to be public and static, and it
        // takes the two things being compared as its parameters: whatever is
        // on the left of the == and whatever is on the right.
        public static bool operator ==(Employee left, Employee right)
        {
            // ReferenceEquals is used here instead of == on purpose. Writing
            // "left == null" inside the == operator would call this very
            // method again, and again, and again, until the program crashes
            // with a stack overflow. ReferenceEquals does the null check
            // without triggering the operator.
            if (ReferenceEquals(left, null) && ReferenceEquals(right, null))
            {
                // Both sides are null, and two nothings count as the same
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                // Only one side is null, so they cannot possibly match
                return false;
            }

            // Both sides are real employees, so the actual comparison happens:
            // they are equal if, and only if, their Id properties match.
            return left.Id == right.Id;
        }

        // Comparison operators must be overloaded in pairs, so != has to be
        // written too. The compiler refuses to build the file with only one
        // of them. This one just flips whatever == decided.
        public static bool operator !=(Employee left, Employee right)
        {
            return !(left == right);
        }

        // Once == is overloaded, the compiler warns that Equals should be
        // overridden to match, otherwise employeeOne == employeeTwo and
        // employeeOne.Equals(employeeTwo) could disagree with each other.
        public override bool Equals(object obj)
        {
            // "as" tries to treat the incoming object as an Employee and
            // quietly hands back null if it is something else entirely
            Employee other = obj as Employee;

            if (ReferenceEquals(other, null))
            {
                // It was not an Employee at all, so it cannot be equal
                return false;
            }

            // Same rule as the == operator: compare on Id
            return this.Id == other.Id;
        }

        // GetHashCode has to be overridden alongside Equals. Things like
        // dictionaries use this number to group objects, so two employees
        // that count as equal must also produce the same hash code. Since
        // equality is based on Id, the hash code is built from Id too.
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        // Not required by the assignment, just makes the printouts in
        // Program.cs easier to read than the default class name
        public override string ToString()
        {
            return FirstName + " " + LastName + " (Id " + Id + ")";
        }
    }
}
