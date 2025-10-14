using System;

using singleResponsibilityPrinciple;
using openClosePrinciple;
using liskovPrinciple;
using interfaceSegregationPrinciple;
using dependencyInversionPrinciple;

public class Program
{

    // Single Responsibility Principle
    public static void Main(string[] args)
    {
        // Create an Employee
        Employee employee = new Employee
        {
            Name = "John Smith",
            Salary = 3000m
        };

        // Create PayrollCalculator and calculate pay
        PayrollCalculator payrollCalculator = new PayrollCalculator();
        decimal totalPay = payrollCalculator.CalculatePay(employee);

        // Generate report
        EmployeeReportGenerator reportGenerator = new EmployeeReportGenerator();
        string report = reportGenerator.GenerateReport(employee);

        // Display results
        Console.WriteLine(report);
        Console.WriteLine($"Base Salary: {employee.Salary:C}");
        Console.WriteLine($"Total Pay (with bonus): {totalPay:C}");
    }

    // // Open Close Principle
    // public static void Main(string[] args) {
    //     // Create a rectangle
    //     Rectangle rectangle = new Rectangle
    //     {
    //         Width = 5.0,
    //         Height = 3.0
    //     };

    //     // Create AreaCalculator
    //     AreaCalculator calculator = new AreaCalculator();

    //     // Calculate area using polymorphism
    //     double area = calculator.CalculateArea(rectangle);

    //     // Display result
    //     Console.WriteLine($"Rectangle width: {rectangle.Width}");
    //     Console.WriteLine($"Rectangle height: {rectangle.Height}");
    //     Console.WriteLine($"Area: {area}");
    // }

    // // Liskov Substitution Principle(LSP)
    // public static void Main(string[] args) {
    //     // Create a Sparrow (which can fly)
    //     Sparrow sparrow = new Sparrow();
    //     sparrow.MakeSound();
    //     sparrow.Eat();
    //     sparrow.Fly();

    //     Console.WriteLine();

    //     // Create a Penguin (which cannot fly)
    //     Penguin penguin = new Penguin();
    //     penguin.MakeSound();
    //     penguin.Eat();

    //     Console.WriteLine();
    //     Console.WriteLine("Demonstration complete — both birds share behavior correctly without breaking Liskov’s principle.");
    // }

    // // Interface Segregation Principle
    // public static void Main(string[] args)
    // {
    //     // Create a robot worker
    //     RobotWorker robot = new RobotWorker();
    //     robot.Work();

    //     Console.WriteLine();

    //     // Create a human worker
    //     HumanWorker human = new HumanWorker();
    //     human.Work();
    //     human.Eat();
    //     human.AttendMeeting();

    //     Console.WriteLine();
    //     Console.WriteLine("Demonstration complete — interfaces are separated according to responsibilities.");
    // }

    // // Dependency Inversion Principle
    // public static void Main(string[] args)
    // {
    //     // Create message services
    //     IMessageService emailService = new EmailService();
    //     IMessageService smsService = new SMSService();

    //     // Inject EmailService into Notification
    //     Notification emailNotification = new Notification(emailService);
    //     emailNotification.Send("Meeting at 3 PM");

    //     Console.WriteLine();

    //     // Inject SMSService into Notification
    //     Notification smsNotification = new Notification(smsService);
    //     smsNotification.Send("Reminder: Project deadline tomorrow");

    //     Console.WriteLine();
    //     Console.WriteLine("Demonstration complete — Dependency Inversion Principle applied successfully.");
    // }
}