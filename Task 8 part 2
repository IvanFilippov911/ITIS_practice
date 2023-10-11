using System;


public class Program
{
    static void Main()
    {
        static double FastExp(double n, int k)
        {
            if (k == 0) return 1;
            else if (k % 2 != 0) return FastExp(n, k - 1) * n;
            else
            {
                var bin = FastExp(n, k / 2);
                return bin * bin;
            }

        }

        Console.WriteLine(FastExp(4, 3)); // 64
        Console.WriteLine(FastExp(56, 2)); // 3 136
        Console.WriteLine(FastExp(23, 4)); // 279 841
        Console.WriteLine(FastExp(7, 9)); // 40 353 607
    }
}
