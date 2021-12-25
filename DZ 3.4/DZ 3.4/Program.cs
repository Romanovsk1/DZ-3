using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] MorskoyBoi = new char[10, 10];
            int rows = MorskoyBoi.GetUpperBound(0) + 1;    // количество строк
            int columns = MorskoyBoi.Length / rows;        // количество столбцов

            MorskoyBoi[0, 0] = 'X';
            MorskoyBoi[0, 1] = 'O';
            MorskoyBoi[0, 2] = 'O';
            MorskoyBoi[0, 3] = 'O';
            MorskoyBoi[0, 4] = 'O';
            MorskoyBoi[0, 5] = 'X';
            MorskoyBoi[0, 6] = 'X';
            MorskoyBoi[0, 7] = 'O';
            MorskoyBoi[0, 8] = 'O';
            MorskoyBoi[0, 9] = 'O';
            
            MorskoyBoi[1, 0] = 'O';
            MorskoyBoi[1, 1] = 'O';
            MorskoyBoi[1, 2] = 'X';
            MorskoyBoi[1, 3] = 'O';
            MorskoyBoi[1, 4] = 'O';
            MorskoyBoi[1, 5] = 'O';
            MorskoyBoi[1, 6] = 'O';
            MorskoyBoi[1, 7] = 'O';
            MorskoyBoi[1, 8] = 'X';
            MorskoyBoi[1, 9] = 'X';
            
            MorskoyBoi[2, 0] = 'X';
            MorskoyBoi[2, 1] = 'O';
            MorskoyBoi[2, 2] = 'X';
            MorskoyBoi[2, 3] = 'O';
            MorskoyBoi[2, 4] = 'O';
            MorskoyBoi[2, 5] = 'O';
            MorskoyBoi[2, 6] = 'O';
            MorskoyBoi[2, 7] = 'O';
            MorskoyBoi[2, 8] = 'O';
            MorskoyBoi[2, 9] = 'O';
            
            MorskoyBoi[3, 0] = 'O';
            MorskoyBoi[3, 1] = 'O';
            MorskoyBoi[3, 2] = 'O';
            MorskoyBoi[3, 3] = 'O';
            MorskoyBoi[3, 4] = 'O';
            MorskoyBoi[3, 5] = 'O';
            MorskoyBoi[3, 6] = 'O';
            MorskoyBoi[3, 7] = 'O';
            MorskoyBoi[3, 8] = 'O';
            MorskoyBoi[3, 9] = 'O';
            
            MorskoyBoi[4, 0] = 'X';
            MorskoyBoi[4, 1] = 'O';
            MorskoyBoi[4, 2] = 'X';
            MorskoyBoi[4, 3] = 'O';
            MorskoyBoi[4, 4] = 'O';
            MorskoyBoi[4, 5] = 'O';
            MorskoyBoi[4, 6] = 'O';
            MorskoyBoi[4, 7] = 'O';
            MorskoyBoi[4, 8] = 'X';
            MorskoyBoi[4, 9] = 'O';

            MorskoyBoi[5, 0] = 'X';
            MorskoyBoi[5, 1] = 'O';
            MorskoyBoi[5, 2] = 'X';
            MorskoyBoi[5, 3] = 'O';
            MorskoyBoi[5, 4] = 'O';
            MorskoyBoi[5, 5] = 'O';
            MorskoyBoi[5, 6] = 'O';
            MorskoyBoi[5, 7] = 'O';
            MorskoyBoi[5, 8] = 'O';
            MorskoyBoi[5, 9] = 'O';

            MorskoyBoi[6, 0] = 'O';
            MorskoyBoi[6, 1] = 'O';
            MorskoyBoi[6, 2] = 'O';
            MorskoyBoi[6, 3] = 'O';
            MorskoyBoi[6, 4] = 'X';
            MorskoyBoi[6, 5] = 'O';
            MorskoyBoi[6, 6] = 'O';
            MorskoyBoi[6, 7] = 'O';
            MorskoyBoi[6, 8] = 'O';
            MorskoyBoi[6, 9] = 'X';

            MorskoyBoi[7, 0] = 'X';
            MorskoyBoi[7, 1] = 'O';
            MorskoyBoi[7, 2] = 'O';
            MorskoyBoi[7, 3] = 'O';
            MorskoyBoi[7, 4] = 'O';
            MorskoyBoi[7, 5] = 'O';
            MorskoyBoi[7, 6] = 'O';
            MorskoyBoi[7, 7] = 'O';
            MorskoyBoi[7, 8] = 'O';
            MorskoyBoi[7, 9] = 'X';

            MorskoyBoi[8, 0] = 'X';
            MorskoyBoi[8, 1] = 'O';
            MorskoyBoi[8, 2] = 'O';
            MorskoyBoi[8, 3] = 'O';
            MorskoyBoi[8, 4] = 'O';
            MorskoyBoi[8, 5] = 'O';
            MorskoyBoi[8, 6] = 'O';
            MorskoyBoi[8, 7] = 'O';
            MorskoyBoi[8, 8] = 'O';
            MorskoyBoi[8, 9] = 'X';

            MorskoyBoi[9, 0] = 'X';
            MorskoyBoi[9, 1] = 'O';
            MorskoyBoi[9, 2] = 'O';
            MorskoyBoi[9, 3] = 'O';
            MorskoyBoi[9, 4] = 'O';
            MorskoyBoi[9, 5] = 'O';
            MorskoyBoi[9, 6] = 'O';
            MorskoyBoi[9, 7] = 'O';
            MorskoyBoi[9, 8] = 'O';
            MorskoyBoi[9, 9] = 'X';

            

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{MorskoyBoi[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
