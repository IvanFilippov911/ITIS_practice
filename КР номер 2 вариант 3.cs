using System;
public class Program
{


    static void Main()
    {

        string[] arrayStr = Console.ReadLine().Split();
        int[] array = Array.ConvertAll(arrayStr, int.Parse);

        var len = 0.0;
        var sum = 0.0;

        for (int i = 0; i < array.Length; i++) 
        { 
            if (array[i] < 0)
            {
                sum += array[i];
                len++;
            }
        }
        Console.WriteLine(sum/len);
    }
}
