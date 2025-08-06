using System;

class Animal
{
    // Base class for animals
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}
// Derived classes for Dog that override the MakeSound method
class Dog : Animal
{
    // MakeSound method for Dog
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
// Derived class for Cat that overrides the MakeSound method
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}
// Main program to demonstrate polymorphism
class Program
{
    static void Main()
    {
        // Create instances of Animal, Dog, and Cat
        Animal genericAnimal = new Animal();
        Dog dog = new Dog();