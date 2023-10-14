using System.Collections.Generic;

namespace Bankomat
{
    // Класс "Bank" представляет банк и управляет клиентами
    class Bank
    {
        private List<Client> clients = new List<Client>();
        public void AddClient(Client client)
        {
            clients.Add(client);
        }
         public Client Authenticate(string cardnumber, string pin)
        {
            foreach (Client client in clients)
            {
                if (client.CardNumber == cardnumber && client.Pin == pin)
                {
                    return client;
                }
            }
            return null;
        }
    }
}
