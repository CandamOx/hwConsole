using System;
using System.Collections.Generic;
using System.Text;

namespace hwConsole
{
    class Task132
    {
        private static double Yfunc(double x, int k, double e)
        {
            return
                (Math.Pow
                (Math.Abs(x - k), 2)
                * Math.Sqrt
                (Math.Pow(e, k - 1)))
                / Math.Log(2
                + Math.Pow(x, k)
                + Math.Pow(x, 2 * k + 1));
        }

        public static int Task()
        {
            try
            {
                Console.WriteLine("\n Введите x: ");
                double x = Console.Read();
                Console.WriteLine("\n Введите n: ");
                int n = Console.Read();

                double e = Math.Exp(1.0);
                double s = 0;
                double a = Math.Pow(e, Math.Sqrt(x / n));

                for (int k = 1; k <= n; k++)
                {
                    double y = Yfunc(x, k, e);
                    s += y;
                    Console.WriteLine("\n", y, " \t", s);
                }

                Console.WriteLine("\n", s, " * ", a, " = ", s * a);

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
