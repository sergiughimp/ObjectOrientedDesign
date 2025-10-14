using System;

public interface INotificationService
{
    void SendNotification(string message);
}
public class EmailNotification : INotificationService{
    public void SendNotification(string message){
        Console.WriteLine("Sending Email: "+ message);
    }
}
public class SMSService: INotificationService{
    public void SendNotification(string message){   
        Console.WriteLine("Sending SMS: "+ message);
    }
}
public class WhatsAppNotification: INotificationService{
    public void SendNotification(string message){
        Console.WriteLine("Sending WhatsApp: "+ message);
    }
}
public class NotificationService
{
    public void SendNotification(INotificationService notificationService, string message)
    {
        notificationService.SendNotification(message);
    }
}

public class Program {

    public static void Main(string[] args) {
        NotificationService service= new NotificationService();

        // Using different notification types
        service.SendNotification(new EmailNotification(), "Welcome to SOLID Lab!");
        service.SendNotification(new SMSService(), "System available!");
        service.SendNotification(new WhatsAppNotification(), "System update available!");
        }
}