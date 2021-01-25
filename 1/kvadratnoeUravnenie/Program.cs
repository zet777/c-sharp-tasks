using System;
using MyLibrary;

/*Задача 2.Вывести значение функции ax^2+bx+c в точке x. x — ввести с
клавиатуры, a, b и c — присвоить в программе.*/

namespace kvadratnoeUravnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 24;
            double b = 12;
            double c = 35;
            double x;
            Console.Write("Введите значение x функции ax^2+bx+c: ");

            string str = Console.ReadLine();

            x = Convert.ToDouble(str);

            double f = a * Math.Pow(x, 2) + b * x + c;
            Console.WriteLine("{0}*x^2+{1}*x+{2}, при x={3}, f={4}", a, b, c, x,
            f);
            Console.WriteLine($"{a}*x+{b}*x^2+{c}, при x={x},то  функция равна {f}");
            Library.Pause("Press any Key");

        }
    }
}
