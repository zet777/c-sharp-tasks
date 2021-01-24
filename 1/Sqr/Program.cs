using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqr
{
    class Program
    {
        static int Sqr(int x)
        {
            return x * x;
        }
        static void Main(string[] args)
        {
            int value = 777;
            Console.WriteLine("Квадрат числа "+value+" = "+ Sqr(value));
            Console.WriteLine("Квадрат числа {0} = {1}",value, Sqr(value));
            Console.WriteLine($"Квадрат числа {value} = {Sqr(value)}");
            Console.ReadLine();
        }
    }
}
