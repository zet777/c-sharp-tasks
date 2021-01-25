using System;
using MyLibrary;

namespace ChetnostChisla
{
    class Program
    {

        /*Задача 4.Разработать метод проверки чётности числа. Метод возвращает true,
                        если число чётное, и false, если число нечётное.*/
        static bool Odd(int n)
        {
            return n % 2 == 0;
        }
        static void Main(string[] args)
        {
            int value = 100501;
            Console.WriteLine(Odd(value));
            Library.Pause();
        }
        
    }
}
