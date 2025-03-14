using System.Collections.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Bank
{
    public interface IBank
    {
        IList<IClient> GetClientList();

        void AddClient(IClient client);

        IClient SearchClient(String email);

        Decimal GetMonthlyPNL();
    }
}