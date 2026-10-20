# Basic C# Projects

This is the central repository for the coding projects I build during my Basic C# course at The Tech Academy.

As I work through the course I'll push each assignment and challenge here from my local machine, so everything stays in one place and this repo shows my progress over time. It's also part of my online portfolio, so nothing gets deleted as I go — every project stays up where it can be reviewed.

🔗 **My portfolio website:** https://latifzidan-art.github.io/Portfolio/

---

## What this repository will contain

Each project will live in its own folder. Going by what the course covers, I expect this to include:

- **C# fundamentals** — variables, data types, operators, and type conversion
- **Control flow** — if/else statements, switch statements, for and while loops
- **Methods** — writing my own methods, parameters, return values
- **Collections** — arrays and lists, and looping through them
- **Object oriented programming** — classes, objects, properties, constructors, inheritance
- **Exception handling** — try/catch blocks and dealing with bad input instead of crashing
- **Console applications** — small programs that run in the terminal
- **Web projects in Visual Studio** — pages built with ASP.NET, along with the HTML, CSS and JavaScript that goes with them

I'll add each one to the list below as I finish it.

## Projects so far

### 1. Package Express
A console app that works out a shipping quote for a package. It asks for the weight and then the width, height and length. If the package weighs more than 50 it stops and says it's too heavy, and if the three measurements add up to more than 50 it stops and says it's too big. Otherwise it multiplies the three dimensions together, multiplies that by the weight, divides by 100, and prints the result as a dollar amount.

- **Code:** [PackageExpress/Program.cs](PackageExpress/Program.cs)

### 2. Method Parameters
A console app built around a class with a void method that takes two integers. The method squares the first number and displays the second one. `Main()` creates an object from the class and calls the method twice — once passing the numbers in order, and once naming each parameter so the order no longer matters.

- **Code:** [MethodParameters/Program.cs](MethodParameters/Program.cs)

### 3. Employee and the IQuittable Interface
An interface called `IQuittable` that defines a single void `Quit()` method, an `Employee` class that implements it, and a demonstration of polymorphism in `Main()`. The employee object is held in a variable declared as the interface type rather than as an `Employee`, and calling `Quit()` on it runs Employee's version of the method.

- **Code:** [EmployeeQuittable](EmployeeQuittable) — `IQuittable.cs`, `Employee.cs`, `Program.cs`

---

## My other repositories

- [Portfolio](https://github.com/latifzidan-art/Portfolio) — my portfolio website, built with HTML, CSS and JavaScript
- [JavaScript-Projects](https://github.com/latifzidan-art/JavaScript-Projects) — everything from my JavaScript course
- [HTML-and-CSS-Projects](https://github.com/latifzidan-art/HTML-and-CSS-Projects) — everything from my HTML and CSS course
- [The-Tech-Academy-Projects](https://github.com/latifzidan-art/The-Tech-Academy-Projects) — my version control course challenges

---

Built by Abdalatif Zidan while learning software development.
