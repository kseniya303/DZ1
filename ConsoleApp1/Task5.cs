using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Task5
    {
        public static void Sum_elem_of_array()
        {
            //Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
            // Определить сумму элементов массива, расположенных
            //между минимальным и максимальным элементами.
            Console.WriteLine("Array :");
            int[,] Arr = new int[5, 5];
            Random random = new Random();
            List<int> List_Arr = new List<int>();
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Arr[i, j] = random.Next(-100, 100);
                    Console.Write("{0,4} ", Arr[i, j]);
                    List_Arr.Add(Arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

             
            int Min_i = 0, Min_j = 0;
            int Max_i = 0, Max_j = 0;
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if (Arr[i, j] == List_Arr.Min())
                    {
                        Min_i = i;
                        Min_j = j;
                    }
                    else
                        if (Arr[i, j] == List_Arr.Max())
                        {
                          Max_i = i;
                          Max_j = j;
                        }
                }
            }
            Console.WriteLine("Min: " + List_Arr.Min());
            Console.WriteLine("Max: " + List_Arr.Max());
             
            int Temp;
            if (Min_j > Max_j)
            {
                Temp = Min_j;
                Min_j = Max_j;
                Max_j = Temp;
            }
            if (Min_i > Max_i)
            {
                Temp = Min_i;
                Min_i = Max_i;
                Max_i = Temp;
            }

            Console.Write("\nElements: ");
            List_Arr.Clear();
            for (int i = Min_i; i <= Max_i; i++)
            {
                for (int j = Min_j; j <= Max_j; j++)
                {
                    Console.Write(Arr[i, j]+" ");
                    List_Arr.Add(Arr[i, j]);
                }
            }
            Console.WriteLine("\n\nSum elements: " + List_Arr.Sum());
        }
    } 
}
