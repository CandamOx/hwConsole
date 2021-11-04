using System;
using System.IO;

namespace hwConsole
{
    class Task521
    {
		public class Student
		{
			string group, name;
			int age, sex, physics, math, inf, grant;

			public void Input()
			{
				Console.WriteLine("Введите код группы: ");
				group = Console.ReadLine();
				Console.WriteLine("Введите ФИО: ");
				name = Console.ReadLine();
				Console.WriteLine("Введите год рождения: ");
				age = Console.Read();
				Console.WriteLine("Выберите пол (подсказка: 1 - Мужской \t 2 - Женский): ");
				sex = Console.Read();
				Console.WriteLine("Оценка по физике: ");
				physics = Console.Read();
				Console.WriteLine("Оценка по математике: ");
				math = Console.Read();
				Console.WriteLine("Оценка по информатике: ");
				inf = Console.Read();
				Console.WriteLine("Введите наличие стипендии (подсказка: 0 - нет стипендии \t 1 - есть стипендия): ");
				grant = Console.Read();
			}

			public void Output()
			{
				Console.WriteLine("ФИО:", name);
			}

			public bool Check()
			{
				if (grant == 0 && physics >= 3 && math >= 3 && inf >= 3) return true;
				else return false;
			}
		};

		public static int Task()
		{
			try
			{
				const int kolichestvo_student = 5;
				Student[] Info = new Student[5];

				for (int i = 0; i < kolichestvo_student; i++)
				{
					Info[i].Input();
				}

				for (int i = 0; i < kolichestvo_student; i++)
					if (Info[i].Check())
						Info[i].Output();

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
