using System;

namespace PR_4
{
    public class Matrix
    {
        int[,] matrix;
        public Matrix(int m, int n)
        {
            this.matrix = new int[m, n];
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    this.matrix[i, j] = random.Next(0, 10);
        }
        public Matrix(int[,] m)
        {
            this.matrix = m;
        }
        public override string ToString()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            return "";
        }
        public bool isSquare(int[,] m)
        {
            if (m.GetLength(0) == m.GetLength(1)) return true;
            else return false;
        }
        public int RowSum(int[,] mas, out int minCount)
        {
            minCount = 0;
            int count = 0, i = 0, j = 0, minI = 0;
            for (i = 0; i < mas.GetLength(1); i++)
                minCount += mas[0, i];
            for (i = 1; i < mas.GetLength(0); i++)
            {
                for (j = 0; j < mas.GetLength(1); j++)
                    count += mas[i, j];
                if (minCount > count)
                {
                    minCount = count;
                    minI = i;
                    count = 0;
                }
            }
            return minI;
        }
        public int RowSum(int[,] mas, int k)
        {
            int count = 0, i = 0, j = 0;
            for (j = 0; j < mas.GetLength(1); j++)
                count += mas[k, j];
            return count;
        }
        public int OddAmount(int[,] mas, int minI)
        {
            int oddCount = 0;
            for (int j = 0; j < mas.GetLength(1); j++)
                if (mas[minI, j] % 2 != 0)
                    oddCount++;
            return oddCount;
        }
    }
}
