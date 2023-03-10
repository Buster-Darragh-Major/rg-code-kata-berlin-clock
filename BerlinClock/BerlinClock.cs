using System;
using BerlinClock.Display;
using BerlinClock.Rules;

namespace BerlinClock
{
    public class BerlinClock
    {
        private readonly DateTime _time;
        private readonly IBerlinClockRules _rules;
        private readonly IBerlinClockDisplay _display;

        public BerlinClock(DateTime startTime, IBerlinClockRules rules, IBerlinClockDisplay display)
        {
            _time = startTime;
            _rules = rules;
            _display = display;
        }

        public void Start()
        {
            
        }
    }
}