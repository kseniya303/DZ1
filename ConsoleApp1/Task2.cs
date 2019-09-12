using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Task2
    {
        public static void Bob()
        { 
            int M, N;
            Console.WriteLine("Enter size for the A array:");
            M = int.Parse(Console.ReadLine());
            int[] A = new int[M];   
            Console.WriteLine("\nArray 1:");
            Random random = new Random();
            for (int i = 0; i < M; i++)
            {              
                A[i] = random.Next(0, 50);
                Console.Write(A[i] + " ");
            }

            Console.WriteLine("\n\nEnter size for the B array:");
            N = int.Parse(Console.ReadLine());
            int[] B = new int[N];
            Console.WriteLine("\nArray 2:");
            Random ran = new Random();
            for (int i = 0; i < N; i++)
            {
                B[i] = ran.Next(0, 50);
                Console.Write(B[i] + " ");
            }

            Console.WriteLine("\n\nArray 3:"); 
            int[] C = A.Intersect(B).ToArray();
            if (C.Length == 0)
            {
                Console.WriteLine("Not element!");
            }
            else
            {
                for (int i = 0; i < C.Length; i++)
                { 
                    Console.WriteLine(C[i] + " "); 
                }
            }
        }
    }
}
