using System;
using System.Collections.Generic;

namespace StudentCodeFirst
{
    // A Standard is the class or grade a student is in. It is here because
    // it shows how Code-First handles a relationship between two tables.
    public class Standard
    {
        // Primary key again, picked up by the same naming convention
        public int StandardId { get; set; }

        public string StandardName { get; set; }

        // This is a navigation property. One Standard holds many Students,
        // so Entity Framework works out there is a one-to-many relationship
        // and puts a Standard_StandardId foreign key column on the Students
        // table without me writing any SQL for it.
        public IList<Student> Students { get; set; }
    }
}
