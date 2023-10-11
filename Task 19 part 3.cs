using System;


public class Program
{
    static void Main()
    {

        while (true)
        {
            var number = Convert.ToInt32(Console.ReadLine());
            if (number == 0) break;
            else if (number < 0) Console.WriteLine(Math.Abs(number));
            else
            {
                var exp = 0;
                while (Math.Pow(2, exp) < number)
                {
                    exp++;
                }
                Console.WriteLine(Math.Pow(2, exp));
            }
        }
    }
}
