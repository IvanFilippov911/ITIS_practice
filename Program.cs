using System;
using System.Diagnostics;

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
        foreach (int i in array) Console.Write($"{i} ");
        // asdffdvfwfnlkafjiwddewdOWEJPOWJOPFED
        // asdlawf;qk[wqekfp;qwrfp;wqe;fpwmfp'qwf
    
    }




}
