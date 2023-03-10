using System;

namespace BerlinClock.Display
{
    public class BerlinClockDisplay : IBerlinClockDisplay
    {
        private readonly IBerlinClockStringFormatter _berlinClockStringFormatter;

        public BerlinClockDisplay(IBerlinClockStringFormatter berlinClockStringFormatter)
        {
            _berlinClockStringFormatter = berlinClockStringFormatter;
        }
        
        public void Display(BerlinClockState berlinClockState)
        {
            Console.Clear();
            Console.Write(_berlinClockStringFormatter.Format(berlinClockState));
        }
    }
}