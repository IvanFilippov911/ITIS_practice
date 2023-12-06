using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Matrix
    {

        private string fileName;
        public string file = "C:\\Рабочий стол\\ITIS Practice\\Matrix.txt";
        private int rows;
        private int columns;
        private int[,] matrix;

        public Matrix(string file)
        {
            var fileString = File.ReadAllLines(file);
            
            rows = Convert.ToInt32(fileString[0][0].ToString());
            columns = Convert.ToInt32(fileString[0][2].ToString());
            matrix = new int[rows, columns];

            for(int i = 1; i <= rows; i++)
            {
                string[] temp = fileString[i].Split();
                for (int j = 0; j < columns; j++)
                {
                    matrix[i - 1, j] = Convert.ToInt32(temp[j]);
                }
            }
        }

        public int[,] ReverseString()
        {
            int maxSum = int.MinValue;
            int minSum = int.MaxValue;
            int maxSumRow = 0;
            int minSumRow = 0;

            for (int i = 0; i < rows; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < columns; j++)
                {
                    rowSum += matrix[i, j];
                }
                if (rowSum > maxSum)
                {
                    maxSum = rowSum;
                    maxSumRow = i;
                }
                if (rowSum < minSum)
                {
                    minSum = rowSum;
                    minSumRow = i;
                }
            }

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int temp = matrix[maxSumRow, j];
                matrix[maxSumRow, j] = matrix[minSumRow, j];
                matrix[minSumRow, j] = temp;
            }
            return matrix;
        }

        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write($"{matrix[i, j],3} ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public int this[int i, int j]
        {
            get { return matrix[i, j]; }
        }
        public int Rows
        {
            get { return rows; }
            
        }
        public int Columns
        {
            get { return columns; }
        }

        

    }
}
