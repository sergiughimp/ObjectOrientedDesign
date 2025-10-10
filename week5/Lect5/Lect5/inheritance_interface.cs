namespace inheritance_interface {
    public interface IShape
    {
        double GetArea();
    }
    public interface IColoredShape : IShape {
        string Color { get; set; }
        // double Radius{ get; set; }
    }
    public class ColoredCircle: IColoredShape {
        public double Radius{ get; set; }
        public string Color{ get; set; }
        public double GetArea() {
            return Math.PI* Radius* Radius;
        }
    }
}