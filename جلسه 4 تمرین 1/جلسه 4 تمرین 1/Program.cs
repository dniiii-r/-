using System;

class Program
{
    static void Main()
    {
        int even = 0;
        int odd = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                even++;
            else
                odd++;
        }

        Console.WriteLine("Even numbers: " + even);
        Console.WriteLine("Odd numbers: " + odd);

        Console.ReadKey();
    }
}