using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        if (!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Error! Invalid input for first number.");
            return;
        }

        Console.Write("Enter second number: ");
        if (!int.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Error! Invalid input for second number.");
            return;
        }

        Console.Write("Enter operator (&, |, ^): ");
        string? op = Console.ReadLine();

        if (op != "&" && op != "|" && op != "^")
        {
            Console.WriteLine("Error! Invalid operator.");
            return;
        }

        int result = 0;
        switch (op)
        {
            case "&":
                result = a & b;
                break;
            case "|":
                result = a | b;
                break;
            case "^":
                result = a ^ b;
                break;
        }

        Console.WriteLine("\nResult:");
        Console.WriteLine($"Decimal: {result}");
        Console.WriteLine($"Binary: {Convert.ToString(result, 2)}");
        Console.WriteLine($"Hexadecimal: {Convert.ToString(result, 16).ToUpper()}");
    }
}
