using System;
using System.Linq;
using System.Text;

namespace BerlinClock
{
    public class BerlinClock
    {
        private readonly DateTime _date;

        public BerlinClock(DateTime date)
        {
            _date = date;
        }

        public string GetSingleMinutes()
        {
            var numMinutes = _date.Minute % 5;
            return $"{new String('Y', numMinutes)}{new String('O', 4 - numMinutes)}";
        }

        public string GetFiveMinutes()
        {
            var numMinutes = _date.Minute / 5;
            return $"{string.Concat(Enumerable.Repeat("YYR", numMinutes / 3))}" +
                   $"{new String('Y', numMinutes % 3)}" +
                   $"{new String('O', 11 - numMinutes)}";
        }
    }
}