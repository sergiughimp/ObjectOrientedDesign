namespace interface_
{
    public interface IVehicle
    {
        void StartEngine();
        void StopEngine();
        int CurrentSpeed { get; }
    }
    public class Car : IVehicle
    {
        public int CurrentSpeed { get; private set; }
        public void StartEngine()
        {
            Console.WriteLine("Car engine started");
            CurrentSpeed = 10;
        }
        public void StopEngine()
        {
            Console.WriteLine("Car engine stopped");
            CurrentSpeed = 0;
        }
        public void PlayMusic()
        {
            Console.WriteLine("Playing music...");
        }
    }
}