using System;

class Program
{
    static double Perimeter(double a, double b, double c)
    {
        return a + b + c;
    }

    static double Area(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    static void Main()
    {
        Console.Write("Enter side A: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter side B: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter side C: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("Perimeter of the triangle = " + Perimeter(a, b, c));
        Console.WriteLine("Area of the triangle = " + Area(a, b, c));
        Console.ReadKey();
    }
}
