using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2Ex1
{
    //Павел Поздняков 
    //Написать метод, возвращающий минимальное из трёх чисел.
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите 1-е число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите 2-е число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите 3-е число: ");
            int c = int.Parse(Console.ReadLine());

            Minimum3(a,b,c);
            Console.ReadKey();


        }

        private static void Minimum3(int a, int b, int c)
        {
            
            if (b < a)
            {
                a = b;
            }
            if (c < a)
            {
                a = c;
            }
            Console.WriteLine($"Минимальное число: {a}");
        }
    }
}
