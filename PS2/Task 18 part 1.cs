using System;
using System.Data;

public class Program
{
    static double eps;

    static void Main()
    {

        Console.Write("Введите eps: ");
        var eps = Convert.ToDouble(Console.ReadLine());

        double n = 1.5;
        
        double y0 = 1 - (1.0 / 2) + (1.0 / 12) - (1.0 / 120);
        double y1 = n - Math.Log(2) - (1.0 / 4) + (1.0 / 48) - (1.0 / 1920);

        int k = 2;
        while (Math.Abs(y1 - y0) > eps)
        {
            y0 = y1;
            k++;
            n += 1.0 / k;
            y1 = (n - Math.Log(k) - (1.0 / (2 * k)) + (1.0 / (12 * k * k)) - (1.0 / (120 * k * k * k * k)));
        }

        Console.WriteLine($"Сумма: {y1}");
        Console.WriteLine($"Шаг: {k}");


        







    }
}


