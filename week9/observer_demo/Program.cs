// Subject weatherStation = new Subject();
// Observer display1 = new Observer();
// Observer display2 = new Observer();
// Observer display3 = new Observer();

// weatherStation.Add(display1);
// weatherStation.Add(display2);
// weatherStation.Add(display3);

// weatherStation.SetState("Sunny");

// public class Observer {
//     public void Update(string message)
//     {
// 		Console.WriteLine($"Received news update: {message}");
// 	}

// }

// public class Subject
// {
//     private List<Observer> observers = new List<Observer>();

//     public void Add(Observer observer)
//     {
//         observers.Add(observer);
//     }

//     public void Remove(Observer observer)
//     {
//         observers.Remove(observer);
//     }

//     private void Notify(string message)
//     {
//         foreach (var observer in observers)
//             observer.Update(message);
//     }

//     public void SetState(string message) {
//         Random random = new Random();
//             int temperature = random.Next(-5, 31);
//                 Notify($"The temperature is: {temperature}°C");
//         }
// }


using System;
using System.Collections.Generic;

public class Observer
{
    public void Update(string message)
    {
        Console.WriteLine($"Received news update: {message}");
    }
}

// 🩵 1. Abstract Sensor
// This defines a general sensor structure.
// Each sensor (like temperature, humidity, pressure) will later inherit this.
public abstract class Sensor
{
    public abstract string GetReading();
}

// 🩵 2. Concrete Temperature Sensor: knows how to measure (generate) temperature.
public class TemperatureSensor : Sensor
{
    private Random random = new Random();

    public override string GetReading()
    {
        int temperature = random.Next(-5, 31);
        return $"The temperature is: {temperature}°C";
    }
}

public class Subject
{
    private List<Observer> observers = new List<Observer>();
    private Sensor sensor;

    public Subject(Sensor sensor)
    {
        this.sensor = sensor;
    }

    public void Add(Observer observer)
    {
        observers.Add(observer);
    }

    public void Remove(Observer observer)
    {
        observers.Remove(observer);
    }

    private void Notify(string message)
    {
        foreach (var observer in observers)
            observer.Update(message);
    }

    public void SetState(string message)
    {
        string data = sensor.GetReading();
        Notify(data);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Sensor tempSensor = new TemperatureSensor();
        Subject weatherStation = new Subject(tempSensor);

        Observer display1 = new Observer();
        Observer display2 = new Observer();
        Observer display3 = new Observer();

        weatherStation.Add(display1);
        weatherStation.Add(display2);
        weatherStation.Add(display3);

        weatherStation.SetState("Sunny");
    }
}

// What Changed (Quick Summary)
// Change	Location	Purpose
// Added abstract class Sensor	Above Subject	Defines general sensor behavior
// Added TemperatureSensor	Below Sensor	Provides specific temperature readings
// Updated Subject constructor & SetState()	Inside Subject	Uses Sensor instead of random numbers
// Updated weatherStation creation	Top of main code	Attaches a sensor to the station