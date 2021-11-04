using System;
using System.Collections.Generic;
using System.Text;

namespace hwConsole
{
    class Task252
    {
		const int n = 3;

		private static int Xj(double a1, double a2, double a3)
		{
			int x;
			if (a1 < (a2 + a3) / 2.0)
			{
				x = 1;
			}
			else
			{
				x = 0;
			}
			return x;
		}

		public static int Task()
		{
			try
			{
				double[,] A = new double[n, n];
				int i, j;
				int[] X = new int[n];

				Console.WriteLine("\n Vvedite elementi matrici: \n");
				for (i = 0; i < n; i++)
				{
					for (j = 0; j < n; j++)
						A[i, j] = Console.Read();
				}

				Console.WriteLine("\n Poluchena matrica: \n");
				for (i = 0; i < n; i++)
				{
					for (j = 0; j < n; j++)
						Console.Write(" ", A[i, j]);
					Console.WriteLine();
				}

				Console.WriteLine("\n Itogovii rezultat: \n");
				for (j = 0; j < n; j++)
				{
					for (i = 1; i < n - 1; i++)
						X[j] = Xj(A[i, j], A[i - 1, j], A[i + 1, j]);
					Console.WriteLine(" ", X[j]);
				}

				return 0;
			}
			catch (System.IO.IOException e)
			{
				Console.WriteLine("\n Введены неверные параметры, операция прервана");
				if (e.Source != null)
					Console.WriteLine("IOException source: {0}", e.Source);
				throw;
			}
		}
	}
}
