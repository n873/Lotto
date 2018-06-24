using System;
using System.Linq;

namespace Lotto.Utility
{
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
