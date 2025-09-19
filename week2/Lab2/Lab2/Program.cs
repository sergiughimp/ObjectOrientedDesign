using System;
using System.Xml;
namespace Lab2

// Lecture2: slide 2, 3: Class definition & Instantiation
// {
//     class ClassName
//     {
//         // Fields
//         private int field;
//         // Constructor
//         public ClassName(int param)
//         {
//             field = param;
//         }
//         // Method
//         public void MethodName()
//         {
//             Console.WriteLine("This is a method.");
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             ClassName obj = new ClassName(5);
//             obj.MethodName();
//         }
//     }
// }


// Lecture2: slide 5 & 6 & 7: Accessing methods and fields & Writing Methods & Using Methods

{

    class MyClass
    {
        int x;
        public MyClass()
        {
            x = 15;
        }
        public int getX()
        {
            return x;
        }
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }
        public void CalculateNumbers()
        {
            int myResult = AddNumbers(3, 5);
            Console.WriteLine("Result from CalculateNumbers: " + myResult);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();

            int myVariable = myObject.getX();
            Console.WriteLine("getX result: " + myVariable);

            // Call AddNumbers directly
            int sum = myObject.AddNumbers(10, 20);
            Console.WriteLine("Result from AddNumbers: " + sum);

            // Call CalculateNumbers
            myObject.CalculateNumbers();
        }
    }
}

// Lecture2: slide 12: Inheritance
// {
//     class BaseClass {
//         public void BaseMethod() { Console.WriteLine("Base method.");
//         }
//     }
//     class DerivedClass : BaseClass {
//         public void DerivedMethod(){
//             Console.WriteLine("Derived method.");
//         }
//     }
//     class Program{
//         static void Main(string[] args)
//         {
//             // Console.WriteLine("Hello World");
//             BaseClass obj_base1 = new BaseClass();
//             DerivedClass obj_derived1 = new DerivedClass(); 
//             obj_derived1.BaseMethod();
//             obj_derived1.DerivedMethod();
//         }
//     }
// }


// Lecture2: slide 14: Inheritance
// {
//     class BaseClass {
//         public virtual void Display() {
//  Console.WriteLine("Display from BaseClass");
//         }
//     }
//     class DerivedClass : BaseClass { 
//         public override void Display() {
//         Console.WriteLine("Display from DerivedClass");
//         }
//     }
//     class Program{
//         static void Main(string[] args)
//         {
//             BaseClass obj1 = new BaseClass();
//             obj1.Display(); // Output: Display from BaseClass
//             DerivedClass obj2 = new DerivedClass(); obj2.Display(); // Output: Display from DerivedClass
//         }
//     }
// }

// Lecture2:  slide 16: Abstract Class
// {
//     public abstract class Animal {
//         public abstract void MakeSound();
//         public void Sleep() {
//             Console.WriteLine("Sleeping...");
//         }
//     }
//     public class Dog : Animal {
//         public override void MakeSound() {
//             Console.WriteLine("Bark");
//         }
//     }

//     class Program {
//         static void Main(string[] args)
//         {
//             Dog myDog = new Dog(); 
//             myDog.MakeSound();
//             myDog.Sleep();
//         }
//     }
// }