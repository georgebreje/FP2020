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
            //suma gauss
            Console.WriteLine("Introduceti un numar natural ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if(a<b)
            {
                if(a<c)
                {
                    Console.WriteLine($"{a} ");
                    if(b<c)
                    {
                        Console.WriteLine($"{b} {c}");
                    }
                    else
                    {
                        Console.WriteLine($"{c} {b}");
                    }
                }
                else
                {
                    Console.WriteLine($"{c} {a} {b}");
                }
            }
            else
            {
                if (b < c)
                {
                    Console.WriteLine($"{b}");
                    if (a < c)
                    {
                        Console.WriteLine($"{a} {c}");
                    }
                    else
                    {
                        Console.WriteLine($"{c} {a}");
                    }
                }
                else
                {
                    Console.WriteLine($"{c} {b} {a}");
                }
            }
        }
    }
}
