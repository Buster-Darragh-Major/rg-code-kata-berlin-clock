﻿using System;
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

        public string GetFiveMinutes(DateTime date)
        {
            var numFiveMinuteBlocks = date.Minute / 5;
            return $"{string.Concat(Enumerable.Repeat("YYR", numFiveMinuteBlocks / 3))}" +
                   $"{new String('Y', numFiveMinuteBlocks % 3)}" +
                   $"{new String('O', 11 - numFiveMinuteBlocks)}";
        }

        public string GetSingleHours(DateTime date)
        {
            var numSingleHourBlocks = date.Hour % 5;
            return $"{new String('R', numSingleHourBlocks)}{new String('O', 4 - numSingleHourBlocks)}";
        }

        public string GetFiveHourBlocks(DateTime date)
        {
            var numFiveHourBlocks = date.Hour / 5;
            return $"{new String('R', numFiveHourBlocks)}{new String('O', 4 - numFiveHourBlocks)}";
        }

        public string GetSecondsLight(DateTime date)
        {
            return (date.Second % 2 == 0) ? "Y" : "O";
        }
    }
}