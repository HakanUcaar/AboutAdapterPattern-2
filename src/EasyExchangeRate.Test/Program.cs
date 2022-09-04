
using EasyExchangeRate.Adapter;
using EasyExchangeRate.Core;
using System;

namespace EasyExchangeRate.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //GetCurrencies();
            GetRates();

            Console.ReadLine();
        }

        static void GetCurrencies()
        {
            ExchangeRate.TurkeyAdapter.Currencies.ForEach(c =>
            {
                Console.WriteLine(c.ToString());
            });
        }

        static void GetRates()
        {
            var adapter = ExchangeRate.TurkeyAdapter;

            Console.WriteLine($"Base Currency : {ExchangeRate.TurkeyAdapter.BaseCurrency.Value.Name}");
            Console.WriteLine("Rates :");
            ExchangeRate.TurkeyAdapter.Rates.ForEach(c =>
            {
                Console.WriteLine($"{c.Value.Currency.Value.Name} = " + c.Value.Amount);
            });
        }

        
    }
}
