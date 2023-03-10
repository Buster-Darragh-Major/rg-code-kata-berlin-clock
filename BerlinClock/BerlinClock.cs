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
                $"{_rules.GetSecondLamps(time)}{_rules.GetFiveHourBlockLamps(time)}{_rules.GetSingleHourLamps(time)}" +
                $"{_rules.GetFiveMinuteLamps(time)}{_rules.GetSingleMinuteLamps(time)}";
        }
        public string DisplayReadableTime()
        {
            var time = _time;
            return
                $"{_rules.GetSecondLamps(time)}\n{_rules.GetFiveHourBlockLamps(time)}\n{_rules.GetSingleHourLamps(time)}\n" +
                $"{_rules.GetFiveMinuteLamps(time)}\n{_rules.GetSingleMinuteLamps(time)}";
        }
    }
}