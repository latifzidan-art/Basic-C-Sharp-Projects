using System;

namespace EmployeeQuittable
{
    // An interface is basically a contract. It lists what a class has to
    // provide without saying anything about how it should work. The capital I
    // at the front of the name is just the naming convention C# uses so you
    // can tell at a glance that something is an interface.
    interface IQuittable
    {
        // The void method the assignment asks for. There is no body here and
        // no public keyword, and both of those are on purpose: interface
        // members are public automatically, and the class that implements the
        // interface is the one that decides what actually happens inside.
        void Quit();
    }
}
