using System;
using MyLibrary;

                                                    /*Домашнее задание*/


namespace HomeWork
{
    /*1. Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст,рост, вес). 
      * В результате вся информация выводится в одну строчку: а) используя склеивание;б) используя форматированный вывод;
        в) используя вывод со знаком $.*/
    class Program
    {
        private const string Msg = "Press any key"; //Константа 
        static double Sqrty( double x1, double x2, double y1, double y2) //Задача 3, б) 
        { 
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            #region Задачу №1
            /*1. Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст,рост, вес). 
             * В результате вся информация выводится в одну строчку: а) используя склеивание;б) используя форматированный вывод;в) используя вывод со знаком $.*/
            /*    string name, surname, age, grewup, weight;
                Console.Write("Имя:");
                name = Console.ReadLine();
                Console.Write("Фамилия:");
                surname = Console.ReadLine();
                Console.Write("Возраст:");
                age = Console.ReadLine();
                Console.Write("Рост:");
                grewup = Console.ReadLine();
                Console.Write("Вес:");
                weight = Console.ReadLine();
                Console.WriteLine(name+" "+surname+", "+age+" лет"+", "+grewup+" см"+", "+ weight+" кг");// потом переделать с условиями, чтобы восраст склонялся
                Console.WriteLine("{0} {1}, {2} года, {3} см, {4} кг",name,surname,age,grewup,weight);
                Console.WriteLine($"{name} {surname}, {age} года, {grewup} см, {weight} кг");
                Library.Pause("Msg");*/

            #endregion
            #region Задачу №2
            /*Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле
            I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.*/
            /*Console.Write("Вес: ");
            string str = Console.ReadLine();
            float m;
            //a = Convert.ToInt32(s);
            m = float.Parse(str);
            Console.Write("Рост: ");
            str = Console.ReadLine();
            float h;
            h = float.Parse(str);
            float IMT = m / (h * h);
            Console.WriteLine($"ИМТ = {IMT}");
            Library.Pause(Msg);*/
            #endregion
            #region Задача №3
            /*3.а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,y1 и x2,y2 по формуле 
             r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            Вывести результат,используя спецификатор формата .2f(с двумя знаками после запятой);
            б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.*/
         /*   double x1, x2, y1, y2;
            x1 = 2;
            x2 = 4;
            y1 = -5;
            y2 = 5;*/
            /*double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));*/
            Console.WriteLine("{0:F2}", Sqrty(2,4,-5,5));
            Library.Pause(Msg);
            #endregion
        }
    }
}
