using System;
using MyLibrary;

namespace PlochadTriugolnika
{
    /*Задача 6. Написать программу для подсчета площади треугольника.*/
    class Program
    {
        static bool IsTriangle(double a, double b, double c) // Стороны треугольника
        {
            return a + b > c && a + c > b && c + b > a; //Проверка на правильность триугольника. Так как метод булевый, т о возвращает tru или false
        }
        static double S(double a, double b, double c)
        {
            double p = (a + b + c) / 2; // Находим полупериметр, что бы потом применить его в формуле Герона
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));// (Math.Sqrt - квадратный корень) Площадь находим по форумле Герона 
        }
        static void Main(string[] args)
        {
            Console.Write("Серега Привет!" +
                "");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Может существовать треугольник с такими сторонами: " + IsTriangle (a, b, c));
            Console.WriteLine("Площадь треугольника:" + S(a, b, c));
            Library.Pause("Press any key");
        }

    }
}
