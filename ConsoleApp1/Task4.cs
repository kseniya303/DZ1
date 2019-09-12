using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Task4
    {
        public static void Num_words()
        {
            // Подсчитать количество слов во введенном предложении.  
            string S;
            Console.WriteLine("Enter your string:");
            S = Console.ReadLine(); 
            string[] Wor = S.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
            // Метод Split разбивает строку на слова используя разделитель 
           // Второй параметр StringSplitOptions.RemoveEmptyEntries говорит, что надо удалить все пустые подстроки.
            Console.WriteLine("Words count: "+ Wor.Length);
        }
    }
}
