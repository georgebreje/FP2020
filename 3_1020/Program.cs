using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar natural ");
            int n = int.Parse(Console.ReadLine());
            int suma;
            suma = n * (n + 1) / 2;
            Console.WriteLine($"Suma numerelor de la 1 la {n} este {suma}");
        }
    }
}
