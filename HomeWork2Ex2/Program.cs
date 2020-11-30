using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2Ex2
{
    //Павел Поздняков
    //Написать метод подсчета количества цифр числа.

    class Program
    {
        

        static void Main(string[] args)
        {

            NumeralCount();
            LengthMethod();
            Console.ReadKey();

        }

        
        private static void LengthMethod()
        {
            Console.Write("Введите число: ");
            string a = Console.ReadLine();
            int b = a.Length;
            if (char.IsPunctuation(a, 0)) b = b - 1;        // для отрицательных чисел
            Console.WriteLine($"В числе {b} цифр");
        }

        private static void NumeralCount()
        {
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            a = Math.Abs(a);                                // для отрицательных чисел
            int numeral = 0;                                
            if (a == 0) numeral++;                          // если введен 0
            while (a != 0)
            {
                a = a / 10;
                numeral++;
            }
            Console.WriteLine($"В числе {numeral} цифр");
        }

        

    }
}
