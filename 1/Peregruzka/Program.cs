using System;
using MyLibrary;

namespace Peregruzka
{
    class Program
    {
        static void Print(string msg, int x, int y)
        {
            // Установим позицию курсора на экране
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        static void Print(string msg, ConsoleColor backgroundcolor, ConsoleColor foregroundcolor)
        {
            // Установим цвет символов
            Console.BackgroundColor = backgroundcolor;
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(msg);
        }

        static void Print(string msg, ConsoleColor backgroundcolor, ConsoleColor foregroundcolor, int x, int y)
        {
            // Установим позицию курсора на экране и цвет символов
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
            Console.BackgroundColor = backgroundcolor;
            Console.ForegroundColor = foregroundcolor;
            
        }

        static void Main(string[] args)
        {
            Print("Тестируем текст с позицией\n", 10, 10);
            Print("Тестируем текст с цветом\n", ConsoleColor.Magenta, ConsoleColor.Blue);
            Print("Тестируем текст с цветом\n", ConsoleColor.Red, ConsoleColor.White, 15, 15);// цвет не меняется
         
            Library.Pause("");
        }
    }
}
