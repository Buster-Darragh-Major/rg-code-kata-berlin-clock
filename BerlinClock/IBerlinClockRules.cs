using System;
using System.Collections.Generic;

namespace BerlinClock
{
    public interface IBerlinClockRules
    {
        IEnumerable<ClockFormatEnum> GetSingleMinutes(DateTime date);
        IEnumerable<ClockFormatEnum> GetFiveMinutes(DateTime date);
        IEnumerable<ClockFormatEnum> GetSingleHours(DateTime date);
        IEnumerable<ClockFormatEnum> GetFiveHourBlocks(DateTime date);
        IEnumerable<ClockFormatEnum> GetSecondsLight(DateTime date);
    }
}