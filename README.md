# Object Oriented Design

# Lecture 1: Introduction to C# Console Programming

This lecture introduces the basics of C# console applications, including printing text with Console.WriteLine(), defining and calling static methods, and working with variables (int, string, bool). It also covers string concatenation, type conversion with int.TryParse(), and reading input using Console.ReadLine(). The lecture explains the program structure: namespaces, classes, and the Main method.

*****
# Lab 1: Introduction, Basics, and Beyond

This lab practices foundational C# programming concepts: variables, arithmetic operations, functions, and console input/output. Exercises include calculating values, manipulating strings, and creating reusable functions for simple tasks.

## Project File  
`01.D.Code`

## Tasks

**Task 1: Area of a Rectangle**  
Calculate the area of a rectangle using fixed values for length and width. Demonstrates the use of variables and basic arithmetic.  

**Task 2: User Input for Rectangle**  
Extend the rectangle example by taking length and width values from user input. Shows how to work with `Console.ReadLine()` and type conversion.  

**Task 3: GreetUser Function**  
A function that accepts a name and prints a personalized greeting. Useful for learning functions and string formatting.  

**Task 4: ConcatenateStrings Function**  
A function that combines two strings with a space in between and returns the result. Demonstrates string concatenation and return values.  

**Task 5: SubtractNumbers Function**  
A function that takes an integer and a float, performs subtraction, and returns a descriptive message. Introduces mixed data types and formatted output.  


# Lab 2: Abstract Classes and Inheritance

This lab focuses on abstract classes and inheritance in C#. It demonstrates how to define an abstract class with both abstract and regular methods, implement derived classes that override the abstract method, and use polymorphism to calculate and display results.

## Tasks

**Task 2: Shape Area Calculation**  
- Create an abstract class `Shape` with:  
  - `CalculateArea()` – an abstract method to compute the area of the shape  
  - `Display()` – a regular method to print the shape type and area  

- Implement two derived classes:  
  - `Circle` – calculates area as π × radius²  
  - `Rectangle` – calculates area as width × length  

- Instantiate objects of both classes, calculate their areas using `CalculateArea()`, and display the results using `Display()`.

**Outcome:**  
This task illustrates the use of abstract classes, inheritance, method overriding, and polymorphism in C#. It provides hands-on practice for designing reusable and extendable object-oriented code, showing how different shapes can share a common interface while implementing their own area calculations.


# Lecture 3: Functions, Methods, and Modular Programming in C#

In this lecture, I explored **how to structure a C# program using functions, methods, and modular design**. The goal was to move away from a single, crowded file and separate functionality into clear, reusable components.


Project Overview

I created a **main program** (`Program.cs`) that brings together several modules:  

- **Person** – Represents a person with `Name` and `Age`, and can print details.  
- **Counter** – A simple static counter that can be incremented and read.  
- **Calculator** – Performs basic arithmetic like addition.  
- **MathHelper** – Provides reusable math operations: square, power, addition, multiplication.

Each module lives in its **own namespace**, making the code easier to read, maintain, and extend. The main program interacts with all these modules, taking input, performing calculations, and displaying results.

## Summary

This project demonstrates **modular programming in C#**, separating logic into distinct files and namespaces. It highlights how to create reusable functions and methods, work with console input/output, and design a clean, maintainable program structure.

