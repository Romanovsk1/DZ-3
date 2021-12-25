using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет");
            Console.WriteLine("Введите что нибудь");
            string VodPolzovatelem;
            while ((VodPolzovatelem = Console.ReadLine()) != null)
                Console.WriteLine(new string(VodPolzovatelem.Reverse().ToArray()));
            
        }
    }
}
