using System;

namespace MyApp
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Введите кол-во итераций: ");
                double iterationsCount = Convert.ToSingle(Console.ReadLine());

                AreaCalculator areaCalculator = new AreaCalculator(iterationsCount);
                areaCalculator.CalculateArea1();
                areaCalculator.CalculateArea2();
                areaCalculator.CalculateArea3();
                areaCalculator.CalculateArea4();
                areaCalculator.CalculateArea5();
                areaCalculator.CalculateArea6();
            }
            catch
            {
                Console.WriteLine("Введите корректные данные");
            }
            
        }
    }

    internal class AreaCalculator
    {
        private double iterationsCount;
        private Random rnd;

        public AreaCalculator(double iterationsCount)
        {
            this.iterationsCount = iterationsCount;
            rnd = new Random();
        }

        public void CalculateArea1()
        {
            double AreaHeight = 5;
            double AreaWidth = 8.5;
            double successCount = 0;

            for (int i = 1; i < iterationsCount; i++)
            {
                double x = rnd.NextDouble() * AreaWidth;
                double y = rnd.NextDouble() * AreaHeight;
                if ((x / 3 < y) && (y < x * (10 - x) / 5))
                {
                    successCount++;
                }
            }
            double area = (AreaHeight * AreaWidth * successCount) / iterationsCount;
            Console.WriteLine("Пример из лекции: ");
            Console.WriteLine($"Площадь - {area}");
        }

        public void CalculateArea2()
        {
            double AreaHeight = 1;
            double AreaWidth = 15;
            double successCount = 0;

            for (int i = 1; i < iterationsCount; i++)
            {
                double x = rnd.NextDouble() * AreaWidth;
                double y = rnd.NextDouble() * AreaHeight;
                if ((Math.Sin(x) > y) && (y > 0))
                {
                    successCount++;
                }
            }
            double area = (AreaHeight * AreaWidth * successCount) / iterationsCount;
            Console.WriteLine("Первый пример: ");
            Console.WriteLine($"Площадь - {area}");
        }

        public void CalculateArea3()
        {
            double AreaHeight = 8;
            double AreaWidth = 10;
            double successCount = 0;

            for (int i = 1; i < iterationsCount; i++)
            {
                double x = rnd.NextDouble() * AreaWidth;
                double y = rnd.NextDouble() * AreaHeight;
                if (((x * (8 - x)) / 2 > y) && (y > x / 2))
                {
                    successCount++;
                }
            }
            double area = (AreaHeight * AreaWidth * successCount) / iterationsCount;
            Console.WriteLine("Второй пример: ");
            Console.WriteLine($"Площадь - {area}");
        }

        public void CalculateArea4()
        {
            double AreaHeight = 12;
            double AreaWidth = 6;
            double successCount = 0;

            for (int i = 1; i < iterationsCount; i++)
            {
                double x = rnd.NextDouble() * AreaWidth;
                double y = rnd.NextDouble() * AreaHeight;
                if ((Math.Pow((x - 6), 2) / 6 < y) && (y < 6))
                {
                    successCount++;
                }
            }
            double area = (AreaHeight * AreaWidth * successCount) / iterationsCount;
            Console.WriteLine("Третий пример: ");
            Console.WriteLine($"Площадь - {area}");
        }

        public void CalculateArea5()
        {
            double AreaHeight = 12;
            double AreaWidth = 4;
            double successCount = 0;

            for (int i = 1; i < iterationsCount; i++)
            {
                double x = rnd.NextDouble() * 10;
                double y = rnd.NextDouble() * 2;
                if (((x * (AreaWidth - x) / 9) > y) && (y > x / 5))
                {
                    successCount++;
                }
            }

            double area = (AreaHeight * AreaWidth * successCount) / iterationsCount;
            Console.WriteLine("Четвёртый пример: ");
            Console.WriteLine($"Площадь - {area}");
        }

        public void CalculateArea6()
        {
            double AreaHeight = 10;
            double AreaWidth = 4.4;
            double successCount = 0;

            for (int i = 1; i < iterationsCount; i++)
            {
                double x = rnd.NextDouble() * AreaWidth;
                double y = rnd.NextDouble() * 8;
                if (((x * (8 - x) / 4) > y) && (y > ((8 - x) / 8)))
                {
                    successCount++;
                }
            }
            double area = (AreaHeight * AreaWidth * successCount) / iterationsCount;
            Console.WriteLine("Пятый пример: ");
            Console.WriteLine($"Площадь - {area}");
        }

        public void CalculateArea7()
        {
            double AreaHeight = 3;
            double AreaWidth = 2;
            double successCount = 0;

            for (int i = 1; i < iterationsCount; i++)
            {
                double x = rnd.NextDouble() * (AreaWidth - 1) + 1;
                double y = rnd.NextDouble() * 2;
                if ((Math.Sin(x) > y) && (y > (Math.Pow((x - 2), 2) / 2)))
                {
                    successCount++;
                }
            }
            double area = (AreaHeight * AreaWidth * successCount) / iterationsCount;
            Console.WriteLine("Шестой пример: ");
            Console.WriteLine($"Площадь - {area}");
        }
    }
}