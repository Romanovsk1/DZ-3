using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace DZ_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] DoubleMassiv = new int[2,3]
            {
                { 1,2,3 },
                { 4,5,6 }
            };
            
            Console.WriteLine("" + DoubleMassiv[0,0]);
            Console.WriteLine(" " + DoubleMassiv[0, 1]);
            Console.WriteLine("  " + DoubleMassiv[0, 2]);
            Console.WriteLine("   " + DoubleMassiv[1, 0]);
            Console.WriteLine("    " + DoubleMassiv[1, 1]);
            Console.WriteLine("     " + DoubleMassiv[1, 2]);
            
            
        } 
    }
}
