using System;
using System.Collections.Generic;

// 🧩 1. Interfaces
public interface IObserver
{
    void Update(string message);
}

// Defines the Observer role — objects that want to get updates.
// Any class that wants to be notified about changes must implement the Update() method.

public interface ISubject
{
    void Register(IObserver observer);
    void Unregister(IObserver observer);
}

// Defines the Subject role — the one being observed.
// It keeps track of observers that register or unregister.

// 📰 2. Concrete Subject — NewsPublisher

public class NewsPublisher : ISubject
{
    private List<IObserver> observers = new List<IObserver>();

    // Keeps a list of all IObserver objects that want to receive updates.

    public void Register(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Unregister(IObserver observer)
    {
        observers.Remove(observer);
    }

    // Allows observers to subscribe or unsubscribe.

    private void Notify(string message)
    {
        foreach (var observer in observers)
            observer.Update(message);
    }

    // When something changes, the subject calls Notify() to update all registered observers.

    public void SetState(string message)
    {
        Console.WriteLine($"Subject: Changing state to '{message}'");
        Notify(message);
    }

    // Simulates a change in the subject’s state(e.g., new news being published).
    // Then triggers notifications to all observers.
}

// 👀 3. Concrete Observer — NewsReader
public class NewsReader : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"Received news update: {message}");
    }
}

// Implements the IObserver interface.
// Each observer defines how it reacts when an update is received.

// ⚙️ 4. Main Method(Testing the pattern)
public class Program
{
    static void Main(string[] args)
    {
        NewsPublisher np = new NewsPublisher();
        NewsReader nr1 = new NewsReader();
        NewsReader nr2 = new NewsReader();

        np.Register(nr1);
        np.Register(nr2);

        np.SetState("Hello world!");
    }

    // Creates one subject(NewsPublisher) and two observers(NewsReader).
    // Registers both readers to the publisher.
    // When the state changes (SetState("Hello world!")), both readers receive the same update.
}


// ✅ Summary
// Role	                        Class/Interface	        Purpose
// Subject (Interface)	        ISubject	            Defines how observers register/unregister
// Concrete Subject	            NewsPublisher	        Maintains and notifies observers
// Observer (Interface)	        IObserver	            Defines the Update() method
// Concrete Observer	        NewsReader	            Responds to notifications