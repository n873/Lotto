using Lotto.Domain.Contant;
using Lotto.Domain.Model;
using Xunit;

namespace Lotto.Test
{
    public class DivisionTest
    {
        private readonly ILotto lottoInstance;

        public DivisionTest()
        {
            lottoInstance = Lottery.Domain.Factory.GameFactory.Get(GameType.SALotto, "2018-06-06");
            lottoInstance.CaptureDraw(29, 15, 22, 41, 19, 4, 17);
        }

        [Fact]
        public void NotWinnerTest()
        {
            var result = lottoInstance.GetDivision(1, 3, 20, 21, 30, 31);
            Assert.Equal(DivisionResult.NoDivision, result);
        }

        [Fact]
        public void WinnerDivison3Test() {
            var result = lottoInstance.GetDivision(3, 15, 19, 22, 29, 41);
            Assert.Equal(DivisionResult.Division3, result);
        }
    }
}
