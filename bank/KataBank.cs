using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank
{
    public class KataBank : IBank
    {
        private List<IClient> Clients = new List<IClient>();

        public IList<IClient> GetClientList()
        {
            return Clients;
        }

        public void AddClient(IClient client)
        {
            if (Clients.Exists(c => c.GetEmail() == client.GetEmail()))
                throw new ArgumentException($"Client {client.GetEmail()} already exist");

            Clients.Add(client);
        }

        public IClient SearchClient(string email)
        {
            return Clients.FirstOrDefault(c => c.GetEmail() == email);
        }

        public Decimal GetMonthlyPNL()
        {
            return Clients.Sum(client => client.GetMonthlyBalance());
        }
    }
}
