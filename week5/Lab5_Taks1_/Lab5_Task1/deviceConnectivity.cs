namespace deviceConnectivity
{
    // Base interface for all devices
    public interface IDevice
    {
        void EstablishConnection();
        void SendData(string text);
    }
    public interface ICommunicate
    {
        void SendData(string text);
    }
    public interface IConnect {
        void EstablishConnection();
    }

    public interface IWirelessCommunicate : ICommunicate {
        void ConnectToWifi();
    }
    public interface IWiredConnect : IConnect{
        void PlugInCable();
    }

    public class SmartPhone: IDevice, IConnect, IWirelessCommunicate {
        public void ConnectToWifi(){
            Console.WriteLine("Smart Phone: Connection to Wifi has been made");
        }
        public void EstablishConnection()
        {
            Console.WriteLine("Smart Phone: Connection has been established");
        }
        public void SendData(string text){
            Console.WriteLine($"I am sending some text from Smart Phone: {text}");
        }
    }

    public class DesktopComputer : IDevice, ICommunicate, IWiredConnect
    {
        public void PlugInCable()
        {
            Console.WriteLine("Desktop Computer: Plug in the cable");
        }
        public void EstablishConnection()
        {
            Console.WriteLine("Desktop Computer: Connection has been established");
        }
        public void SendData(string text){
            Console.WriteLine($"I am sending some text from Desktop Computer: {text}");
        }
    }

    public class Tablet: IDevice, IWirelessCommunicate, IWiredConnect{
        public void PlugInCable(){
            Console.WriteLine("Tablet: Plug in the cable");
        }
        public void ConnectToWifi(){
            Console.WriteLine("Tablet: Connection to Wifi has been made");
        }
        public void EstablishConnection()
        {
            Console.WriteLine("Tablet: Connection has been established");
        }
        public void SendData(string text){  
            Console.WriteLine($"I am sending some text from Tablet: {text}");
        }

    }
}