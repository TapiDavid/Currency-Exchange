using CurrExchange;

namespace CurrExchangeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CurrExchange_HUFtoEUR_ValueOf404_ShouldReturn1()
        {
            Exchange ex = new Exchange();
            Assert.Equal(1, ex.HUFtoEUR(404));
        }

        [Fact]
        public void CurrExchange_EURtoHUF_ValueOf10_ShouldReturn4040()
        {
            Exchange ex = new Exchange();
            Assert.Equal(4040, ex.EURtoHUF(10));
        }

        [Fact]
        public void CurrExchange_HUFtoUSD_ValueOf710_ShouldReturn2()
        {
            Exchange ex = new Exchange();
            Assert.Equal(2, ex.HUFtoUSD(710));
        }

        [Fact]
        public void CurrExchange_USDtoHUF_ValueOf300_ShouldReturn106500()
        {
            Exchange ex = new Exchange();
            Assert.Equal(106500, ex.USDtoHUF(300));
        }

        [Theory]
        [InlineData (2, 808)]
        [InlineData (3, 1212)]
        public void CurrExchange_HUFtoEUR_ValueOf808_ShouldReturn2(int a, int b)
        {
            Exchange ex = new Exchange();
            Assert.Equal(a, ex.HUFtoEUR(b));
        }
    }
}
