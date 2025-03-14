using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;

namespace Bank
{
    public interface IClient
    {
        public String GetEmail();

        public IEnumerable<Object> GetProductList();

        public Decimal GetMonthlyBalance();

        public void AddProduct(String productType, Double amount);
    }
}