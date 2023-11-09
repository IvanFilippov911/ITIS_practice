using System;



public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите размерность первой матрицы, затем размерность второй матрицы. Например \"3 4 4 1\"");
        var sizeMatrices = (Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
        Console.WriteLine("-------------------------");
        
        var rowsMatrix1 = sizeMatrices[0];
        var columnsMatrix1 = sizeMatrices[1];
        var rowsMatrix2 = sizeMatrices[2];
        var columnsMatrix2 = sizeMatrices[3];

        if (columnsMatrix1 != rowsMatrix2)
            throw new ArgumentException("Кол-во столбцов первой матрицы должно равняться кол-ву строк второй матрицы!");

        var matrix1 = Program.CreateNewRandomMatrix(rowsMatrix1, columnsMatrix1);
        var matrix2 = Program.CreateNewRandomMatrix(rowsMatrix2, columnsMatrix2);

        Program.PrintMatrix(matrix1);
        Program.PrintMatrix(matrix2);

        Program.PrintMatrix(MultiplicationMatrix(matrix1, matrix2));
        Program.PrintMatrix(MatrixPow(matrix1, 4));
    
    }    
        
    private static int[,] CreateNewRandomMatrix(int rows, int columns)
    {
        Random random = new Random();
        var matrix = new int[rows, columns];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++) matrix[i, j] = random.Next(0, 9);
        return matrix;
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
                Console.Write($"{matrix[i, j]} ");
            
            Console.WriteLine();
        }
        Console.WriteLine("-------------------------");
    }

    private static int[,] MultiplicationMatrix(int[,] m1, int[,] m2)
    {
        var matrixResult = new int[m1.GetLength(0), m2.GetLength(1)];
        for (int i = 0; i < m1.GetLength(0); i++)
        {
            for (int j = 0; j < m2.GetLength(1); j++)
            {
                for (int k = 0; k < m1.GetLength(1); k++)
                    matrixResult[i, j] += (m1[i, k] * m2[k, j]);
            }
        }
        return matrixResult;
    }

    private static int[,] MatrixPow(int[,] matrix, int exp)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1)) 
            throw new ArgumentException("Матрица должна быть квадратной!");
        
        if (exp == 0)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j) matrix[i, j] = 1;
                    else matrix[i, j] = 0;
                }
            }
            return matrix;
        }
        if (exp == 1) return matrix;
        return Program.MultiplicationMatrix(MatrixPow(matrix, exp - 1), matrix);
    }
}
