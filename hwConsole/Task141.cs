using System;
using System.IO;


namespace hwConsole
{
    class Task141 {
		private static double CompE(double E, double a) {
			return E * a;
		}

		public static double Task() {
			Console.WriteLine("\tЗадача 1.4.1");
			try {
				double E = 1.0;

				Console.WriteLine("Введите размер массива n: ");
				int n = Console.Read();
				double[] a = new double[n + 1];

				Console.WriteLine("\n Введите все элементы массива: ");
				for (int i = 1; i <= n; i++) {
					a[i] = Console.Read();
					E = (i == 1 || i % 3 == 0) ? CompE(E, a[i]) : E;

					Console.WriteLine("Произведение: ", E);
				}

				return 0;
			}
			catch (IOException e) {
				Console.WriteLine("\n Введены неверные параметры, операция прервана");
				if (e.Source != null)
					Console.WriteLine("IOException source: {0}", e.Source);
				throw;
			}
		}
	}
}
