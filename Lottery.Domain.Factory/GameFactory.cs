using Lotto.Domain.Contant;
using Lotto.Domain.Model;

namespace Lottery.Domain.Factory
{
    /// <summary>
    /// GameFactory produces a concrete implementation of a LottoGame
    /// Accepts a GameType and a draw date
    /// Uses GameType to determine which implementation of LottoGame to instantiate
    /// </summary>
    public static class GameFactory
    {
        public static ILotto Get(string lottoGame, string drawDate)
        {
            switch (lottoGame) {
                case (GameType.SALottoPlus1):
                    return new LottoPlus1(drawDate);
                case (GameType.SALottoPlus2):
                    return new LottoPlus2(drawDate);
                default:
                    return new Lotto.Domain.Model.Lotto(drawDate);
            }
        }
    }
}
