using System;

//Реализовать несколько методов или классов с методами и вызвать один метод из другого. В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Запрашиваем делимое и делитель у пользователя
                Console.Write("Введите делимое: ");
                int dividend = int.Parse(Console.ReadLine());

                Console.Write("Введите делитель: ");
                int divisor = int.Parse(Console.ReadLine());

                // Выполняем деление и обрабатываем исключения
                PerformDivision(dividend, divisor);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Поймано исключение: " + ex.Message);
            }

            Console.ReadLine();
        }

        static void PerformDivision(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                // Генерируем исключение, если делитель равен нулю
                throw new DivideByZeroException("Деление на ноль недопустимо");
            }
            // Выполняем деление и выводим результат
            int result = dividend / divisor;
            Console.WriteLine("Результат деления: " + result);
        }
    }
}