using System;
using System.Collections.Generic;
using System.Linq;

namespace BerlinClock
{
    public class BerlinClockRules : IBerlinClockRules
    {
        private const int SecondsLampLength = 1;
        private const int MinutesLampLength = 4;
        private const int FiveMinutesLampLength = 11;
        private const int HoursLampLength = 4;
        private const int FiveHoursLampLength = 4;

        public IEnumerable<LampPower> GetSingleMinuteLamps(DateTime date)
        {
            var numMinutes = date.Minute % 5;
            return GenerateLampsByLength(numMinutes, MinutesLampLength);
        }

        public IEnumerable<LampPower> GetFiveMinuteLamps(DateTime date)
        {
            var numFiveMinuteBlocks = date.Minute / 5;
            return GenerateLampsByLength(numFiveMinuteBlocks, FiveMinutesLampLength);
        }

        public IEnumerable<LampPower> GetSingleHourLamps(DateTime date)
        {
            var numSingleHourBlocks = date.Hour % 5;
            return GenerateLampsByLength(numSingleHourBlocks, HoursLampLength);
        }

        public IEnumerable<LampPower> GetFiveHourBlockLamps(DateTime date)
        {
            var numFiveHourBlocks = date.Hour / 5;
            return GenerateLampsByLength(numFiveHourBlocks, FiveHoursLampLength);
        }

        public IEnumerable<LampPower> GetSecondLamps(DateTime date)
        {
            var secondsRemainder = date.Second % 2;
            return GenerateLampsByLength(secondsRemainder == 1 ? 0 : 1, SecondsLampLength);
        }

        private IEnumerable<LampPower> GenerateLampsByLength(int lampsOn, int lampsLength)
        {
            return Enumerable.Repeat(LampPower.ON, lampsOn)
                .Concat(Enumerable.Repeat(LampPower.OFF, lampsLength - lampsOn));
        }
    }
}