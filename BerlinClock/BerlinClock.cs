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
            var numFiveMinuteBlocks = _date.Minute / 5;
            return $"{string.Concat(Enumerable.Repeat("YYR", numFiveMinuteBlocks / 3))}" +
                   $"{new String('Y', numFiveMinuteBlocks % 3)}" +
                   $"{new String('O', 11 - numFiveMinuteBlocks)}";
        }

        public string GetSingleHours()
        {
            var numSingleHourBlocks = _date.Hour % 5;
            return $"{new String('R', numSingleHourBlocks)}{new String('O', 4 - numSingleHourBlocks)}";
        }

        public string GetFiveHourBlocks()
        {
            var numFiveHourBlocks = _date.Hour / 5;
            return $"{new String('R', numFiveHourBlocks)}{new String('O', 4 - numFiveHourBlocks)}";
        }
    }
}