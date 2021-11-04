using System;
using System.IO;

namespace hwConsole
{
    class Task143 {
			private static double Minn(double ai, double ani) {
			double min = Math.Abs(ai) - Math.Abs(ani);
			return min;
		}

		public static int Task()
		{
			Console.WriteLine("\tЗадача 1.3.2");

			try
			{
				Console.WriteLine("Vvedite razmernost massiva A (chetnoe chislo): ");
				int n = Console.Read();

				if (n % 2 != 0 || n <= 0)
					Console.WriteLine("\n Nepravilnii razmer massiva");
				else
				{
					double[] A = new double[n];
					Console.WriteLine("\n Vvedite elementi massiva A: \n");
					for (int i = 0; i < n; i++)
					{
						A[i] = Console.Read();
					}

					double min = Math.Abs(A[0]) - Math.Abs(A[n - 1]);
					for (int i = 1; i <= n / 2; i++)
					{
						if (Math.Abs(A[i]) - Math.Abs(A[n - i]) < min)
							min = Minn(A[i], A[n - i]);
					}
					Console.WriteLine("\n Naimenshaya raznost: ", min);
				}

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
