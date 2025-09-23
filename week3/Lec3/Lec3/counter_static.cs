
namespace counter_static
{
    public class User
    {
        private string name;
        private int age;
        // Shared across all instances
        public static int MyCounter = 0;

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;

            // Increment counter automatically when a new User is created
            // MyCounter++;
        }
        public void IncrementCounter()
        {
            MyCounter++;
        }
    }

    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         User u1 = new User("Alice", 25);
    //         User u2 = new User("Bob", 30);

    //         Console.WriteLine($"Total users created: {User.MyCounter}");

    //         u2.IncrementCounter(); // extra manual increment
    //         Console.WriteLine($"Counter after increment: {User.MyCounter}");
    //     }
    // }
}
