using System;

namespace lesson2._3
{
    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;

        public Invoice(string name)
        {
            account = 54;
            customer = name;
            provider = "Provider";
        }

        public int GetPriseWithNds(string article, int quantity)
        {
            int price = 0;
            if (article == "1")
            {
                price = 100;
            }
            if (article == "2")
            {
                price = 200;
            }
            else
            {
                Console.WriteLine("Wrong article");
            }
            return quantity * price;
        }

        public int GetPriseWithoutNds(string article, int quantity)
        {
            double v = GetPriseWithNds(article, quantity) * 0.8;
            return (int)v;
        }
    }
}
