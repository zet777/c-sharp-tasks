using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string str = "Hello, Foreach";
            foreach (char c in str)
            {
                Console.WriteLine(c);
                if (c >= '0' && c <= '9'); 
                {

                }
            }*/
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int el in num)
            {
                if (el % 2 == 0) continue;
                Console.WriteLine(el);
                if (el == 5) break;   
            }
        }
    }
}
