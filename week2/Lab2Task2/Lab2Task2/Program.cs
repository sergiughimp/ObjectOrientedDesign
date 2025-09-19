using System;
namespace Lab2Task2
{

    public abstract class Shape
    {
        protected double area;
        protected string name;
        public abstract double CalculateArea();
        public void Display()
        {
            Console.WriteLine("The name of the Shape is: " + name + " and the Area is: " + area);
        }

    }
    public class Circle : Shape
    {
        private double radius;
        public Circle(double r)
        {
            radius = r;
            name = "Circle";
        }
        public override double CalculateArea()
        {
            area = Math.PI * radius * radius;
            return area;
        }

        
    }
    public class Rectangle : Shape
    {
        private double width;
        private double length;
        public Rectangle(double w, double l)
        {
            width = w;
            length = l;
            name = "Rectangle";
        }
        public override double CalculateArea()
        {
            area = width * length;
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Rectangle rectangle1 = new Rectangle(4, 6);

            circle1.CalculateArea();
            circle1.Display();

            rectangle1.CalculateArea();
            rectangle1.Display();
        }
    }
}
