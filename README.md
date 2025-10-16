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

# Lecture 5: Interfaces and Polymorphism in C#

In this lecture, I explored how **interfaces** in C# define contracts that classes must follow and how **polymorphism** allows objects of different classes to be treated through a shared interface.  
The goal was to understand how interfaces promote flexibility, modularity, and code reuse in object-oriented programming.

---

# Project Overview

I created a main program (`Program.cs`) that demonstrates multiple interface concepts, including basic interface implementation, polymorphism, multiple interfaces, and interface inheritance. Each concept is implemented in a separate namespace to keep the code organized and easy to understand.

---

## 1. Basic Interface Implementation

**Namespace:** `interface_`  
**Goal:** Demonstrate how a class can implement an interface and define specific behaviors.

### Project Structure
- **IVehicle (interface)**  
  - Methods: `StartEngine()`, `StopEngine()`  
  - Property: `CurrentSpeed`  
- **Car (implements IVehicle)**  
  - Implements engine start and stop functionality.  
  - Tracks `CurrentSpeed` when the engine starts or stops.  
  - Adds an extra method `PlayMusic()` to show class-specific behavior.  

**Example Output:**
```
Car engine started
10
Car engine stopped
Playing music...
```
---
## 2. Interface Polymorphism

**Namespace:** `polymorphism_interface`  
**Goal:** Show how the same interface can be used for different types of vehicles through polymorphism.

### Project Structure
- **IVehicle (interface)**  
  - Methods: `StartEngine()`, `GetVehicleType()`  
- **Car (implements IVehicle)**  
  - Defines `StartEngine()` and identifies as a car.  
- **Truck (implements IVehicle)**  
  - Defines `StartEngine()` and identifies as a truck.  

**Example Output:**
```
Test driving: Car
Car: Vrroom!
Test driving: Truck
Truck: VRROOOM!
```
---
## 3. Multiple Interfaces

**Namespace:** `multiple_interface`  
**Goal:** Demonstrate how a single class can implement more than one interface to gain multiple behaviors.

### Project Structure
- **IVehicle (interface)** → Method: `StartEngine()`  
- **IFlyable (interface)** → Method: `Fly()`  
- **FlyingCar (implements IVehicle, IFlyable)**  
  - Can start the engine and also fly, combining both behaviors.  

**Example Output:**
```
Engine started
Taking off!
```
---
## 4. Interface Inheritance

**Namespace:** `inheritance_interface`  
**Goal:** Show how interfaces can inherit from one another to build extended abstractions.

### Project Structure
- **IShape (interface)** → Method: `GetArea()`  
- **IColoredShape (inherits IShape)** → Adds property: `Color`  
- **ColoredCircle (implements IColoredShape)**  
  - Properties: `Radius`, `Color`  
  - Implements `GetArea()` to calculate the area of the circle.  

**Example Output:**
```
Area: 78.53981633974483, Color: Red
```

---

## Summary

This lecture work demonstrates how interfaces and polymorphism in C# allow for flexible, modular program design. By defining contracts that classes must fulfill, interfaces make code more reusable and maintainable. The examples show how to implement interfaces, achieve polymorphism, combine multiple behaviors, and use interface inheritance — all fundamental tools for writing clean and extensible object-oriented code.

---

# Lecture 5: Activity - Interfaces and Polymorphism

In this lecture activity, I explored how **interfaces** define shared behavior across different classes and how **polymorphism** enables interaction between diverse objects through common contracts. The goal was to understand how to design **flexible**, **reusable**, and **extensible** code using interfaces in C#.

---

## Project Overview

The project simulates a simple **battle system** where characters can attack and defend using shared interface definitions.  
A main program (`Program.cs`) demonstrates how interfaces allow multiple object types to participate in the same operations through polymorphism.

The implementation includes:

