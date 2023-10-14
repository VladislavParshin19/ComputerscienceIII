namespace Bankomat
{
    // Класс "Client" представляет клиента банка
    class Client
    {
        public string CardNumber { get; }
        public string Pin { get; }
        public Account Account { get; }

        public Client(string cardNumber, string pin, Account account)
        {
            CardNumber = cardNumber;
            Pin = pin;
            Account = account;
        }
    }
}
