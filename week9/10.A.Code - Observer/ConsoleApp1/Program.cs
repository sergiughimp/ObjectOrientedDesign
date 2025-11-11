Subject weatherStation = new Subject();
Observer display1 = new Observer();
Observer display2 = new Observer();
Observer display3 = new Observer();

weatherStation.Add(display1);
weatherStation.Add(display2);
weatherStation.Add(display3);

weatherStation.SetState("Sunny");

public class Observer {
    public void Update(string message)
    {
		Console.WriteLine($"Received news update: {message}");
	}

    }

public class Subject
{
    private List<Observer> observers = new List<Observer>();

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
    Random random = new Random();
        int temperature = random.Next(-5, 31);
            Notify($"The temperature is: {temperature}°C");
}


}