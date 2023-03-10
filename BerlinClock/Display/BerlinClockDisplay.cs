using System;

namespace BerlinClock.Display
{
    public class BerlinClockDisplay : IBerlinClockDisplay
    {
        private readonly IBerlinClockFormatter _berlinClockFormatter;

        public BerlinClockDisplay(IBerlinClockFormatter berlinClockFormatter)
        {
            _berlinClockFormatter = berlinClockFormatter;
        }
        
        public void Display(BerlinClockState berlinClockState)
        {
            Console.Write(_berlinClockFormatter.Format(berlinClockState));
        }
    }
}