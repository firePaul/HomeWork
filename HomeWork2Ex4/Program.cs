using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2Ex4
{
    //Павел Поздняков
    //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На
    //выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password:
    //GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь
    //вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью
    //цикла do while ограничить ввод пароля тремя попытками.
    class Program
    {
        static void Main(string[] args)
        {

            string login = "root";
            string password = "GeekBrains";
            int i = 3;
            Authorization(login, password, i);                    
            Console.ReadKey();                                        

        }

        private static int Authorization(string login, string password, int i)
        {
            do
            {
                Console.Write("Введите логин: ");
                string Userlogin = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string UserPassword = Console.ReadLine();
                if (Userlogin == login && UserPassword == password)
                {
                    Console.WriteLine("Вы успешно авторизованы!");
                    break;
                }
                else Console.WriteLine($"Неправильный логин или пароль. У вас осталось {i - 1} попытки.");
                i--;
            }
            while (i > 0);
            return i;
        }
    }
}
