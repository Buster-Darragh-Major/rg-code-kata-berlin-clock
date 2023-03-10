using System;
using System.Collections.Generic;

namespace BerlinClock
{
    public interface IBerlinClockRules
    {
        IEnumerable<ClockFormatEnum> GetSingleMinutes(DateTime date);
        string GetFiveMinutes(DateTime date);
        string GetSingleHours(DateTime date);
        string GetFiveHourBlocks(DateTime date);
        string GetSecondsLight(DateTime date);
    }
}