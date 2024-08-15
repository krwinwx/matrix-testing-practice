using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[4, 4]
            {
                { 5, 5, 9, 4 },
                { 5, 9, 2, 4 },
                { 5, 2, 2, 6 },
                { 6, 6, 3, 4 }
            };
            Matrix matrix = new Matrix(m);
            Console.WriteLine(matrix.ToString());
            int sum = 0;
            int minI = matrix.RowSum(m,out sum);
            Console.WriteLine("Строка с мин. суммой эл-тов: " + (minI + 1) + ", сумма = " + sum);
            Console.WriteLine("\nКол-во нечет. эл-тов в строке с мин. суммой " + (minI + 1) + " = " + matrix.OddAmount(m,minI));
            Console.WriteLine("\nСумма эл-тов 4 строки: " + matrix.RowSum(m, 3));
            Console.WriteLine("\nМатрица квадратная? " + matrix.isSquare(m));


        }
    }
}
