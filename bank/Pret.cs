using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Pret
    {
        private Double rate;
        private Double amount;

        public Pret(Double amount)
        {
            this.amount = amount;
        }

        public Double getAmount()
        {
            return amount;
        }

        public Double getRate()
        {
            return rate;
        }

        public Decimal getMonthlyValue()
        {
            throw new NotImplementedException();
        }
    }
}