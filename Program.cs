using System;
using System.Collections.Generic;

abstract class Animal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }

    public string GetName() => Name;
    public string GetColour() => Colour;
    public int GetAge() => Age;

    public void SetName(string name) => Name = name;
    public void SetColour(string colour) => Colour = colour;
    public void SetAge(int age) => Age = age;

    public abstract void Eat();
}

class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Dogs eat meat.");
    }
}

class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }
}

interface IAnimal
{
    string Name { get; set; }
    string Colour { get; set; }
    double Height { get; set; }
    int Age { get; set; }

    void Eat();
    string Cry();
}

class Dog2 : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public double Height { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Dogs eat meat");
    }

    public string Cry()
    {
        return "Woof!";
    }
}

class Cat2 : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public double Height { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Cats eat mice");
    }

    public string Cry()
    {
        return "Meow!";
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter a dog name: ");
        string dogName = Console.ReadLine();
        Dog2 myDog = new Dog2(); // Corrected instantiation

        myDog.Name = dogName;

        Console.Write("Enter dog height: ");
        myDog.Height = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter dog colour: ");
        myDog.Colour = Console.ReadLine();
        Console.Write("Enter dog age: ");
        myDog.Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Dog Details:\nName: {myDog.Name}\nHeight: {myDog.Height}\nColour: {myDog.Colour}\nAge: {myDog.Age}");

        myDog.Eat();
        Console.WriteLine($"Dog says: {myDog.Cry()}");

        Console.Write("\nEnter a cat name: ");
        string catName = Console.ReadLine();
        Cat2 myCat = new Cat2(); // Corrected instantiation

        myCat.Name = catName;

        Console.Write("Enter cat height: ");
        myCat.Height = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter cat colour: ");
        myCat.Colour = Console.ReadLine();
        Console.Write("Enter cat age: ");
        myCat.Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nCat Details:\nName: {myCat.Name}\nHeight: {myCat.Height}\nColour: {myCat.Colour}\nAge: {myCat.Age}");

        myCat.Eat();
        Console.WriteLine($"Cat says: {myCat.Cry()}");

        List<IAnimal> animals = new List<IAnimal>
        {
            myDog,
            myCat
        };

        Console.WriteLine("\nNames of all animals:");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Name);
        }
    }
}