- **`IAttackable`** – Defines attack behavior with an `Attack()` method and `AttackPower` property.  
- **`IDefendable`** – Defines defense behavior with a `Defend()` method and `DefensePower` property.  
- **`Warrior`** – Implements both interfaces, capable of attacking and defending.  
- **`Mage`** – Implements only `IAttackable`, focusing on magical attacks.  
- **`Battle()`** – A method that accepts any `IAttackable` object, demonstrating polymorphic interaction.  

The `Main()` function creates instances of `Warrior` and `Mage` classes, initiates battles, and executes group attacks, showing how each object behaves based on the interfaces it implements.

---

## Project Structure

### `battleSimulation` Namespace

- **IAttackable (interface)**  
  - Property: `int AttackPower`  
  - Method: `void Attack()`  

- **IDefendable (interface)**  
  - Property: `int DefensePower`  
  - Method: `void Defend()`  

- **Warrior (implements IAttackable, IDefendable)**  
  - Properties: `Name`, `AttackPower`, `DefensePower`  
  - Methods:  
    - `Attack()` – Displays attack power.  
    - `Defend()` – Displays defense power.  

- **Mage (implements IAttackable)**  
  - Properties: `Name`, `AttackPower`  
  - Methods:  
    - `Attack()` – Displays magical attack message.  
    - `Healing()` – Performs a healing spell (not part of the interface).  

---

## Example Output
```
=== Battle Begins ===
Conan attacks with power 20!
Thor defends with power 10!
=== Battle Ends ===

=== Battle Begins ===
Merlin casts a spell with power 5!
=== Battle Ends ===

=== All Characters Attack! ===
Conan attacks with power 20!
Conan defends with power 15!

Thor attacks with power 25!
Thor defends with power 10!

Merlin casts a spell with power 5!
```
---

## Summary

This lecture activity demonstrates how **interfaces** promote **code modularity** and **polymorphism** in C#. By implementing `IAttackable` and `IDefendable`, the project shows how different classes can share behavior while keeping their unique characteristics. The result is a **clean**, **scalable**, and **maintainable** design that follows the principles of object-oriented programming.

---

# Lab 5: Task 1 — Implementing UML Class Diagram and Multiple Inheritance in C#

In this task from lab5, I explored how to design and implement interfaces and classes based on a UML class diagram. The task focused on demonstrating **interface-based design** and how to use **multiple inheritance through interfaces** in C#.  

## Project Overview

The project defines several interfaces and device classes that represent different types of connectivity — wired, wireless, and combined. Each device implements only the interfaces relevant to its functionality. Additionally, I extended the UML design by introducing two extra components:  

- **`Tablet` class** – A new device that supports **both WiFi and wired connections**, showcasing multiple inheritance through interfaces.  
- **`IDevice` interface** – A new abstraction that allows uniform handling of all device types.

---

## Project Structure

### `deviceConnectivity` Namespace
Contains all interfaces and device classes implementing various connectivity types.

#### Interfaces
- **`IDevice`**  
  - Methods:  
    - `EstablishConnection()` – sets up a device connection.  
    - `SendData(string text)` – sends data to another device.  
  - Added to provide a **common interface** for all devices.  

- **`IConnect`**  
  - Method: `EstablishConnection()`  

- **`ICommunicate`**  
  - Method: `SendData(string text)`  

- **`IWirelessCommunicate`** (inherits `ICommunicate`)  
  - Method: `ConnectToWifi()`  

- **`IWiredConnect`** (inherits `IConnect`)  
  - Method: `PlugInCable()`  

#### Classes
- **`SmartPhone`**  
  - Implements: `IDevice`, `IConnect`, `IWirelessCommunicate`  
  - Behaviors: Connects via WiFi, establishes a connection, and sends data.

- **`DesktopComputer`**  
  - Implements: `IDevice`, `ICommunicate`, `IWiredConnect`  
  - Behaviors: Connects using a wired cable, establishes connection, and sends data.

- **`Tablet`** *(Added as an extra feature)*  
  - Implements: `IDevice`, `IWirelessCommunicate`, `IWiredConnect`  
  - Behaviors: Can connect both wirelessly and via cable, establish connection, and send data.  
  - Demonstrates **multiple inheritance** by combining two connectivity interfaces.

