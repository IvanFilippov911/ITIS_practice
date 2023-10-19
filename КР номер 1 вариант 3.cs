using System;
public class Program
{


    static void Main()
    {

        int n = Convert.ToInt32(Console.ReadLine());
        Random random = new Random();
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
        array[i] = random.Next(-100, 100);
        }
        
        foreach (var item in array) Console.Write($"{item} ");  
        Console.WriteLine();
        
        var itemPositive = 0;
        var countPositive = 0;
        var itemNegative = 0;
        var countNegative = 0;

        var j = -1;
        while (countPositive != 2)
        {
            j++;
            if (array[j] > 0) countPositive++;
            
        }
        itemPositive = j;

        var k = -1;
        while (countNegative != 2)
        {
            k++;
            if (array[array.Length - k - 1] < 0) countNegative++;

        }
        itemNegative = array.Length - k - 1;
        
        var replace = array[itemPositive];
        array[itemPositive] = array[itemNegative];
        array[itemNegative] = replace;

        foreach (var item in array) Console.Write($"{item} ");
    }
}
