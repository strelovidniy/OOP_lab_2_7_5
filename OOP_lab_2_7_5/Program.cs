using System;

namespace OOP_lab_2_7_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            var rnd = new Random();

            int[,] a = new int[n, n];
            int[,] b = new int[n, n];

            for (int i = 0; i < n; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    a[i, j] = rnd.Next(0,100);
                }
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    b[i, j] = rnd.Next(0,100);
                }
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("{0} ", b[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i < n; i += 2)
            {
                for (int j = 0; j < n; ++j)
                {
                    a[i, j] = b[j, i - 1];
                }
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
