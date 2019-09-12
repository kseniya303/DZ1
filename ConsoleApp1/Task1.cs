using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Task1
    {
        public static void Bobo()
        {
            Console.WriteLine("Enter 5 elements");
            int[] A = new int[5];
             
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nArray 1:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }

            Console.WriteLine("\n\nArray 2:");
            double[,] B = new double[3, 4];
            Random random = new Random(); 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = random.Next(10, 100)/10.0; 
                    Console.Write("{0,4} ", B[i, j]);
                }
                Console.WriteLine();
            }

            var MaxA= A.ToList().Max(); 
            var MaxB = (from double x in B select x).Max(); 
            if(MaxA>MaxB)
            {
                Console.WriteLine("\nMax element of Array A: " + MaxA);
            }
            else
            {
                Console.WriteLine("\nMax element of Array B: " + MaxB);
            }


            var MinA = A.ToList().Min(); 
            var MinB = (from double x in B select x).Min();
            if (MinA > MinB)
            {
                Console.WriteLine("\nMin element of Array A: " + MinA);
            }
            else
            {
                Console.WriteLine("\nMin element of Array B: " + MinB);
            }

            var SumA = A.ToList().Sum(); 
            var SumB = (from double x in B select x).Sum();
            if (SumA > SumB)
            {
                Console.WriteLine("\nSum element of Array A: " + SumA);
            }
            else
            {
                Console.WriteLine("\nSum element of Array B: " + SumB);
            }

            int result_A = 1;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                result_A *= A[i];
            } 
            

            double result_B = 1; 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    result_B *= B[i,j]; 
                } 
            }
            if (result_A > result_B)
            {
                Console.WriteLine("Multiplication of elements of the A array: " + result_A);
            }
            else
            {
                Console.WriteLine("\nMultiplication of elements of the B array: " + result_B);
            }
             
            int sum_even = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i] % 2 == 0)
                {
                    sum_even += A[i];
                } 
            }
            Console.WriteLine("\nSum of even elements of the A array: " + sum_even); 

            double sum_add = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j % 2 != 0)
                    {
                        sum_add += B[i, j];
                    }
                }
            }
            Console.WriteLine("\nMultiplication of elements of the B array: " + sum_add);

        }
    }
}
