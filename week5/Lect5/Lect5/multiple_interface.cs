namespace multiple_interface
{
    public interface IVehicle {
        void StartEngine();
    }
    public interface IFlyable{
        void Fly();
    }
    public class FlyingCar: IVehicle, IFlyable{
        public void StartEngine() {
            Console.WriteLine("Engine started");
        }
        public void Fly() {
            Console.WriteLine("Taking off!");
            }
    }
}