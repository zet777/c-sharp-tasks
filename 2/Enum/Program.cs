using System;
using MyLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum MyColor 
        {
            Black =0,
            Red = ConsoleColor.Red,
            Green = 0x00FF00,
            Blue = 0x0000FF
        }
            
        static void Main(string[] args)
        {
            Console.ForegroundColor = (ConsoleColor)MyColor.Red;
            Console.WriteLine("Hello, Word!");
            Library.Pause("Press any key");
        }
    }
}
