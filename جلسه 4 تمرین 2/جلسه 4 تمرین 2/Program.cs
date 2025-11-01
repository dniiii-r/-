using System;

class Program
{
    static void Main()
    {
        int position = -1;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            int num = int.Parse(Console.ReadLine());

            if (num == 2 && position == -1)
            {
                position = i + 1;
            }
        }

        if (position != -1)
            Console.WriteLine("Number 2 is found at position: " + position);
        else
            Console.WriteLine("Number 2 is not found");

            Console.ReadKey();
    }
}
