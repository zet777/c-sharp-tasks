using System;
using MyLibrary;
namespace Sum
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();
            int a;
            //a = Convert.ToInt32(s);
            a = int.Parse(s);
            s = Console.ReadLine();
            int b;
            b = int.Parse(s);
            int sum = a + b;
            Console.WriteLine(a+"+"+b+"="+sum.ToString());
            Console.WriteLine("{0}+{1}={2}",a,b,sum);
            Console.WriteLine($"{a}+{b}={sum}");
            Library.Pause("Press any key");
            

        }
    }
}
