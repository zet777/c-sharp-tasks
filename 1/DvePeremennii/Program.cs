using System;
using MyLibrary;
/*Написать программу обмена значениями двух переменных:
а) с использованием третьей переменной;
б) *без использования третьей переменной.
*/
namespace DvePeremennii
{

   /* Задача 3. Обменять значениями две переменные.*/
    class Program
    {
        static void Main(string[] args)
        {
            // Вариант №1
            int a = 2;
            int b = 5;
            int c = a; //2 
            a = b; //    a = 5
            b = c; //    b = 2

            // Вариант №2

            int w, x;
            w = 10;
            x = 2;
            Console.WriteLine("x=2, w =10");
            x = w; //10

            Console.WriteLine($"x={x}, w = ");
            Library.Pause("Press any key");



        }
    }
}
