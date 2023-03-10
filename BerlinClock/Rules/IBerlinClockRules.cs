using System;
using System.Collections.Generic;

namespace BerlinClock.Rules
{
    public interface IBerlinClockRules
    {
        IEnumerable<LampPower> GetMinuteLamps(DateTime date);
        IEnumerable<LampPower> GetFiveMinuteLamps(DateTime date);
        IEnumerable<LampPower> GetHourLamps(DateTime date);
        IEnumerable<LampPower> GetFiveHourBlockLamps(DateTime date);
        IEnumerable<LampPower> GetSecondLamps(DateTime date);
    }
}