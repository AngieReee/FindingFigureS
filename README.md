# Отчет о рефакторинге

## Введение

Данный документ содержит отчет о рефакторинге кода, который был выполнен с целью улучшения структуры, читаемости и удобства сопровождения проекта. Рефакторинг был направлен на выделение логически связанных блоков и улучшение наименования переменных.

## Что было изменено

1. Структура программы
   Создан новый класс AreaCalculator, который инкапсулирует функционал вычисления площадей. Это позволяет логически сгруппировать методы и упрощает их использование.

   Например:

    ```
     internal class AreaCalculator
    {
      private double iterationsCount;
      private Random rnd;

      public AreaCalculator(double iterationsCount)
      {
          this.iterationsCount = iterationsCount;
          rnd = new Random();
      }
    ```

3. Переименование переменных
   Все переменные были переименованы в соответствии со стилем CamelCase. Например:
     - n -> iterationsCount
     - k -> successCount
     - a -> AreaHeight
     - b -> AreaWidth

4. Методы вычисления площади
   - Вынесены отдельные методы для различных вычислений площадей (CalculateArea1, CalculateArea2 и т.д.), что делает код более изолированным и модульным.
   - Каждому методу добавлены локальные переменные для параметров, что позволяет избегать использования жестко закодированных значений и делает код более гибким.
  
     Например:

    ```
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
    ```
  
3. Добавление обработки исключений
   Добавлена конструкция try ... catch для ввода количества итераций и вычисления результатов.

   ```
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
   ```

## Преимущества

- Читаемость: Улучшенная структура и наименования делают код более понятным для новых разработчиков и облегчают сопровождение.
- Модульность: Логическое разделение на классы и методы позволяет легче тестировать и модифицировать код.
- Поддержка: Возможность добавления новых методов вычисления площади становится проще и интуитивно понятнее.

## Авторы
* *разработчик* - [Сухарева Анжелика](https://github.com/AngieReee) 
