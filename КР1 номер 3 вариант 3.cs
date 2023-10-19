using System;
public class Program
{


    static void Main()                                         // [1 2 3 8]
                                                               // [2 1 5 9]
    {                                                          // [3 5 1 0]
                                                               // [8 9 0 1]        
        int[,] matrix = new int[4, 4] { {1, 2, 3, 8}, 
                                        {2, 1, 5, 9}, 
                                        {3, 5, 1, 0}, 
                                        {8, 9, 0, 1} };


        var result = true;
        for (int i = 0; i < 4; ++i)
        {
            for (int j = 0; j < 4; ++j)
                if (matrix[i, j] != matrix[j, i])
                {
                    result = false;
                    break;
                }
        }
        Console.WriteLine(result);
    }
}
