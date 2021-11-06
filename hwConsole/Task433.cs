using System;
using System.IO;

namespace hwConsole
{
    class Task433
    {
        const int N = 9;
        const int M = 4;

        class Matrix
        {
            public int i, j, k, x, n, flag = 0;
            public int[,] a = new int[N, M];

            public void Input()
            {
                Console.WriteLine("Введите матрицу:");
                for (i = 0; i < N; i++)
                {
                    for (j = 0; j < M; j++)
                        a[i, j] = Console.Read();
                }
            }

            public void Output_source()
            {
                Console.WriteLine("\nИсходная матрица:\n");
                for (i = 0; i < N; i++)
                {
                    for (j = 0; j < M; j++)
                        Console.Write("\t", a[i, j]);
                    Console.WriteLine();
                }
            }

            public void Sort()
            {
                for (j = 0; j < M; j++)
                    for (i = 0; i < N; i++)
                        if (a[i, j] < 0)
                            for (k = N - 1; k > i; k--)
                                if (a[k, j] >= 0)
                                {
                                    x = a[i, j];
                                    a[i, j] = a[k, j];
                                    a[k, j] = x;
                                }
            }

            public void Output_sort()
            {
                Console.WriteLine("\nОтсортированная матрица:\n");
                for (i = 0; i < N; i++)
                {
                    for (j = 0; j < M; j++)
                        Console.Write("\t", a[i, j]);
                    Console.WriteLine();
                }
            }

            public void Output_final()
            {
                for (i = 0; i < N; i++)
                {
                    for (j = 0; j < M; j++)
                        if (a[i, j] < 0) flag = 1;
                    if (flag == 1) break;
                }

                n = i;
                Console.WriteLine("\nМатрица без строк с отрицательными элементами:\n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < M; j++)
                        Console.Write("\t", a[i, j]);
                    Console.WriteLine();
                }
            }
        };

        public static int Task()
        {
            Console.WriteLine("\tЗадача 4.3.3");
            try
            {
                Matrix test = new Matrix();

                test.Input();
                test.Output_source();
                test.Sort();
                test.Output_sort();
                test.Output_final();
                return 0;
            }
            catch (IOException e)
            {
                Console.WriteLine("\n Введены неверные параметры, операция прервана");
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }

        }

    }
}
