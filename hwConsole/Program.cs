﻿using System;
using System.Threading;

namespace hwConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Вино - 1, Коньяк - 2: ");
            Console.WriteLine(rnd.Next(1, 3));
            Console.WriteLine(rnd.Next(1, 3));
            Console.WriteLine(rnd.Next(1, 3));
            Console.WriteLine(rnd.Next(1, 3));
            Console.WriteLine(rnd.Next(1, 3));
            Console.WriteLine(rnd.Next(1, 3));
            Console.WriteLine(rnd.Next(1, 3));
            Console.WriteLine(rnd.Next(1, 3));
            Console.WriteLine(rnd.Next(1, 3));
            Thread.Sleep(1000000);

            Console.WriteLine("Копать Ксения \t ИЭозс-41-19 \t 9 вариант");
            Task12.Task();
            Task132.Task();
            Task141.Task();
            Task142.Task();
            Task143.Task();
            Task251.Task();
            Task252.Task();
            Task253.Task();
            Task433.Task();
            Task521.Task();
            //Task522.Task();

        }
    }
}
