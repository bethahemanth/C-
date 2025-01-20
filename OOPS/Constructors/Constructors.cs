using System;

public class constructors
{
    int id;
    string name;
    int age;
    private static constructors ins;

    // Default Constructor
    public constructors()
    {
        Console.WriteLine("Default Constructor");
    }

    // Parameterized Constructor
    public constructors(int id, string name, int age)
    {
        this.id = id;
        this.name = name;
        this.age = age;
    }

    // Singleton Pattern
    public static constructors getInstance()
    {
        if (ins == null)
        {
            ins = new constructors();
        }
        return ins;
    }

    // Copy Constructor
    public constructors(constructors c)
    {
        this.id = c.id;
        this.name = c.name;
        this.age = c.age;
        Console.WriteLine($"Id: {c.id} Name: {c.name} Age: {c.age}");
    }
    //static constructor
    static constructors()
    {
        Console.WriteLine("Initialized when a static member is called");
    }

    public static void Main(string[] args)
    {
        constructors c1 = new constructors();
        constructors c2 = new constructors(1, "John", 25);
        constructors c3 = new constructors(c2);
    }
}
