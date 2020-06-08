using System;

namespace Laba2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[,] myArr = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[" + i + "," + j + "]=");
                    myArr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(myArr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write(myArr[i, i] + " ");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1)
                        Console.Write(myArr[i, j] + " ");
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j)
                        myArr[i, j] *= 2;
                    Console.Write(myArr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
