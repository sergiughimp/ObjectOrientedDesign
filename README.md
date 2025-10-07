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


# Lab 3: Classes and Objects in C#

This lab focuses on **working with generic collections** and **defining classes with properties and methods** in C#. It demonstrates how to organize code into multiple namespaces for clarity and modularity.

## Project Overview

The project consists of two main parts:

### Task 1: Library Management System
- **Objective:** Manage a collection of book titles using `List<string>`.
- **Operations Implemented:**
  - Add a book by title to the list.
  - Display all books with their position numbers.
  - Remove a book by title.
  - Check if a specific book exists in the collection.
  - Show the total number of books.
- **Implementation:** All functionality is encapsulated in the `Library` class within the `task1Library` namespace. The `Main` method interacts with this class to demonstrate its features.

### Task 2: Student Class
- **Objective:** Create a `Student` class with private fields and public properties.
- **Fields and Properties:** `name` (string), `age` (int), `studentId` (string) with basic get/set validation.
- **Constructor:** Uses the `this` keyword to initialize all fields.
- **Method:** `DisplayInfo()` prints the student details.
- **Implementation:** Two `Student` objects are created in `Main()` and their information is displayed. The class is defined in the `task2Student` namespace.


## Project Structure

- `Program.cs` – Main program file that calls both the Library and Student classes.
- `task1Library` namespace – Contains the `Library` class.
- `task2Student` namespace – Contains the `Student` class.

## Summary

This lab demonstrates **object-oriented design** in C# by creating classes with properties, constructors, and methods, while also showing how to use **generic collections** (`List<T>`). The project is structured to separate functionality into **different namespaces**, making the code more readable, modular, and maintainable.

# Lect 4 – Singleton Patter, Animal Manager and Generics in C#

This project demonstrates **object-oriented programming (OOP)** concepts in C# along with **generic programming**. It covers the following key topics:

- **Inheritance and Abstraction**  
- **Singleton Pattern**  
- **Generics in C#**  

---

## Project Structure

### 1. `animals` Namespace
Contains the **Animal hierarchy** and the **AnimalManager** singleton.

- **Animal (abstract class)**  
  - Method: `MakeSound()` – must be implemented by derived classes.  

- **Dog (inherits Animal)**  
  - Overrides `MakeSound()` to print `"Woof!"`  

- **Cat (inherits Animal)**  
  - Overrides `MakeSound()` to print `"Meow!"`  

- **AnimalManager (Singleton)**  
  - Manages a single instance for adding animals to a list.  
  - Method: `AddAnimal(List<Animal> animals, Animal animal)` – adds a new animal to the list.  

---

### 2. `generics` Namespace
Demonstrates the use of **generics** in C#.

- **Box<T> (generic class)**  
  - Allows storing and retrieving a value of any type.  
  - Methods:  
    - `SetValue(T value)` – stores a value of type `T`.  
    - `GetValue()` – retrieves the stored value of type `T`.  

---

### 3. `Program.cs`
Demonstrates the functionality:

1. Creates a **list of animals**.  
2. Adds a `Dog` and a `Cat` using the **singleton AnimalManager**.  
3. Iterates through the list and prints each animal's sound using `MakeSound()`.  
4. Demonstrates generics with `Box<int>` and `Box<string>` storing and retrieving values.  

---

## Example Output
```text
Woof!
Meow!
intBox contains: 123
strBox contains: Hello
```

## Singleton Pattern

**Importance:**  
- Ensures **only one instance** of `AnimalManager` exists.  
- Provides **centralized access** for adding and managing animals.  
- Prevents inconsistencies and redundant instances.

**Characteristics:**  
- Private constructor prevents external instantiation.  
- Static instance holds the singleton object.  
- Global access via `Instance` property.  
- Lazy initialization – instance created only when first accessed.

---

## Key Concepts Demonstrated

- **Abstraction:** `Animal` defines a common interface for derived classes.  
- **Inheritance:** `Dog` and `Cat` reuse structure from `Animal`.  
- **Singleton Pattern:** `AnimalManager` manages animals consistently.  
- **Generics:** `Box<T>` allows storing values of any type safely.  
- **Collections:** `List<Animal>` dynamically manages multiple objects.


## Summary

This project demonstrates how to:

- Apply **abstraction and inheritance** with an `Animal` base class and specific animal types.  
- Use the **singleton pattern** with `AnimalManager` to manage a single list of animals.  
- Implement **generics** with `Box<T>` for type-safe storage of different data types.  
- Work with **collections** (`List<Animal>`) to dynamically manage multiple objects.


