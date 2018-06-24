using System;
using System.Linq;

namespace Lotto.Utility
{
    /// <summary>
    /// LotteryUtility generates a random selection of Lottery draw numbers
    /// </summary>
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
