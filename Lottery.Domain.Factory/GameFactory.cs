using Lotto.Domain.Contant;
using Lotto.Domain.Model;

namespace Lottery.Domain.Factory
{
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
