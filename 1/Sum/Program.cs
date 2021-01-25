using System;
using MyLibrary;
namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.Write("Введите первое число: ");
            s = Console.ReadLine();
            int a;
            //a = Convert.ToInt32(s);
            a = int.Parse(s);
            Console.Write("Введите второе число: ");
            s = Console.ReadLine();
            int b;
            b = int.Parse(s);
            int sum = a + b;
            Console.WriteLine(a+"+"+b+"="+sum.ToString());
            Console.WriteLine("{0}+{1}={2}",a,b,sum);
            Console.WriteLine($"{a}+{b}={sum}");
            //Print(10, 10, "Hello\n");
            Library.Pause("Press any key");
            

        }
    }
}
