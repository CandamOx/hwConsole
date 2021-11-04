using System;
using System.IO;

namespace hwConsole {
    class Task12 {
		private static double Ypoint(double x) {
			double y = Math.Abs(
				Math.Sign(
					Math.Sqrt(10.5 * x)))
				/ (Math.Pow(x, 2.0 / 3) - 0.143)
				+ 2 * x * 3.14;
			return y;
		}

		public static int Task() {
			Console.WriteLine("\tЗадача 1.2");
			try {
				Console.WriteLine("\nВвести точку начала отрезка");
				double A = Console.Read();
				Console.WriteLine("\nВвести точку конца отрезка");
				double B = Console.Read();

				if (A >= B)
					Console.WriteLine("\n Введённые числа не удовлетворяют условию. A <= B \n");
				else {
					Console.WriteLine("\n Введите количество вычислений N = ");
					int N = Console.Read();
					double h = (B - A) / (N - 1);
					double x = A;

					for (int i = 0; i < N; i++) {
						double y = Ypoint(x);
						Console.WriteLine("x = ", x, " \t y = ", y);
						x += h;
					}
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
