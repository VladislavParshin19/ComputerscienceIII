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
                CallMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }

            Console.ReadLine();
        }

        static void CallMethod()
        {
                // Генерация исключения в вызываемом методе
                throw new InvalidOperationException("Исключение в методе CallMethod.");
        }
    }
}