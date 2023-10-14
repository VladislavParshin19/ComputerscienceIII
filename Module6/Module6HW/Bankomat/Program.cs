using System;
using BankLibrary;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "Vladislav",
                LastName = "Parshin",
                Age = 21,
                Address = "ул. Болашак, 45"
            };
            
            string personInfo = PersonInfo.GetPersonInfo(person);
            Console.WriteLine(personInfo);


            // Ожидание пользовательского ввода
            Console.ReadLine();

            Bank bank = new Bank();
            Account account1 = new Account("1", 1000.0);
            Account account2 = new Account("2", 500.0);
            Client client1 = new Client("1111-2222-3333-4444", "1234", account1);
            Client client2 = new Client("2222-3333-4444-1111", "2341", account2);
            bank.AddClient(client1);
            bank.AddClient(client2);

            int attempts = 3;
            Client authenticatedClient = null;

            while (attempts > 0)
            {
                Console.Write("Введите номер кредитной карты: ");
                string cardNumber = Console.ReadLine();
                Console.Write("Введите PIN-код: ");
                string pin = Console.ReadLine();
                authenticatedClient = bank.Authenticate(cardNumber, pin);

                if (authenticatedClient != null)
                {
                    break;
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Неверный номер карты или PIN. Осталось попыток: {attempts}");
                }
            }

            if (authenticatedClient != null)
            {
                Console.WriteLine("Вход выполнен успешно.");

                while (true)
                {
                    Console.WriteLine("Меню:");
                    Console.WriteLine("1. Вывести баланс");
                    Console.WriteLine("2. Пополнить счет");
                    Console.WriteLine("3. Снять деньги");
                    Console.WriteLine("4. Выход");
                    Console.Write("Выберите действие: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine($"Баланс на счете {authenticatedClient.Account.AccountNumber}: {authenticatedClient.Account.Balance}");
                            break;
                        case "2":
                            Console.Write("Введите сумму для пополнения: ");
                            double depositAmount = double.Parse(Console.ReadLine());
                            authenticatedClient.Account.Popolnenie(depositAmount);
                            break;
                        case "3":
                            Console.Write("Введите сумму для снятия: ");
                            double withdrawAmount = double.Parse(Console.ReadLine());
                            authenticatedClient.Account.Spisanie(withdrawAmount);
                            break;
                        case "4":
                            Console.WriteLine("Выход из программы.");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Превышено количество попыток ввода PIN. Программа завершена.");
            }
        }
    }
}