---

## Example Output
```
=== Smart Phone ===
Smart Phone: Connection to Wifi has been made
Smart Phone: Connection has been established
I am sending some text from Smart Phone: Hello from phone

=== Desktop Computer ===
Desktop Computer: Plug in the cable
Desktop Computer: Connection has been established
I am sending some text from Desktop Computer: Hello from desktop

=== Tablet ===
Tablet: Plug in the cable
Tablet: Connection to Wifi has been made
Tablet: Connection has been established
I am sending some text from Tablet: Hello from tablet

=== IDevice Interface ===
Using IDevice interface to send data to all devices:

Smart Phone: Connection has been established
I am sending some text from Smart Phone: Hello via IDevice

Desktop Computer: Connection has been established
I am sending some text from Desktop Computer: Hello via IDevice

Tablet: Connection has been established
I am sending some text from Tablet: Hello via IDevice
```

---

## Summary

This lecture work demonstrates how **interfaces can replace traditional multiple inheritance** in C#, allowing classes to inherit behavior from multiple sources. By implementing both **wired and wireless communication interfaces** in the `Tablet` class, the project showcases a flexible design where new devices can be easily added and integrated. The addition of the **`Tablet`** and **`IDevice`** interfaces extends the UML model and highlights how abstraction leads to clean, scalable, and reusable code structures.

---
# Lab 5: Task 2 — Inventory System in C#

In this task from lab 5, I explored how to create a simple **game inventory system** in C# using **abstract classes, interfaces, and the singleton pattern**. The project demonstrates how to manage different types of items, interact with them, and keep the inventory organized and flexible.

## Project Overview

The project defines several **item types** (`Weapon`, `Potion`, `Shield`) and a **singleton inventory manager** that handles all items. Interfaces are used to define item behaviors like dealing damage or consuming single-use items.  

The main program demonstrates how to:

- Add items to the inventory.
- Use items according to their specific behaviors.
- Automatically remove single-use items after use.
- Show the current inventory at any time.

---

## Project Structure

### 1. `item` Namespace
Contains the **abstract base class** for all items.

- **`Item` (abstract class)**  
  - Properties: `Name`, `Weight`, `Value`  
  - Methods: `Use()` → implemented in derived classes.

### 2. `interfaces` Namespace
Defines behaviors that items can implement.

- **`IDamage`** → Method: `DealDamage()`  
- **`ISingleUse`** → Method: `Consume()`  

### 3. `weapon` Namespace
Contains the `Weapon` class.

- **`Weapon` (inherits `Item`, implements `IDamage`)**  
  - Properties: `Damage`  
  - Methods:  
    - `Use()` → attacks and deals damage  
    - `DealDamage()` → prints damage to the enemy

### 4. `potion` Namespace
Contains the `Potion` class.

- **`Potion` (inherits `Item`, implements `ISingleUse`)**  
  - Properties: `HealAmount`  
  - Methods:  
    - `Use()` → heals player and consumes potion  
    - `Consume()` → prints that potion is consumed

### 5. `shield` Namespace
Contains the `Shield` class.

- **`Shield` (inherits `Item`)**  
  - Properties: `Defence`  
  - Methods:  
    - `Use()` → blocks incoming damage

### 6. `inventoryManager` Namespace
Contains the **singleton class** `InventoryManager` to handle all items.

- **`InventoryManager`**  
  - Private static instance `_instance`  
  - Methods:  
    - `AddItem(Item item)` → adds item to inventory  
    - `removeItem(Item item)` → removes item from inventory  
    - `useItem(Item item)` → uses item and removes if single-use  
    - `showItemsInvetory()` → displays all items in inventory

- Singleton pattern ensures only **one inventory manager instance** exists.

---

