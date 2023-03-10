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
    }
}