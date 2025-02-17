using System;

namespace MyApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите кол-во итераций: ");
            double n = Convert.ToSingle(Console.ReadLine());
            double k = 0;

            double a = 5;
            double b = 8.5;
            Random rnd = new Random();

            for (int i = 1; i < n; i++)
            {
                double x = rnd.NextDouble() * 8.5;
                double y = rnd.NextDouble() * 5;
                if ((x / 3 < y) && (y < x * (10 - x) / 5))
                {
                    k = k + 1;
                }
            }
            double s = (a * b * k) / n;
            Console.WriteLine("Пример из лекции: ");
            Console.WriteLine($"Площадь - {s}");

            a = 1;
            b = 15;
            k = 0;

            for (int i = 1; i < n; i++)
            {
                double x = rnd.NextDouble() * 15;
                double y = rnd.NextDouble() * 1;
                if ((Math.Sin(x) > y) && (y > 0))
                {
                    k = k + 1;
                }
            }
            s = (a * b * k) / n;
            Console.WriteLine("Первый пример: ");
            Console.WriteLine($"Площадь - {s}");

            a = 10;
            b = 8;
            k = 0;

            for (int i = 1; i < n; i++)
            {
                double x = rnd.NextDouble() * 10;
                double y = rnd.NextDouble() * 8;
                if (((x * (8 - x)) / 2 > y) && (y > x / 2))
                {
                    k = k + 1;
                }
            }
            s = (a * b * k) / n;
            Console.WriteLine("Второй пример: ");
            Console.WriteLine($"Площадь - {s}");

            a = 6;
            b = 12;
            k = 0;

            for (int i = 1; i < n; i++)
            {
                double x = rnd.NextDouble() * 12;
                double y = rnd.NextDouble() * 6;
                if ((Math.Pow((x - 6), 2) / 6 < y) && (y < 6))
                {
                    k = k + 1;
                }
            }
            s = (a * b * k) / n;
            Console.WriteLine("Третий пример: ");
            Console.WriteLine($"Площадь - {s}");

            a = 4;
            b = 12;
            k = 0;

            for (int i = 1; i < n; i++)
            {
                double x = rnd.NextDouble() * 10;
                double y = rnd.NextDouble() * 2;
                if (((x * (12 - x) / 9) > y) && (y > x / 5))
                {
                    k = k + 1;
                }
            }
            s = (a * b * k) / n;
            Console.WriteLine("Четвёртый пример: ");
            Console.WriteLine($"Площадь - {s}");

            a = 4.4;
            b = 10;
            k = 0;

            for (int i = 1; i < n; i++)
            {
                double x = rnd.NextDouble() * 4.4;
                double y = rnd.NextDouble() * 8;
                if (((x * (8 - x) / 4) > y) && (y > ((8 - x) / 8)))
                {
                    k = k + 1;
                }
            }
            s = (a * b * k) / n;
            Console.WriteLine("Пятый пример: ");
            Console.WriteLine($"Площадь - {s}");

            a = 2;
            b = 3;
            k = 0;

            for (int i = 1; i < n; i++)
            {
                double x = rnd.NextDouble() * (3 - 1) + 1;
                double y = rnd.NextDouble() * 2;
                if ((Math.Sin(x) > y) && (y > (Math.Pow((x - 2), 2) / 2)))
                {
                    k = k + 1;
                }
            }
            s = (a * b * k) / n;
            Console.WriteLine("Шестой пример: ");
            Console.WriteLine($"Площадь - {s}");
        }
    }

}