using System;
using System.Collections.Generic;

namespace BerlinClock
{
    public interface IBerlinClockRules
    {
        IEnumerable<LampPower> GetSingleMinutes(DateTime date);
        IEnumerable<LampPower> GetFiveMinutes(DateTime date);
        IEnumerable<LampPower> GetSingleHours(DateTime date);
        IEnumerable<LampPower> GetFiveHourBlocks(DateTime date);
        IEnumerable<LampPower> GetSecondsLight(DateTime date);
    }
}