using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Task3
    {
        //        Пользователь вводит строку.Проверить, является ли
        //эта строка палиндромом.Палиндромом называется
        //строка, которая одинаково читается слева направо
        //и справа налево.
        public static void Palindrom()
        {
            Console.WriteLine("Enter your string:");
            string S1 = Console.ReadLine();
            string S2 = new string(S1.ToCharArray().Reverse().ToArray());
            if (S1 == S2)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Ne palindrom");
            } 
        }
    }
}
