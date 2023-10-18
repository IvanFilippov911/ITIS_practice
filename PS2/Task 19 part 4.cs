using System;
public class Program
{


    static void Main()
    {
        int n = 10000000, a = 1, b = 2;
        Console.WriteLine($"Левый прямоугольник: {LeftRectangle(a, b, n)}");
        Console.WriteLine($"Правый прямоугольник: {RightRectangle(a, b, n)}");
        Console.WriteLine($"Трапеция: {TrapezoidMethod(a, b, n)}");
        Console.WriteLine($"Симпсон: {SimpsonMethod(a, b, n)}");
        Console.WriteLine($"Монте Карло: {MontecarloMethod(a, b, n)}");
    }
    public static double Function(double x)
    {
        return Math.Cos(2 * Math.Cos(Math.Sin(x)));
    }
    public static double LeftRectangle(double a, double b, int n)
    {
        var h = (b - a) / n;
        double sum = 0;
        for (var i = 0; i <= n - 1; i++)
        {
            var x = a + i * h;
            sum += Function(x);
        }
        return h * sum;
    }
    public static double RightRectangle(double a, double b, int n)
    {
        var h = (b - a) / n;
        double sum = 0;
        for (var i = 1; i <= n; i++)
        {
            var x = a + i * h;
            sum += Function(x);
        }
        return h * sum;
    }

    public static double TrapezoidMethod(double a, double b, int n)
    {
        var h = (b - a) / n;
        double sum = 0;
        for (var i = 1; i < n; i++) sum += Function(a + i * h) * ((a + h * (i + 1)) - (a + h * (i - 1)));
        return 1 / 2.0 * (h * Function(a)+ sum + Function(b) * (b - (a + h * (n - 1))));
    }

    public static double SimpsonMethod(double a, double b, int n)
    {
        var h = (b - a) / n;
        double sum1 = 0, sum2 = 0;
        for (var k = 1; k <= n; k++)
        {
            var x1 = k * h + a;
            if (n - 1 >= k) sum1 += Function(x1);
            var xK2 = a + (k - 1) * h;
            sum2 += Function((x1 + xK2) / 2);
        }
        return h / 3.0 * (1.0 / 2.0 * Function(a) + sum1 + 2 * sum2 + 1.0 / 2.0 * Function(b));
    }

    public static double MontecarloMethod(double a, double b, int n)
    {
        double sum = 0;
        Random r = new Random();
       
        for (var i = 1; i <= n; i++) sum += Function(r.Next((int)a * 10, (int)b * 10) / 10.0);
        return sum * (b - a) / n;
    }
}



