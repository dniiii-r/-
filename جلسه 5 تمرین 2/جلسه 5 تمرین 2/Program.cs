using System;

class Program
{
    static int Multiply(int a, int b)
    {
        if (b == 0)
            return 0;
        else if (b > 0)
            return a + Multiply(a, b - 1);
        else
            return -Multiply(a, -b);
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Multiplication = " + Multiply(a, b));
        Console.ReadKey();
    }
}
