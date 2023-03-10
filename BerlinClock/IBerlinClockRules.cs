using System;

namespace BerlinClock
{
    public interface IBerlinClockRules
    {
        string GetSingleMinutes(DateTime date);
        string GetFiveMinutes(DateTime date);
        string GetSingleHours(DateTime date);
        string GetFiveHourBlocks(DateTime date);
        string GetSecondsLight(DateTime date);
    }
}