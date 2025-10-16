// using System;

// public interface INotificationChannel
// {
//     public void Send(string message);
// }

// public interface ISchedulable {
//     public void Schedule(string message, DateTime time);
// }
// public class EmailService : INotificationChannel, ISchedulable
// {
//     public void Send(string message)
//     {
//         Console.WriteLine("Sending Email: " + message);
//     }
//     public void Schedule(string message, DateTime time)
//     {
//         Console.WriteLine($"Email scheduled at {time}: {message}");
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

// public class SlackService : INotificationChannel
// {
//     public void Send(string message)
//     {
//         Console.WriteLine("Sending Slack: " + message);
//     }
// }
// public class TestChannel : INotificationChannel
// {
//     public void Send(string message)
//     {
//         Console.WriteLine("Test Channel: " + message);
//     }
// }

// public class NotificationService
// {
//     public void SendNotification(string message, INotificationChannel channel)
//     {
//         channel.Send(message);
//     }

//     public void ScheduleNotification(string message, DateTime time, ISchedulable schedulable)
//     {
//         schedulable.Schedule(message, time);
//     }
// }

// public class Program
// {

//     public static void Main(string[] args)
//     {
//         NotificationService service = new NotificationService();


//         TestChannel testChannel = new TestChannel();
//         EmailService emailService = new EmailService();
//         SMSService smsService = new SMSService();
//         WhatsAppService whatsAppService = new WhatsAppService();
//         SlackService slackService = new SlackService();


//         service.SendNotification("Sms Message!", testChannel);
//         service.SendNotification("Sms Message!", smsService);
//         service.SendNotification("WhatApp Message!", whatsAppService);
//         service.SendNotification("Slack Message!", slackService);

//         // service.SendNotification("Email Message!", emailService);
//         service.ScheduleNotification("Scheduled Email", DateTime.Now.AddMinutes(2), emailService);
//     }
// }
