namespace dependencyInversionPrinciple
{
    // slide 17: Following DIP
    public interface IMessageService
    {
        void SendMessage(string message);
    }
    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }
    }
    public class SMSService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending SMS: " + message);
        }
    }

    // slide 18: Following DIP
    public class Notification
    {
        private IMessageService _messageService;
        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }
        public void Send(string message)
        {
            _messageService.SendMessage(message);
        }
    }
}