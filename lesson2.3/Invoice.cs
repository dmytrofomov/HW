using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson2._3
{
    class Invoice
    {
        private Account CurrentAccount { get; set; }

        public Invoice(int accountId)
        {
            CurrentAccount = GetAccountById(accountId);
        }

        public double? GetPriseWithNds(int article, int quantity)
        {
            int? price = GetPriceByArticle(article);
            if (price == null)
                throw new Exception("No such article");
            else return (double) quantity * price;
        }

        public double? GetPriseWithoutNds(int article, int quantity)
        {
            return GetPriseWithNds(article, quantity) * 0.8;
        }

        private int? GetPriceByArticle(int article)
        {
            if (DB.Articles.ContainsKey(article))
                return DB.Articles[article];
            else return null;
        }

        public Account GetAccountById(int id)
        {
            return DB.Accounts.FirstOrDefault(a => a.account == id);
        }
    }


    public class Account
    {
        public Account(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;

        }

        public readonly int account;
        public readonly string customer;
        public readonly string provider;
    }
}
