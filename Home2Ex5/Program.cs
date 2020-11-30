using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Ex5
{
    //Павел Поздняков
    //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
    //массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
    //б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, Вас приветствует программа по рассчету индекса массы тела");
            Console.Write("Введите ваш рост в см: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Введите ваш вес в кг: ");
            double weight = double.Parse(Console.ReadLine());
            height = height / 100;                                   
            double i = weight / (height * height);
            Console.Write($"Ваш индекс массы тела: {i:F2}. ");       
            if (18.5 <= i && i <= 25) Console.WriteLine("Ваш вес в норме!");
            if (i < 18.5) Console.WriteLine($"Для нормы Вам нужно набрать: {(18.5-i) * height * height:F1}-{(25 - i) * height * height:F1} килограмм.");
            if (i > 25) Console.WriteLine($"Для нормы Вам нужно похудеть на: {(i -25) * height * height:F1}-{(i - 18.5) * height * height:F1} килограмм.");
            Console.ReadKey();
        }
    }
}