# Lab 4 – Library Management System in C#

This project implements a simple **Library Management System** using **object-oriented programming** principles in C#. The system uses **inheritance**, **abstraction**, and the **Singleton pattern** to manage different types of library items such as **Books, Magazines, and Journals**.  

---

## Project Structure

### 1. `libraryItem` Namespace
Contains the **abstract base class** for all library items.  

- **LibraryItems (abstract class)**  
  - Properties: `name`, `isAvailable`  
  - Methods:  
    - `GetName()` – returns the name of the item.  
    - `DisplayInfo()` – displays basic information about the item.  
    - `CheckAvailabilityByName(string itemName)` – checks availability of the item by its name.  

### 2. `printedMaterial` Namespace
Contains the `PrintedMaterial` class.  

- **PrintedMaterial (inherits LibraryItems)**  
  - Properties: `genre`, `ISBN`  
  - Methods:  
    - Overrides `DisplayInfo()` to show genre and ISBN.  

### 3. `book` Namespace
Contains the `Book` class.  

- **Book (inherits PrintedMaterial)**  
  - Properties: `subject`, `recomandedFor`, `plotSummary`  
  - Methods:  
    - Overrides `DisplayInfo()` to include subject, recommended audience, and plot summary.  

### 4. `periodical` Namespace
Contains the `Periodical` class.  

- **Periodical (inherits LibraryItems)**  
  - Properties: `issueNumber`, `periodicity`  
  - Methods:  
    - Overrides `DisplayInfo()` to show issue number and periodicity.  

### 5. `magazine` Namespace
Contains the `Magazine` class.  

- **Magazine (inherits Periodical)**  
  - Properties: `celebrityFocus`  
  - Methods:  
    - Overrides `DisplayInfo()` to include celebrity focus information.  

### 6. `journal` Namespace
Contains the `Journal` class.  

- **Journal (inherits Periodical)**  
  - Properties: `fieldOfStudy`, `editorInChief`  
  - Methods:  
    - Overrides `DisplayInfo()` to show the field of study and editor-in-chief.  

### 7. `library` Namespace
Contains the **LibraryManager** class, which implements a **Singleton pattern**.  

- **LibraryManager (Singleton)**  
  - Maintains a **single list of all library items** (`List<LibraryItems>`).  
  - Methods:  
    - `AddItem(LibraryItems item)` – adds a new item to the library.  
    - `RemoveItem(LibraryItems item)` – removes an item by object reference.  
    - `RemoveItem(string name)` – removes an item by name.  
    - `DisplayItems()` – prints all items in the library with detailed information.  
    - `CheckAvailability(string itemName)` – checks availability of an item by name across all items.  
    - `GetAllItems()` – returns the list of all library items.  

### 8. `Program.cs`
Contains the **main program** for testing the library system.  

- Demonstrates:  
  - Creating instances of `Book`, `Magazine`, and `Journal`.  
  - Adding items to the library.  
  - Displaying all items.  
  - Checking availability of items by name.  
  - Removing items by object and by name.  
  - Accessing the list of all items.  

---

## Features

- **Object-Oriented Design:** Uses inheritance, abstraction, and polymorphism to represent different library items.  
- **Singleton LibraryManager:** Ensures only one instance of the library manager exists.  
- **Unified Item List:** All items (books, magazines, journals) are managed in a single list.  
- **Availability Check:** Can check availability of any item by name.  
- **Flexible Removal:** Supports removal by object or by name.  

## Example Output

```text
Book "The Enchanted Forest" added to library.
Magazine "Star Weekly" added to library.
Journal "Science Today" added to library.

Library Items:
The Enchanted Forest (Available: Yes)
    Genre: Fantasy, ISBN: 978-3-16-148410-0
    Subject: Magic, Adventure, and Friendship
    Recommended For: Teens and young adults
    Plot Summary: When an ancient spell awakens the long-forgotten creatures of the Enchanted Forest…

Star Weekly (Available: Yes)
    Issue: 10, Periodicity: Weekly
    Celebrity Focus: Celebrity news

Science Today (Available: Yes)
    Issue: 5, Periodicity: Monthly
    Field of Study: Physics
    Editor in Chief: Dr. John Doe

Availability check:
The Enchanted Forest is available.
Star Weekly is available.
Science Today is available.

Removing items:
Book "The Enchanted Forest" removed from library.
Item "The Enchanted Forest" not found.

Remaining items in library:
Star Weekly
Science Today
```
