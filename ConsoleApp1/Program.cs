using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num2 != 0)
        {
            double result = num1 / num2;
            Console.WriteLine("El resultado de la división es: " + result);
        }
        else
        {
            Console.WriteLine("No se puede dividir por cero.");
        }
    }
}
