using System;

//Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы. После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.

namespace ConsoleApp5D2
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            
            try
            {
                //Oбращения к элементам массива за его пределами
                for (int i = 0; i <= array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch (Exception ex)
            {
                //Вывод ошибки
                Console.WriteLine("Oшибка: " + ex.Message);
            }
            finally
            {
                //Вывод о завершении
                Console.WriteLine("Завершение обработки.");
            }

            Console.ReadLine();
        }
    }
}
