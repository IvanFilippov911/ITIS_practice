using System;

public class Program
{
    static void Main()
    {

        static bool IsSimple(int num)
        {
            if (num == 1 || num == 0) return false;
            for (int i = 2; i < num; i++) if (num % i == 0) return false;
            return true;
        }

        var lenght = 0;
        var sum = 0;
        
        for (int i = 1; i < 150; i++)
        {
            if (IsSimple(i))
            {
                lenght++;
                sum += i;
                if (IsSimple(sum) && sum < 1000) Console.Write($"Длина: {lenght}, сумма: {sum}\n");
            }
        }
    }
}
