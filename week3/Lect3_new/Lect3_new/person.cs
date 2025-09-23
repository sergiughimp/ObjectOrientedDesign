
namespace person
{
    public class Person
    {
        private int age;

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be emplty or whitespace");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
                age = value;
            }
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void PrintDetails()
        {
            // PersonPrinter printer = new PersonPrinter();
            PersonPrinter.Print(this);
        }
        public class PersonPrinter
        {
            public static void Print(Person person)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }

}