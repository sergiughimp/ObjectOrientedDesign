using System;

public abstract class Notification
{
    public abstract void Send();
}

// ===============================
//       BASE NOTIFICATION
// ===============================

public class BasicNotification : Notification
{
    private string _message;

    public BasicNotification(string message)
    {
        _message = message;
    }

    public override void Send()
    {
        Console.WriteLine($"Sending basic notification: {_message}");
    }
}

// ===============================
//        DECORATOR BASE
// ===============================

public abstract class NotificationDecorator : Notification
{
    protected Notification wrappedNotification;

    public NotificationDecorator(Notification notification)
    {
        wrappedNotification = notification;
    }

    public override void Send()
    {
        wrappedNotification.Send();
    }
}

// ===============================
//      CONCRETE DECORATORS
// ===============================

public class SMSDecorator : NotificationDecorator
{
    public SMSDecorator(Notification notification) : base(notification) { }

    public override void Send()
    {
        base.Send();
        Console.WriteLine(" -> Sending SMS notification");
    }
}

public class EmailDecorator : NotificationDecorator
{
    public EmailDecorator(Notification notification) : base(notification) { }

    public override void Send()
    {
        base.Send();
        Console.WriteLine(" -> Sending Email notification");
    }
}

public class PushDecorator : NotificationDecorator
{
    public PushDecorator(Notification notification) : base(notification) { }

    public override void Send()
    {
        base.Send();
        Console.WriteLine(" -> Sending Push notification");
    }
}

public class SlackDecorator : NotificationDecorator
{
    public SlackDecorator(Notification notification) : base(notification) { }

    public override void Send()
    {
        base.Send();
        Console.WriteLine(" -> Sending Slack message");
    }
}

public class SoundAlertDecorator : NotificationDecorator
{
    public SoundAlertDecorator(Notification notification) : base(notification) { }

    public override void Send()
    {
        base.Send();
        Console.WriteLine(" -> Playing sound alert");
    }
}

// ===============================
//            PROGRAM
// ===============================

class Program
{
    static void Main(string[] args)
    {
        // Notification with Email + SMS + Push
        Notification n1 = new BasicNotification("You have a new follower!");
        n1 = new EmailDecorator(n1);
        n1 = new SMSDecorator(n1);
        n1 = new PushDecorator(n1);

        Console.WriteLine("=== Notification 1 ===");
        n1.Send();

        // Notification with Slack + Sound alert
        Notification n2 = new BasicNotification("Your post got a new like!");
        n2 = new SlackDecorator(n2);
        n2 = new SoundAlertDecorator(n2);

        Console.WriteLine("\n=== Notification 2 ===");
        n2.Send();
    }
}
