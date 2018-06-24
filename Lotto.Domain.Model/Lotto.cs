using Lotto.Domain.Contant;

namespace Lotto.Domain.Model
{
    public class Lotto : LottoGame
    {
        public Lotto(string drawDate) : base(GameType.SALotto, drawDate)
        {
        }
    }
}
