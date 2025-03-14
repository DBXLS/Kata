using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class LDD
    {
        private Double Rate;
        private Double Amount;

        public LDD(Double amount)
        {
            this.Amount = amount;
        }

        public Double GetAmount()
        {
            return Amount;
        }

        public Double GetRate()
        {
            return Rate;
        }

        public Decimal GetMonthlyValue()
        {
            throw new NotImplementedException();
        }
    }
}