using System;
using System.IO;

namespace hwConsole
{
    class Task253
    {
		static float[,] vvod(int n)
		{
			int i, j;
			float[,] a = new float[n, n];
			Console.WriteLine("Введите матрицу ", n, "x", n, ":\n");
			for (i = 0; i < n; i++)
				for (j = 0; j < n; j++)
					a[i, j] = Console.Read();
			return a;
		}

		static void vivod(float[,] a, int n, string s)
		{
			int i, j;
			Console.Write(s);
			for (i = 0; i < n; i++)
			{
				for (j = 0; j < n; j++)
					Console.Write("\t", a[i, j]);
				Console.WriteLine();
			}
		}

		static bool оtr(float[,] a, int n)
		{
			for (int i = 0; i < n; i++)
				if (a[i, i] > 0)
					return false;
			return true;
		}

		static float max(float[,] a, int n)
		{
			float mx = a[0, 0];
			for (int i = 0; i < n; i++)
				if (Math.Abs(mx) < Math.Abs(a[i, i]))
					mx = a[i, i];
			return mx;
		}

		static void del(float[,] a, int n)
		{
			float mx = max(a, n);
			for (int i = 0; i < n; i++)
				for (int j = 0; j < n; j++)
					a[i, j] = a[i, j] / mx; ;
		}

		public static int Task()
		{
			try
			{
				const int n = 5;
				float[,] a;

				a = vvod(n);
				vivod(a, n, "Исходная матрица:");
				if (оtr(a, n))
				{
					del(a, n);
					Console.WriteLine(" Максимальное по модулю = ", max(a, n));
					vivod(a, n, "Матрица после деления на максимальное значение по модулю:");
				}
				else
					Console.WriteLine("Не все значения главной диагонали отрицательны \n");

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
