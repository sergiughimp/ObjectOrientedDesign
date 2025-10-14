namespace openClosePrinciple{

public abstract class Shape
{
    public abstract double CalculateArea();
}
public class Rectangle: Shape {
    public double Width{ get; set; }
    public double Height{ get; set; }
    public override double CalculateArea() {
        return Width* Height;
    }
}
    public class AreaCalculator
    {
        public double CalculateArea(Shape shape)
        {
            return shape.CalculateArea();
        }
    }
}