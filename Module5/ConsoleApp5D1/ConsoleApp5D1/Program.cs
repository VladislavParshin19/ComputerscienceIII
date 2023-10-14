using System;

//Перехватить исключение запроса к несуществующему веб ресурсу и вывести сообщение о том, что произошла ошибка. Программа должна завершиться без ошибок.

namespace ConsoleApp5D1
{
    class Program
    {
        static void Main()
        {
            try
            {
                string url = "https://https://sigmamod.com";
                var request = System.Net.WebRequest.Create(url);
                var response = request.GetResponse();
                // Дополнительный код обработки успешного ответа, если необходимо
                response.Close();
            }
            catch (System.Net.WebException ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
