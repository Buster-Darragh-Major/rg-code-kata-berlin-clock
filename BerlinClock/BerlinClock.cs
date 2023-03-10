using System;

namespace BerlinClock
{
    public class BerlinClock
    {
        private readonly IBerlinClockRules _rules;
        private readonly DateTime _time;

        public BerlinClock(IBerlinClockRules rules, DateTime startTime)
        {
            _rules = rules;
            _time = startTime;
        }

        public string DisplayTime()
        {
            var time = _time;
            return
                $"{_rules.GetSecondsLight(time)}{_rules.GetFiveHourBlocks(time)}{_rules.GetSingleHours(time)}" +
                $"{_rules.GetFiveMinutes(time)}{_rules.GetSingleMinutes(time)}";
        }
        public string DisplayReadableTime()
        {
            var time = _time;
            return
                $"{_rules.GetSecondsLight(time)}\n{_rules.GetFiveHourBlocks(time)}\n{_rules.GetSingleHours(time)}\n" +
                $"{_rules.GetFiveMinutes(time)}\n{_rules.GetSingleMinutes(time)}";
        }
    }
}