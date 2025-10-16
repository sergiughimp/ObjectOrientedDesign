// using System;
// public class NotificationService {
//     public void SendNotification(string message, string type) {
//         if(type== "Email")
//             Console.WriteLine("Sending Email: "+ message);
//         else
//             if(type== "SMS")
//                 Console.WriteLine("Sending SMS: "+ message);
//             else
//                 if(type== "WhatsApp")
//                     Console.WriteLine("Sending WhatsApp: "+ message);
//                 else
//                     Console.WriteLine("Unknown notification type");
//                 }
// }

// public class Program {

//     public static void Main(string[] args) {
//         NotificationService service= new NotificationService();
//         service.SendNotification("Welcome to SOLID Lab!", "Email");
//         service.SendNotification("System update available!", "WhatsApp");
//         }
// }