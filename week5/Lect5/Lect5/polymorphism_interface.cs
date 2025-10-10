namespace polymorphism_interface
{
    public interface IVehicle
    {
        void StartEngine();
        string GetVehicleType();
    }
    public class Car: IVehicle{
        public void StartEngine(){
            Console.WriteLine("Car: Vrroom!");
        }
        public string GetVehicleType(){
        return "Car";
        }
    }
    public  class Truck: IVehicle{
        public void StartEngine(){
            Console.WriteLine("Truck: VRROOOM!");
        }
        public string GetVehicleType() {
            return "Truck";
        }
    }
}