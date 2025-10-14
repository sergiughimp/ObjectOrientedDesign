using System;
using interface_;
// using polymorphism_interface;
// using multiple_interface;
// using inheritance_interface;

class Program
{
    // main for the interface_
    public static void Main(string[] args)
    {
        Car car2 = new Car();
        IVehicle vehicle = new Car();

        vehicle.StartEngine();
        Console.WriteLine(vehicle.CurrentSpeed);

        vehicle.StopEngine();
        car2.PlayMusic();
    }


    // // main for the polymorphism_interface
    // public static void TestDrive(IVehicle vehicle)
    // {
    //     Console.WriteLine($"Test driving:{vehicle.GetVehicleType()}");
    //     vehicle.StartEngine();
    // }
    // public static void Main(string[] args)
    // {
    //     TestDrive(new Car());
    //     TestDrive(new Truck());
    // }

    // // main for the multiple_interface
    // public static void Main(string[] args)
    // {
    //     FlyingCar cool = new FlyingCar();
    //     cool.StartEngine();
    //     cool.Fly();
    // }

    // // main for the inheritance_interface
    // public static void Main(string[] args)
    // {
    //     // IColoredShape circle = new ColoredCircle();
    //     ColoredCircle circle = new ColoredCircle();
    //     circle.Radius = 5;
    //     circle.Color = "Red";
    //     Console.WriteLine($"Area: {circle.GetArea()}, Color: {circle.Color}");
    // }
}