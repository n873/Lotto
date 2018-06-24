using Lotto.Domain.Contant;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lotto.Domain.Model
{
    /// <summary>
    /// LottoGame is the base type of all Lotto game types
    /// LottoGame implements ILotto interface and its defined methods
    /// The LottoGame declares CaptureDraw and allows overriding of the GetDivision logic
    /// </summary>
    public abstract class LottoGame : ILotto
    {
        protected int[] _Draw;
        private readonly string _GameType;
        private readonly string _DrawDate;

        public LottoGame(string gameType, string drawDate)
        {
            _GameType = gameType;
            _DrawDate = drawDate;
        }

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

        public virtual string GetDivision(params int[] draw)
        {
            try
            {
                List<int> matches;
                if (draw != null && draw.Length > 0)
                    matches = _Draw.Where(_drawItem => draw.Any(drawItem => _drawItem == drawItem)).ToList();
                else
                    throw new Exception("Cant get division for an empty lotto game");

                if (matches != null && matches.Count > 0)
                {
                    var matchesCount = matches.Count;
                    if (_Draw.Length > 6)
                    {
                        var bonusMatch = matches.Any(number => number == _Draw[6]);

                        if (bonusMatch)
                            switch (matchesCount)
                            {
                                case 3:
                                    return DivisionResult.Division8;
                                case 4:
                                    return DivisionResult.Division6;
                                case 5:
                                    return DivisionResult.Division4;
                                case 6:
                                    return DivisionResult.Division2;
                                default:
                                    break;
                            }
                    }

                    switch (matchesCount)
                    {
                        case 3:
                            return DivisionResult.Division7;
                        case 4:
                            return DivisionResult.Division5;
                        case 5:
                            return DivisionResult.Division3;
                        case 6:
                            return DivisionResult.Division1;
                        default:
                            break;
                    }
                }
                return DivisionResult.NoDivision;
            }
            catch (Exception) { throw; }
        }
    }


}
