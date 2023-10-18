using System;
public class Program
{
    static double eps;

    static void Main()
    {

        var x1 = (1.0 / 5);
        var x2 = (1.0 / 239);

        Console.WriteLine("Введите eps: ");
        eps = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(16 * arctg(x1) - 4 * arctg(x2));


        static double arctg(double x)
        {
            var resultArctg = x;
            var x0 = x;
            var k = 1;

            while (Math.Abs(x0) > eps)
            {
                x0 = Math.Pow(-1, k) * Math.Pow(x, 2 * k + 1) / (2 * k + 1);
                k++;
                resultArctg += x0;
            }
            return resultArctg;
        }

    }
}


