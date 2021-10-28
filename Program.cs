using System;

namespace work2
{
    class Program
    {
        static void Mass(int[,] mt, int n, int m)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mt[i, j] = rnd.Next(0, 10);
                }
            }
        }
        static void Output(int[,] mt, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mt[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Mult(int[,] mt, int[,] nt, int[,] kt, int n1, int m2)
        {
            if (n1 != m2)
            {
                Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            }
            else
            {
                for (var i = 0; i < n1; i++)
                {
                    for (var j = 0; j < m2; j++)
                    {
                        kt[i, j] = 0;

                        for (var k = 0; k < n1; k++)
                        {
                            kt[i, j] += mt[i, k] * nt[k, j];
                        }
                        Console.Write(kt[i, j] + " ");
                    }
                    Console.WriteLine();
                }

            }
        }
        static void Main(string[] args)
        {
            int[,] A;
            int n1, m1, n2, m2;
            n1 = Convert.ToInt32(Console.ReadLine());
            m1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            A = new int[n1, m1];
            int[,] B = new int[n2, m2];
            int[,] С = new int[n1, m2];
            Mass(A, n1, m1);
            Mass(B, n2, m2);
            Console.WriteLine("Матрица A: ");
            Output(A, n1, m1);
            Console.WriteLine("Матрица B: ");
            Output(B, n2, m2);
            Console.WriteLine("Произведение матриц: ");
            Mult(A, B, С, n1, m2);
        }
    }
}