## Example Output
```
Excalibur added to inventory.
Health Potion added to inventory.
Iron Shield added to inventory.

 Current Inventory: 
 - Excalibur (Weight: 5.5, Value: 1000)
 - Health Potion (Weight: 0.5, Value: 50)
 - Iron Shield (Weight: 7, Value: 200)

Using Items:
Excalibur is used to attack dealing 50 damage!
Excalibur deals 50 damage to the enemy!
Health Potion is used to heal 30 HP!
Health Potion is consumed!
Health Potion removed from inventory.
Iron Shield is used to block 20 damage!

 Current Inventory: 
 - Excalibur (Weight: 5.5, Value: 1000)
 - Iron Shield (Weight: 7, Value: 200)
```


---

## Summary

This taks from lab 5 work demonstrates how to design a **flexible and modular inventory system** using C#. Abstract classes define general item properties, interfaces define specific behaviors, and the singleton pattern ensures centralized inventory management. The system allows for easy addition of new item types and behaviors while keeping the inventory logic clean and maintainable.




# Lecture 6: SOLID Principles in C#

In this lecture, I explored the five SOLID principles of object-oriented programming in C#. The goal was to understand how to write clean, maintainable, and flexible code by separating responsibilities, using abstractions, and designing classes and interfaces thoughtfully.

## Project Overview

I created a main program (`Program.cs`) that demonstrates each SOLID principle in its own namespace:

- **Single Responsibility Principle (SRP)** – Separates concerns by having `Employee`, `PayrollCalculator`, and `EmployeeReportGenerator` handle distinct tasks.
- **Open/Closed Principle (OCP)** – Shows how `Shape` and `Rectangle` can be extended without modifying existing code. `AreaCalculator` uses polymorphism to calculate area.
- **Liskov Substitution Principle (LSP)** – Demonstrates how subclasses like `Sparrow` and `Penguin` behave correctly when substituted for the base class `Bird`.
- **Interface Segregation Principle (ISP)** – Uses small, specific interfaces (`IWorkable`, `IFeedable`, `IMeetingAttendee`) so classes only implement what they need (`RobotWorker`, `HumanWorker`).
- **Dependency Inversion Principle (DIP)** – High-level modules like `Notification` depend on the `IMessageService` interface rather than concrete implementations (`EmailService`, `SMSService`).

---

The `Program.cs` file contains commented-out `Main` methods for each principle — you can uncomment one section at a time to see how each principle works.  

Each principle is implemented in its own namespace, making the code modular, easy to read, maintain, and extend.  
The main program demonstrates behaviors such as calculations, polymorphism, message sending, and class interactions according to each principle.


## 1. Single Responsibility Principle (SRP)

**Namespace:** `singleResponsibilityPrinciple`  
**Goal:** Each class has one clear responsibility.

### Project Structure
- **Employee**  
  - Properties: `Name`, `Salary`  
  - Holds employee data.  
- **PayrollCalculator**  
  - Methods: `CalculatePay(Employee employee)` → calculates total pay.  
- **EmployeeReportGenerator**  
  - Methods: `GenerateReport(Employee employee)` → generates a simple employee report.  

**Example Output:**
```
Employee: John Smith
Base Salary: £3,000.00
Total Pay (with bonus): £3,300.00
```
---
## 2. Open/Closed Principle (OCP)

**Namespace:** `openClosePrinciple`  
**Goal:** Add new features without changing existing code.

### Project Structure
- **Shape (abstract class)**  
  - Methods: `CalculateArea()` (abstract) → implemented by derived shapes.  
- **Rectangle (inherits Shape)**  
  - Properties: `Width`, `Height`  
  - Overrides `CalculateArea()` to compute rectangle area.  
- **AreaCalculator**  
  - Methods: `CalculateArea(Shape shape)` → uses polymorphism to calculate any shape’s area.  

**Example Output:**
```
Rectangle width: 5
Rectangle height: 3
Area: 15
```
---
## 3. Liskov Substitution Principle (LSP)

**Namespace:** `liskovPrinciple`  
**Goal:** Subclasses must behave correctly when used as their base type.

