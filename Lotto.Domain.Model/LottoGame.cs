using System;
using System.Linq;

namespace Lotto.Domain.Model
{
    public abstract class LottoGame : ILotto
    {
        protected int[] _Draw;

        public void CaptureDraw(params int[] draw)
        {
            try
            {
                if (draw != null && draw.Length > 0)
                    _Draw = draw;
                else
                    throw new Exception("Cant capture an empty draw.");
            }
            catch (Exception) { throw; }
        }

        public abstract string GetDivision(params int[] draw);
    }

    public static class LotteryUtility
    {
        public static int[] GenerateNumbers()
        {
            var random = new Random();
            var lottoNumbers = Enumerable
                .Range(1, 52)
                .OrderBy(x => random.Next())
                .Take(7)
                .ToArray();
            return lottoNumbers;
        }
    }
}
