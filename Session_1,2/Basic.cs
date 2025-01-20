using System;

public class Basic
{
    public void DisplayMessage()
    {
        int a = 5, b = 3;
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine($"Addition:{a}+{b}={a+b}");
        Console.WriteLine($"Subtraction:{a}-{b}={a-b}");
        Console.WriteLine($"Multiplication:{a}*{b}={a*b}");
        Console.WriteLine($"Division:{a}/{b}={a/b}");
        Console.WriteLine($"Modulus:{a}%{b}={a%b}");
    }

    public bool IsEligible(int age, bool hasID)
    {
        Console.WriteLine("\nRelational and Logical Operators:");
        Console.WriteLine($"Age>18: {age>18}");
        Console.WriteLine($"Has ID: {hasID}");
        return (age>18&&hasID);
    }

    public void UpdateValues()
    {
        Console.WriteLine("\nAssignment and Bitwise Operators:");
        int x = 10, y = 5;
        Console.WriteLine($"Initial Value of x: {x}");
        x += y;
        Console.WriteLine($"After x+=y: {x}");
        x *= 2;
        Console.WriteLine($"After x*=2: {x}");
        int a = 6, b = 3;
        Console.WriteLine($"a={a}, b={b}");
        Console.WriteLine($"Bitwise AND (a&b):{a&b}");
        Console.WriteLine($"Bitwise OR (a|b):{a|b}");
        Console.WriteLine($"Bitwise XOR (a^b):{a^b}");
        Console.WriteLine($"Bitwise Complement(~a):{~a}");
        Console.WriteLine($"Left Shift (a<<1):{a<<1}");
        Console.WriteLine($"Right Shift (a>>1):{a>>1}");
    }

    public dynamic DynamicOperation(dynamic x, dynamic y, string operation)
    {
        Console.WriteLine("\nDynamic Operations:");
        switch (operation)
        {
            case "+": return x + y;
            case "-": return x - y;
            case "*": return x * y;
            case "/": return x / y;
            case "%": return x % y;
            default: throw new InvalidOperationException("Invalid operation");
        }
    }

    public static void Main()
    {
        Basic b = new Basic();
        b.DisplayMessage();
        bool eligible = b.IsEligible(20, true);
        Console.WriteLine($"Is eligible to vote: {eligible}");
        b.UpdateValues();
        Console.WriteLine("Dynamic Method Results:");
        Console.WriteLine($"Addition: {b.DynamicOperation(10, 5, "+")}");
        Console.WriteLine($"Subtraction: {b.DynamicOperation(10, 5, "-")}");
        Console.WriteLine($"Multiplication: {b.DynamicOperation(10, 5, "*")}");
        Console.WriteLine($"Division: {b.DynamicOperation(10, 5, "/")}");
        Console.WriteLine($"Modulus: {b.DynamicOperation(10, 5, "%")}");
    }
}
