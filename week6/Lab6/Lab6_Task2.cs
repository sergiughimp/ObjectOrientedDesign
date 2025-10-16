// namespace Lab6_Task2 {

// public interface INotificationChannel
// {
//     public void Send(string message);
// }

// public class EmailService: INotificationChannel
// {
//     public void Send(string message)
//     {
//         Console.WriteLine("Sending Email: " + message);
//     }
// }
// public class SMSService : INotificationChannel
// {
//     public void Send(string message)
//     {
//         Console.WriteLine("Sending SMS: "+ message);
//     }
// }
// public class WhatsAppService : INotificationChannel
// {
//     public void Send(string message)
//     {
//         Console.WriteLine("Sending WhatsApp: " + message);
//     }
// }

// public class SlackService: INotificationChannel {
//     public void Send(string message){
//         Console.WriteLine("Sending Slack: " + message);
//     }
// }

// public class NotificationService
// {
//     public void SendNotification(string message, INotificationChannel channel)
//     {
//         channel.Send(message);
//     }
// }

//     public class Program
//     {

//         public static void Main(string[] args)
//         {
//             NotificationService service = new NotificationService();

//             EmailService emailService = new EmailService();
//             SMSService smsService = new SMSService();
//             WhatsAppService whatsAppService = new WhatsAppService();

//             SlackService slackService = new SlackService();

//             service.SendNotification("Email Message!", emailService);
//             service.SendNotification("Sms Message!", smsService);
//             service.SendNotification("WhatApp Message!", whatsAppService);

//             service.SendNotification("Slack Message!", slackService);
//         }
//     }
// }