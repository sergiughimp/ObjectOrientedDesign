using System;

// Interface for sending notifications
public interface INotificationChannel
{
    public void Send(string message);
}

// Interface for scheduling notifications
public interface ISchedulable
{
    public void Schedule(string message, DateTime time);
}
// EmailService supports sending and scheduling
public class EmailService : INotificationChannel, ISchedulable
{
    public void Send(string message)
    {
        Console.WriteLine("Sending Email: " + message);
    }
    public void Schedule(string message, DateTime time)
    {
        Console.WriteLine($"Email scheduled at {time}: {message}");
    }
}
// SMSService supports only sending
public class SMSService : INotificationChannel
{
    public void Send(string message)
    {
        Console.WriteLine("Sending SMS: " + message);
    }
}
// WhatsAppService supports only sending
public class WhatsAppService : INotificationChannel
{
    public void Send(string message)
    {
        Console.WriteLine("Sending WhatsApp: " + message);
    }
}
// SlackService supports only sending
public class SlackService : INotificationChannel
{
    public void Send(string message)
    {
        Console.WriteLine("Sending Slack: " + message);
    }
}
// TestChannel supports only sending
public class TestChannel : INotificationChannel
{
    public void Send(string message)
    {
        Console.WriteLine("Test Channel: " + message);
    }
}
// NotificationService depends on INotificationChannel (constructor injection)
public class NotificationService
{
    private readonly INotificationChannel _channel;

    public NotificationService(INotificationChannel channel)
    {
        _channel = channel;
    }

    public void SendNotification(string message)
    {
        _channel.Send(message);
    }

    public void ScheduleNotification(string message, DateTime time, ISchedulable schedulable)
    {
        schedulable.Schedule(message, time);
    }
}
// Program demonstrating flexible dependency injection
public class Program
{
    public static void Main(string[] args)
    {
        // Create channels externally
        TestChannel testChannel = new TestChannel();
        EmailService emailService = new EmailService();
        SMSService smsService = new SMSService();
        WhatsAppService whatsAppService = new WhatsAppService();
        SlackService slackService = new SlackService();

        // Inject each channel into NotificationService
        NotificationService testService = new NotificationService(testChannel);
        NotificationService emailServiceWrapper = new NotificationService(emailService);
        NotificationService smsServiceWrapper = new NotificationService(smsService);
        NotificationService whatsAppServiceWrapper = new NotificationService(whatsAppService);
        NotificationService slackServiceWrapper = new NotificationService(slackService);

        // Send messages
        testService.SendNotification("Sms Message!");
        smsServiceWrapper.SendNotification("SMS Message!");
        whatsAppServiceWrapper.SendNotification("WhatsApp Message!");
        slackServiceWrapper.SendNotification("Slack Message!");

        // Schedule email
        emailServiceWrapper.ScheduleNotification("Scheduled Email", DateTime.Now.AddMinutes(2), emailService);

        Console.WriteLine("All messages processed.");
        }
}
