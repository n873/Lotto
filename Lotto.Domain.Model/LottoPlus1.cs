using Lotto.Domain.Contant;
using System;

namespace Lotto.Domain.Model
{
    public class LottoPlus1 : LottoGame
    {
        public LottoPlus1(string drawDate) : base(GameType.SALottoPlus1, drawDate)
        {
        }
    }
}
