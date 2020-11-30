using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2Ex3
{
    //Павел Поздняков
    //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных
    //положительных чисел
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            for (int i = 0; ; i++)
            {
                Console.Write($"Введите {i + 1}-е число: ");
                int t = int.Parse(Console.ReadLine());
                if (t == 0) break;
                if (t % 2 != 0 && t > 0) sum = sum + t;

            }

            Console.Write($"Сумма всех нечетных положительных чисел равна: {sum}");

            Console.ReadKey();

        }
    }
}
