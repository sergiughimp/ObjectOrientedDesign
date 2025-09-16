using System;
namespace Lec2
{
    class ClassName {
        // Fields
        public int abc;
        private int field;

        // Constructor
        public ClassName(int paramm) { 
            field = paramm;
            // abc = param2;
        }

        // Method
        public void MethodName()
        {
            Console.WriteLine(abc);
            Console.WriteLine("This is a method.");
        }
        
        public void AnotherMethod(){
            MethodName();
        }
        
    }    

    class Program{
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            ClassName obj1 = new ClassName(10);
            obj1.abc = 5;
            obj1.MethodName();
            // Console.WriteLine(obj1.abc);
        }
    }
}
