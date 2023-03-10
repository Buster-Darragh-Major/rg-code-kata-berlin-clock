using System;
using System.Collections.Generic;
using System.Linq;

namespace BerlinClock
{
    public class BerlinClockRules : IBerlinClockRules
    {

        public IEnumerable<ClockFormatEnum> GetSingleMinutes(DateTime date)
        {
            var numMinutes = date.Minute % 5;
            return Enumerable.Repeat(ClockFormatEnum.Yellow, numMinutes)
                .Concat(Enumerable.Repeat(ClockFormatEnum.Off, 4 - numMinutes));
        }

        public IEnumerable<ClockFormatEnum> GetFiveMinutes(DateTime date)
        {
            var numFiveMinuteBlocks = date.Minute / 5;
            return new[] { ClockFormatEnum.Yellow };
            // return $"{string.Concat(Enumerable.Repeat("YYR", numFiveMinuteBlocks / 3))}" +
            //        $"{new String('Y', numFiveMinuteBlocks % 3)}" +
            //        $"{new String('O', 11 - numFiveMinuteBlocks)}";
        }

        public IEnumerable<ClockFormatEnum> GetSingleHours(DateTime date)
        {
            var numSingleHourBlocks = date.Hour % 5;
            return Enumerable.Repeat(ClockFormatEnum.Red, numSingleHourBlocks)
                .Concat(Enumerable.Repeat(ClockFormatEnum.Off, 4 - numSingleHourBlocks));
        }

        public IEnumerable<ClockFormatEnum> GetFiveHourBlocks(DateTime date)
        {
            var numFiveHourBlocks = date.Hour / 5;
            return Enumerable.Repeat(ClockFormatEnum.Red, numFiveHourBlocks)
                .Concat(Enumerable.Repeat(ClockFormatEnum.Off, 4 - numFiveHourBlocks));
        }

        public IEnumerable<ClockFormatEnum> GetSecondsLight(DateTime date)
        {
            return Enumerable.Repeat(date.Second % 2 == 0 ? ClockFormatEnum.Yellow : ClockFormatEnum.Off, 1);
        }
    }
}