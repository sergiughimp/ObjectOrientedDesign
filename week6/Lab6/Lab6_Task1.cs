
// namespace Lab6_Task1
// {
//     public class EmailService
//     {
//         public void Send(string message)
//         {
//             Console.WriteLine("Sending Email: " + message);
//         }
//     }
//     public class SMSService
//     {
//         public void Send(string message)
//         {
//             Console.WriteLine("Sending SMS: " + message);
//         }
//     }
//     public class WhatsAppService
//     {
//         public void Send(string message)
//         {
//             Console.WriteLine("Sending WhatsApp: " + message);
//         }
//     }
//     public class NotificationService
//     {
//         private EmailService emailService = new EmailService();
//         private SMSService smsService = new SMSService();
//         private WhatsAppService whatsappService = new WhatsAppService();

//         public void SendNotification(string message, string type)
//         {
//             if (type == "Email")
//                 emailService.Send(message);
//             else if (type == "SMS")
//                 smsService.Send(message);
//             else if (type == "WhatsApp")
//                 whatsappService.Send(message);
//             else
//                 Console.WriteLine("Unknown notification type");
//         }
//     }

//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             NotificationService service = new NotificationService();
//             service.SendNotification("Welcome to SOLID Lab!", "Email");
//             service.SendNotification("System update!", "SMS");
//             service.SendNotification("System update available!", "WhatsApp");

//         }
//     }
// }
