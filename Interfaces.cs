using System;

interface IMovable
{
    void Move();
}
// Example classes implementing the IMovable interface
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}
// Example classes implementing the IMovable interface
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}
class Program
{
    // Main method to demonstrate the use of instances of Car and Bicycle
    static void Main()
    {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();

        car.Move();        // Output: Car is moving

        bicycle.Move();    // Output: Bicycle is
    }
    }
