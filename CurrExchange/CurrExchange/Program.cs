using CurrExchange;
using System;

namespace CurrencyExchanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Exchange ex = new Exchange();

            Console.WriteLine($"404 HUF = {ex.HUFtoEUR(404)} EUR");
            Console.WriteLine($"10 EUR = {ex.EURtoHUF(10)} HUF");
            Console.WriteLine($"710 HUF = {ex.HUFtoUSD(710)} USD");
            Console.WriteLine($"300 USD = {ex.USDtoHUF(300)} HUF");
        }
    }
}