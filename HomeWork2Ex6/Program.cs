using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2Ex6
{
    //Павел Поздняков
    //*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
    //«Хорошим» называется число, которое делится на сумму своих цифр. Реализовать
    //подсчёт времени выполнения программы, используя структуру DateTime
    class Program
    {
        
        static bool Check(int a,int b)
        {
            if (a % b == 0) return true;
            else return false;      
        }

        static void Main(string[] args)
        {
            var start = DateTime.Now;
            int GoodNum = 0;
            for (int i = 1; i <= 1000000000; i++)
            {
                
                int sum = 0;
                int n = i;
                while (n>0)
                {
                    sum = sum + n % 10;
                    n = n / 10;
                }
                if (Check(i, sum))
                {
                    GoodNum++;
                }
                
            }
            Console.WriteLine($"'Хороших' чисел {GoodNum}");
            var end = DateTime.Now;
            var worktime = end - start;
            Console.WriteLine($"Время работы программы: {worktime}");               //Примерное время работы программы 1:20
            Console.ReadKey(); 
        }
    }
}
