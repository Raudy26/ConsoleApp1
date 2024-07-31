using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (EsPrimo(num))
        {
            Console.WriteLine(num + " es un número primo.");
        }
        else
        {
            Console.WriteLine(num + " no es un número primo.");
        }
    }

    static bool EsPrimo(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
