using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2Ex7
{
    //Павел Поздняков
    //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
    //б) * Разработать рекурсивный метод, который считает сумму чисел от a до b
    class Program
    {
        static bool Check(int a, int b)
        {
            if (a > b) return true; else return false;
        }

        
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (Check(a, b))
            {
                Console.WriteLine("Число a должно быть меньше числа b");
            }
            else
            {
                Console.Write($"Числа от {a} до {b}: ");
                RecursiveAtoB(a, b);
                RecursiveAsumB(a, b, sum);
            }

            Console.ReadKey();
        }

        static int RecursiveAtoB(int a, int b)
        {
            Console.Write($"{a} ");
            if (a == b)
            {
                return a;
            }
            else
            {
                return RecursiveAtoB(a + 1, b);
            }
        }

        static int RecursiveAsumB(int a, int b, int sum)
        {

            if (a > b)
            { 
            Console.WriteLine($"\nСумма чисел от а до b: {sum}");
            return a;
            }
            else
            {
                return RecursiveAsumB(a + 1, b, sum = sum + a);
            }
        }
    }
}
