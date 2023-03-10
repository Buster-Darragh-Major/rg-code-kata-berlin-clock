using System;
using System.Threading;
using BerlinClock.Display;
using BerlinClock.Rules;

namespace BerlinClock
{
    public class TickingBerlinClock
    {
        private readonly IBerlinClockRules _rules;
        private readonly IBerlinClockDisplay _display;

        private BerlinClockState _state;

        public TickingBerlinClock(IBerlinClockRules rules, IBerlinClockDisplay display)
        {
            _rules = rules;
            _display = display;
        }

        public void Start()
        {
            // Fine for now lol
            while (true)
            {
                UpdateState();
                DisplayTime();
                Thread.Sleep(1000);
            }
        }

        private void UpdateState()
        {
            if (_state == null)
            {
                _state = new BerlinClockState();
            }

            var time = GetTime();
            
            _state.SecondLamps = _rules.GetSecondLamps(time);
            _state.MinuteLamps = _rules.GetMinuteLamps(time);
            _state.FiveMinuteLamps = _rules.GetFiveMinuteLamps(time);
            _state.HourLamps = _rules.GetHourLamps(time);
            _state.FiveHourLamps = _rules.GetFiveHourBlockLamps(time);
        }
        
        private void DisplayTime()
        {
            _display.Display(_state);
        }

        private DateTime GetTime()
        {
            return DateTime.Now;
        }
    }
}