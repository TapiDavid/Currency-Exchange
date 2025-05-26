namespace CurrExchange
{
    public class Exchange
    {
        //1€ = 404Ft
        //1$ = 355Ft
        public double EURtoHUF(double e) { return e * 404; }
        public double HUFtoEUR(double ft) { return ft / 404; }
        public double USDtoHUF(double usd) { return usd * 355; }
        public double HUFtoUSD(double ft) { return ft / 355; }
    }
}