using System;
using System.Collections.Generic;
using deviceConnectivity;

class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("=== Smart Phone ===");

        SmartPhone smartPhone = new SmartPhone();
        smartPhone.ConnectToWifi();
        smartPhone.EstablishConnection();
        smartPhone.SendData("Hello from phone");

        Console.WriteLine();
        Console.WriteLine("=== Desktop Computer ===");

        DesktopComputer desktopComputer = new DesktopComputer();
        desktopComputer.PlugInCable();
        desktopComputer.EstablishConnection();
        desktopComputer.SendData("Hello from desktop");

        Console.WriteLine();
        Console.WriteLine("=== Tablet ===");

        Tablet tablet = new Tablet();
        tablet.PlugInCable();
        tablet.ConnectToWifi();
        tablet.EstablishConnection();
        tablet.SendData("Hello from tablet");

        Console.WriteLine();
        Console.WriteLine("=== IDevice Interface ===");

        // Using IDevice interface to handle all devices uniformly
        List<IDevice> devices = new List<IDevice>
        {
            smartPhone,
            desktopComputer,
            tablet
        };

        Console.WriteLine("Using IDevice interface to send data to all devices:");
        Console.WriteLine();
        foreach (IDevice device in devices)
        {
            device.EstablishConnection();
            device.SendData($"Hello via IDevice");
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}