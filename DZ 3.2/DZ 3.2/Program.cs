using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] arraySpravochnik = new string[5, 2];
            
            arraySpravochnik[0, 0] = "Nikita";
            arraySpravochnik[0, 1] = "nikita@yandex.ru";
            
            arraySpravochnik[1, 0] = "Nikolay";
            arraySpravochnik[1, 1] = "nikolay@google.com";

            arraySpravochnik[2, 0] = "Validol";
            arraySpravochnik[2, 1] = "validol@uray.ua";

            arraySpravochnik[3, 0] = "Gnomich";
            arraySpravochnik[3, 1] = "gnomich@yandex.ru";

            arraySpravochnik[4, 0] = "Vladimir";
            arraySpravochnik[4, 1] = "vladimir@ad.ru";

            int rows = arraySpravochnik.GetUpperBound(0) + 1;    // количество строк
            int columns = arraySpravochnik.Length / rows;        // количество столбцов
                                                        

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"\t{arraySpravochnik[i, j]} \t");
                }
                Console.WriteLine();
            }



        }
    }
}
