using System;

namespace StudentCodeFirst
{
    // This is a plain C# class, not a database table I drew out first.
    // That is the whole idea behind Code-First: I write the classes, and
    // Entity Framework builds the database to match them.
    public class Student
    {
        // Entity Framework follows naming conventions instead of making me
        // configure everything. A property called Id, or ClassName + Id like
        // this one, is automatically treated as the primary key, and because
        // it is an int it gets set to auto-increment.
        public int StudentID { get; set; }

        // Becomes an nvarchar column in the Students table
        public string StudentName { get; set; }
    }
}
