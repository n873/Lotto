using Lotto.Domain.Contant;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lotto.Domain.Model
{
    public class LottoPlus1 : LottoGame
    {
        public override string GetDivision(params int[] draw)
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
                    switch (matches.Count)
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
