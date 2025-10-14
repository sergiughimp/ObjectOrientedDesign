namespace interfaceSegregationPrinciple
{
    public interface IWorkable
    {
        void Work();
    }
    public interface IFeedable
    {
        void Eat();
    }
    public interface IMeetingAttendee
    {
        void AttendMeeting();
    }
    public class RobotWorker : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot working...");
        }
    }
    public class HumanWorker : IWorkable, IFeedable, IMeetingAttendee
    {
        public void Work()
        {
            Console.WriteLine("Human working...");
        }
        public void Eat()
        {
            Console.WriteLine("Eating lunch...");
        }
        public void AttendMeeting()
        {
            Console.WriteLine("In meeting...");
        }
    }
}