### Project Structure
- **Bird (abstract class)**  
  - Methods: `MakeSound()` (abstract), `Eat()` (virtual)  
- **Sparrow (inherits Bird, implements IFlyable)**  
  - Methods: `Fly()` → prints flying behavior  
  - Overrides `MakeSound()` → prints chirp  
- **Penguin (inherits Bird)**  
  - Overrides `MakeSound()` → prints squawk  
  - Cannot fly (does not implement IFlyable)  

**Example Output:**
```
Chirp
Flying high!
Squawk
Demonstration complete — both birds share behavior correctly without breaking Liskov’s principle.
```
---
## 4. Interface Segregation Principle (ISP)

**Namespace:** `interfaceSegregationPrinciple`  
**Goal:** Separate large interfaces into smaller, specific ones.

### Project Structure
- **IWorkable** → Method: `Work()`  
- **IFeedable** → Method: `Eat()`  
- **IMeetingAttendee** → Method: `AttendMeeting()`  
- **RobotWorker (implements IWorkable)** → can only work  
- **HumanWorker (implements IWorkable, IFeedable, IMeetingAttendee)** → works, eats, attends meetings  

**Example Output:**
```
Robot working...
Human working...
Eating lunch...
In meeting...
Demonstration complete — interfaces are separated according to responsibilities.
```
---
## 5. Dependency Inversion Principle (DIP)

**Namespace:** `dependencyInversionPrinciple`  
**Goal:** High-level classes depend on interfaces, not concrete implementations.

### Project Structure
- **IMessageService (interface)** → Method: `SendMessage(string message)`  
- **EmailService (implements IMessageService)** → sends email messages  
- **SMSService (implements IMessageService)** → sends SMS messages  
- **Notification**  
  - Constructor: `Notification(IMessageService messageService)`  
  - Methods: `Send(string message)` → sends message through injected service  

**Example Output:**
```
Sending Email: Meeting at 3 PM
Sending SMS: Reminder: Project deadline tomorrow
Demonstration complete — Dependency Inversion Principle applied successfully.
```

---

## Summary

This lecture work demonstrates how the SOLID principles improve code design by separating responsibilities, using abstractions, and keeping classes and interfaces focused. It highlights clean, modular programming practices in C# and shows how to build systems that are maintainable, extensible, and easy to understand.  Together, these examples tell a story of how thoughtful structure turns fragile code into flexible, robust software.

--- 

# Lab 6 - Task 1: Notification Service Refactor (SOLID Principles)

This project demonstrates a refactoring of a simple **NotificationService** in C# to better follow **SOLID principles**, improving clarity, maintainability, and scalability.

---

## Overview

Originally, the `NotificationService` class handled all types of notifications (Email, SMS, WhatsApp) within one method using multiple `if` statements.  
This design made the code harder to maintain and extend.

The refactored version separates responsibilities into individual classes and keeps the `NotificationService` focused only on **managing message delivery**, not the sending logic itself.

---

## Applied SOLID Principles

### 1. Single Responsibility Principle (SRP)
A class should have only one reason to change — it should do one thing only.

- Each notification type has its **own dedicated class**:
  - `EmailService` → handles only email messages  
  - `SMSService` → handles only SMS messages  
  - `WhatsAppService` → handles only WhatsApp messages  
- `NotificationService` is responsible **only** for coordinating which service to call.

**Result:**  
Simpler, cleaner code where each class has one clear purpose.

---

### 2. Open/Closed Principle (OCP)
Classes should be open for extension but closed for modification.

- To add a new notification type (e.g., `SlackService`), you simply **create a new class** with its own `Send(string message)` method.
- Existing classes don’t need to be modified, which makes the system easier to extend and less prone to bugs.

**Result:**  
Easily extendable system — new features can be added without touching existing, tested code.

---

## Example Usage

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        NotificationService service = new NotificationService();
        service.SendNotification("Welcome to SOLID Lab!", "Email");
        service.SendNotification("System update available!", "WhatsApp");
    }
}


