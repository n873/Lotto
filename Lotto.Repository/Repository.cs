using Lotto.Domain.Model;
using System;

namespace Lotto.Repository
{
    public interface IDrawRepository
    {
        Draw Get(DateTime drawSchedule);
    }
}
