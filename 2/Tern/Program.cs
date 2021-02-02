using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tern
{
    class Program
    {
        static int Max(int a, int b) 
        {
            /*if (a > b) return a;
            else return b;*/
            return a > b ? a : b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ваедите число:");
            int a = Convert.ToInt32(Console.ReadLine()); ;
            string str = (a % 2 == 0) ? "четное" : "не четное";
            Console.WriteLine(str);
        }
    }
}
