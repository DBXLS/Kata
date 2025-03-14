using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Client : IClient
    {
        private string Email;
        private List<object> Products = new List<object>();

        public Client(string email)
        {
            if(!email.Contains("@"))
                throw new ArgumentException($"{email} is not valid email");

                this.Email = email;
        }

        public string GetEmail()
        {
            return Email;
        }

        public IEnumerable<object> GetProductList()
        {
            return Products;

        }

        public decimal GetMonthlyBalance()
        {
            Decimale balance = 0;
            foreach(var product in Products)
            {
                if(product is LivretA la) balance -= la.GetMonthlyValue();
                if(product is LDD ldd) balance -= ldd.GetMonthlyValue();
                if(product is CompteAVue cav) balance -= cav.GetMonthlyValue();
                if(product is Pret pret) balance += pret.GetMonthlyValue();
            }
        }

        public void AddProduct(string productType, double amount)
        {
            //Il faut faire des condition pour ne pas ajoutet le même type de produit 2 fois
            if(productType == "LivretA" && Products.Exists(p => p is LivretA))
                    throw new ArgumentExecption($"{email} cannot have two LivretA")
             if(productType == "LDD" && Products.Exists(p => p is LDD))
                    throw new ArgumentExecption($"{email} cannot have two LDD")
             if(productType == "CompteAvue" && Products.Exists(p => p is CompteAvue))
                    throw new ArgumentExecption($"{email} cannot have two CompteAvue")
            
            switch(productType)
            {
                case "LivretA":
                    Products.Add(new LivretA(amount));
                    break;
                case "LDD":
                    Products.Add(new LivretA(amount));
                    break;
                case "CompteAvue":
                    Products.ADD(new CompteAvue(amount));
                    break;
                case "Pret":
                    Products.ADD(new Pret(amount));
                    break;
                default:
                    throw new ArgumentExecption($"Unknow product type")
                
            }
        }

    }
}