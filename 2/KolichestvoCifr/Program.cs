using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolichestvoCifr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число и мы вычислим сколько цифр в нем");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            while (num != 0)
            {
                count++;
                num = num / 10;//так как n-целое, деление целочисленное
            }
            Console.WriteLine(count);
        }
    }
}
