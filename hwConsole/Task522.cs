/*using System;
using System.IO;

namespace hwConsole {
    class Task522 {
		public class Him {
			public Char[] nazv = new Char[50];
			public int ves;
			public Char[] prov = new Char[30];
			public float k;
			public bool Polu(int i) {
				if (string.Compare(Convert.ToString(prov[i]), "полупроводник") == 0)
					if (k > 5)
						return true;
				return false;
			}
		};

		class Table {
			public Him t;
			public int n;

			Table(byte[] name) {
				n = 0;
				char[] temp = new char[255];
				FileStream f, f2;
				f.Read(name);

				if (f) {
					while (!f.eof()) {
						f.getline(temp, 255);
						if (strcmp(temp, "") != 0)
							n++;
					}
					f.Close();
				}

				Him[] tbl = new Him[n];
				n = 0;

				f2.Read(name);
					while (!f2.eof()) {
						f2.Write(tbl[n].nazv);
						f2.Write(tbl[n].ves);
						f2.Write(tbl[n].prov);
						f2.Write(tbl[n].k);
						n++;
					}
					f2.Close();
			}

			void Print()
			{
				Console.WriteLine("Все данные из файла ");
				for (int i = 0; i < n; i++)
					Console.WriteLine(tbl[i].nazv, "\t  Уд. вес: ", tbl[i].ves, "\t", tbl[i].prov, "\t Кол-во: ", tbl[i].k);
			}

			void Find()
			{
				cout << "Полупроводники, которых более 5:" << endl;
				for (int i = 0; i < n; i++)
					if (t[i].polu())
						Console.WriteLine(tbl[i].nazv, "\t Уд. вес: ", tbl[i].ves);
			}

		};

		public int Task()
		{
			try
			{
				Table tab("input.txt");
				tab.print();
				tab.find();
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
}*/