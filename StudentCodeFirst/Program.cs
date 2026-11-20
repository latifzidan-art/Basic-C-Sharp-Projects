using System;
using System.Linq;

namespace StudentCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entity Framework Code-First demo");
            Console.WriteLine();

            // "using" makes sure the context is closed and its database
            // connection released when this block finishes, even if
            // something throws partway through.
            using (var context = new SchoolContext())
            {
                // Nothing has touched the database yet. Entity Framework
                // creates SchoolDB on the first operation that actually
                // needs it, building the Students and Standards tables
                // from my classes.
                Console.WriteLine("Connecting, and creating the database if it is not there yet...");

                // Make the one student the assignment asks for. StudentID is
                // left alone on purpose, because the database fills it in.
                Student student = new Student();
                student.StudentName = "Abdalatif Zidan";

                // Add() only stages the student in memory and marks it as
                // something waiting to be inserted
                context.Students.Add(student);

                // SaveChanges() is the line that does the real work. It opens
                // the connection, creates the database if this is the first
                // run, writes the INSERT, and copies the new StudentID back
                // into my object.
                context.SaveChanges();

                Console.WriteLine("Student saved.");
                Console.WriteLine();

                // Read the students back out to prove the row really landed
                // in the database rather than just sitting in memory
                Console.WriteLine("Students currently in the database:");
                foreach (Student s in context.Students.ToList())
                {
                    Console.WriteLine("  StudentID " + s.StudentID + ": " + s.StudentName);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to close.");
            Console.ReadLine();
        }
    }
}
