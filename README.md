# C# Projects

These are the projects I built while working through the Basic C# course at The Tech Academy. They start with small console applications covering the fundamentals of the language and move on to object oriented programming and working with a database through Entity Framework.

🔗 **Portfolio website:** https://latifzidan-art.github.io/Portfolio/

## Projects:

- [Package Express](PackageExpress)
- [Method Parameters](MethodParameters)
- [Employee and IQuittable](EmployeeQuittable)
- [Operator Overloading](OperatorOverloading)
- [Student Database (Code-First)](StudentCodeFirst)

## Package Express

A console application that works out a shipping quote for a package. It asks the user for the weight and then the width, height and length, and refuses the package if it weighs more than 50 or if the three dimensions add up to more than 50. Anything that passes those checks gets priced by multiplying the dimensions together, multiplying that by the weight and dividing by 100, and the result is displayed back as a dollar amount.

## Method Parameters

A console application built around a class containing a void method that takes two integers. The method does a math operation on the first number and displays the second. `Main()` creates an object from the class and calls the method twice, once passing the values in order and once naming each parameter, which shows that named arguments make the order irrelevant.

## Employee and IQuittable

An interface called `IQuittable` that defines a single `Quit()` method, and an `Employee` class that implements it. The interesting part is in `Main()`, where the employee is held in a variable declared as the interface type rather than as an `Employee`. Calling `Quit()` on that variable still runs Employee's version of the method, which is polymorphism in action.

## Operator Overloading

An `Employee` class that overloads the `==` and `!=` operators so two employees count as equal when their Id properties match, rather than only when they are the same object in memory. `Equals` and `GetHashCode` are overridden alongside them so all three stay consistent, and the null checks use `ReferenceEquals` to stop the `==` operator from calling itself in a loop.

## Student Database (Code-First)

A console application that uses Entity Framework 6 and a Code-First workflow. Rather than designing a database and generating classes from it, the plain C# classes come first and Entity Framework builds the tables to match them. `SchoolContext` inherits from `DbContext` and exposes each class as a `DbSet`, and the database is created automatically the first time `SaveChanges()` is called.

## Technical skills gained

- **C# fundamentals** — variables, data types, type conversion, operators, string formatting
- **Control flow** — if/else branching, loops, and validating user input before acting on it
- **Methods** — parameters, return values, void methods, and named arguments
- **Object oriented programming** — classes, objects, constructors, properties, interfaces, inheritance and polymorphism
- **Operator overloading** — overloading comparison operators in pairs, and keeping `Equals` and `GetHashCode` in step with them
- **Entity Framework 6** — Code-First workflow, `DbContext` and `DbSet`, naming conventions, navigation properties and relationships
- **ASP.NET MVC** — models, views and controllers, passing data to a view, and adding business logic to a controller
- **Databases** — connection strings, and reading and writing rows from application code
- **Debugging in Visual Studio** — setting breakpoints, stepping through code with Step Into, and inspecting variables while the program is paused
- **Git and GitHub** — committing work as I go and pushing it to a remote repository

---

## My other repositories

- [Portfolio](https://github.com/latifzidan-art/Portfolio) — my portfolio website, built with HTML, CSS and JavaScript
- [JavaScript-Projects](https://github.com/latifzidan-art/JavaScript-Projects) — everything from my JavaScript course
- [HTML-and-CSS-Projects](https://github.com/latifzidan-art/HTML-and-CSS-Projects) — everything from my HTML and CSS course
- [The-Tech-Academy-Projects](https://github.com/latifzidan-art/The-Tech-Academy-Projects) — my version control course challenges

---

Built by Abdalatif Zidan while learning software development.
