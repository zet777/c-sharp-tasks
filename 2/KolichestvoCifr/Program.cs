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


            int age, cnt = 0;
            do
            {
                Console.WriteLine("Введите возраст:");
                age = int.Parse(Console.ReadLine());
                cnt++;
            }
            while (age < 1 || age > 99);// Повторять условие истинно(true)
            Console.WriteLine($"Вы сделали {cnt} попыток ввода");
            

        }
    }
}
