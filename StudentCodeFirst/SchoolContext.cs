using System;
using System.Data.Entity;

namespace StudentCodeFirst
{
    // The context is the bridge between my classes and the actual database.
    // Inheriting from DbContext is what hands me saving, querying and the
    // ability to create the database in the first place.
    public class SchoolContext : DbContext
    {
        // Passing the name of the connection string from App.config tells
        // Entity Framework where to build the database. Without this it
        // would guess a LocalDB name based on the full class name.
        public SchoolContext() : base("name=SchoolContext")
        {
        }

        // Each DbSet turns into a table. DbSet<Student> becomes a table
        // called Students, and DbSet<Standard> becomes Standards. These
        // are also what I use to add and query rows in code.
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
    }
}
