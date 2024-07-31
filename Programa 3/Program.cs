using System;               //Formula que usare F(x)=2x                       

class Program
{       
   
    static void Main()
    {
        Console.Write("Ingrese el valor de x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double result = 2 * x;
        Console.WriteLine("El resultado de la fórmula es: " + result);
    }
}
