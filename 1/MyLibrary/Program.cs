using System;


namespace MyLibrary
{
    public class Library
    {
        public static void Pause()
        {
            Console.ReadKey();
        }
        public static void Pause(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
