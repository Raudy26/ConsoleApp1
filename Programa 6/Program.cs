using System;

class Program
{
    static void Main()
    {
        int a = 0, b = 1, c = 0;

        Console.WriteLine("Serie Fibonacci hasta el 50:");
        while (c <= 50)
        {
            Console.WriteLine(c);
            c = a + b;
            a = b;
            b = c;
        }
    }
}
