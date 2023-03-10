using System;
using System.Collections.Generic;

namespace BerlinClock
{
    public interface IBerlinClockRules
    {
        IEnumerable<LampPower> GetSingleMinuteLamps(DateTime date);
        IEnumerable<LampPower> GetFiveMinuteLamps(DateTime date);
        IEnumerable<LampPower> GetSingleHourLamps(DateTime date);
        IEnumerable<LampPower> GetFiveHourBlockLamps(DateTime date);
        IEnumerable<LampPower> GetSecondLamps(DateTime date);
    }
}