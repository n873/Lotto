using Lotto.Domain.Contant;

namespace Lotto.Domain.Model
{
    /// <summary>
    /// The Lotto type implements LottoGame thus also implementing ILotto
    /// and allowing for interface segregration
    /// Or determining a concrete type via dependency Injection
    /// </summary>
    public class Lotto : LottoGame
    {
        public Lotto(string drawDate) : base(GameType.SALotto, drawDate)
        {
        }
    }
}
