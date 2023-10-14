using System;

namespace Bankomat
{
    // Класс "Account" представляет счет клиента
    public class Account
    {
        public string AccountNumber { get; }
        public double Balance { get; set; }

        public Account(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;

        }

        public void Popolnenie(double amount)
        {
            Balance += amount;
            Console.WriteLine($"На счет {AccountNumber}: {amount} успешно зачислено. Новый баланс: {Balance}");
        }

        public bool Spisanie(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Со счета {AccountNumber} снято {amount}. Новый баланс: {Balance}");
                return true;
            }

            else
            {
                Console.WriteLine("Недостаточно средств для списания");
                return false;
            }
        }
    }
}
