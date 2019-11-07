using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class ChangedMatrixx
    {

        public static void ChangedMatrix(int n, int[,] A)
        {

            Console.WriteLine("Changed matrix");

            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    A[i, j] = 0;
                }
                k++;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter square matrix size ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[,] A = new int[n, n];
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        A[i, j] = r.Next(1, 9);
                        Console.Write(A[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                ChangedMatrix(n, A);
            }
        }
    }
}

