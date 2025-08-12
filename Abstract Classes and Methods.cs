using System;

abstract class Shape
{
    // Abstract method to get the area of the shape
    public abstract double GetArea();
}
// Concrete classes inheriting from Shape
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}
// Rectangle class inheriting from Shape
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}
// Instances of Circle and Rectangle, and their areas
class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);

        Rectangle rectangle = new Rectangle(4, 6);
    }
}

