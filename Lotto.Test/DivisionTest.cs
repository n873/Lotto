using Lotto.Domain.Contant;
using Lotto.Domain.Model;
using Lotto.Utility;
using Xunit;

namespace Lotto.Test
{
    public class DivisionTest
    {
        private readonly ILotto lottoInstance;
        private readonly int[] randomSelection;

        public DivisionTest()
        {
            lottoInstance = Lottery.Domain.Factory.GameFactory.Get(GameType.SALotto, "2018-06-06");
            var randomDraw = LottoUtility.GenerateNumbers();
            lottoInstance.CaptureDraw(randomDraw);
            randomSelection = new int[7];
            randomDraw.CopyTo(randomSelection, 0);
        }

        [Fact]
        public void NotWinnerTest()
        {
            lottoInstance.CaptureDraw(29, 15, 22, 41, 19, 4, 17);

            var result = lottoInstance.GetDivision(1, 3, 20, 21, 30, 31);
            Assert.Equal(DivisionResult.NoDivision, result);
        }

        [Fact]
        public void WinnerDivison3Test() {
            lottoInstance.CaptureDraw(29, 15, 22, 41, 19, 4, 17);

            var result = lottoInstance.GetDivision(3, 15, 19, 22, 29, 41);
            Assert.Equal(DivisionResult.Division3, result);
        }

        [Fact]
        public void WinnerDivison1Test()
        {
            randomSelection[6] = 0;

            var result = lottoInstance.GetDivision(randomSelection);
            Assert.Equal(DivisionResult.Division1, result);
        }

        [Fact]
        public void WinnerDivison2Test()
        {
            randomSelection[0] = 0;

            var result = lottoInstance.GetDivision(randomSelection);
            Assert.Equal(DivisionResult.Division2, result);
        }

        [Fact]
        public void WinnerDivison3Test_2()
        {
            randomSelection[6] = 0;

            randomSelection[0] = 0;

            var result = lottoInstance.GetDivision(randomSelection);
            Assert.Equal(DivisionResult.Division3, result);
        }

        [Fact]
        public void WinnerDivison4Test()
        {
            randomSelection[0] = 0;
            randomSelection[1] = 0;

            var result = lottoInstance.GetDivision(randomSelection);
            Assert.Equal(DivisionResult.Division4, result);
        }

        [Fact]
        public void WinnerDivison5Test()
        {
            randomSelection[6] = 0;

            randomSelection[0] = 0;
            randomSelection[1] = 0;

            var result = lottoInstance.GetDivision(randomSelection);
            Assert.Equal(DivisionResult.Division5, result);
        }

        [Fact]
        public void WinnerDivison6Test()
        {
            randomSelection[0] = 0;
            randomSelection[1] = 0;
            randomSelection[2] = 0;

            var result = lottoInstance.GetDivision(randomSelection);
            Assert.Equal(DivisionResult.Division6, result);
        }

        [Fact]
        public void WinnerDivison7Test()
        {
            randomSelection[6] = 0;

            randomSelection[0] = 0;
            randomSelection[1] = 0;
            randomSelection[2] = 0;

            var result = lottoInstance.GetDivision(randomSelection);
            Assert.Equal(DivisionResult.Division7, result);
        }
    }
}
