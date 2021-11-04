using System;
using System.Collections.Generic;
using System.Text;

namespace hwConsole
{
    class Task251
    {
		const int n = 6;
		const int m = 3;

		private static int t_count(int t, double a)
		{
			if (a == 0) t++;
			return t;
		}

		public static int Task()
		{
			try
			{
				double[,] A = new double[n, m];
				int i, j, k = 0, t;
				Console.WriteLine("Vvedite elementi matrici A: \n");
				for (i = 0; i < n; i++)
				{
					for (j = 0; j < m; j++)
					{
						A[i, j] = Console.Read();
					}
				}

				Console.WriteLine("\n Matrica: \n");
				for (i = 0; i < n; i++)
					for (j = 0; j < m; j++)
						Console.WriteLine(" ", A[i, j]);

				Console.WriteLine("\n Nomera strok, imeushih ne menee 2 nulevih elementov: \n");
				for (i = 0; i < n; i++)
				{
					t = 0;
					for (j = 0; j < m; j++)
					{
						t = t_count(t, A[i, j]);
					}
					if (t >= 2)
					{
						Console.WriteLine(" ", i + 1);
						k++;
					}
				}

				if (k == 0) Console.WriteLine("\n Podhodyashih strok net \n");
				else Console.WriteLine("\n Kolichestvo podhodyashih strok: ", k);


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
