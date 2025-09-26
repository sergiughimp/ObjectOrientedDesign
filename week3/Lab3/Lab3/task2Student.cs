namespace task2Student
{
    public class Student
    {
        private string name;
        private int age;
        private string studentId;

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
                    throw new ArgumentException("Name cannot be empty or whitespace");
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
        public string StudentId
        {
            get
            {
                return studentId;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("studentId cannot be empty or whitespace");
                }
                else
                {
                    studentId = value;
                }
            }
        }


        public Student(string name, int age, string studentId)
        {
            this.Name = name;
            this.Age = age;
            this.StudentId = studentId;
        }

        public void DisplayInfo()
        {
            StudentDisplay.Display(this);
        }
        public class StudentDisplay
        {
            public static void Display(Student student)
            {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, StudentId: {student.StudentId}");
            }
        }
    }
}