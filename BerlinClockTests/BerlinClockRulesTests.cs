using System;
using System.Collections.Generic;
using System.Linq;
using BerlinClock;
using NUnit.Framework;

namespace BerlinClockTests
{
    [TestFixture]
    public class BerlinCLockRulesTests
    {
        [TestCase("01/01/2000 00:00:00", "OOOO")]
        [TestCase("01/01/2000 23:59:59", "YYYY")]
        [TestCase("01/01/2000 12:32:00", "YYOO")]
        [TestCase("01/01/2000 12:34:00", "YYYY")]
        [TestCase("01/01/2000 12:35:00", "OOOO")]
        public void ParseToSingleMinutesRow(string dateTime, string expected)
        {
            var berlinClock = new BerlinClockRules();
            Assert.AreEqual(ParseExpected(expected), berlinClock.GetSingleMinuteLamps(DateTime.Parse(dateTime)));
        }

        [TestCase("01/01/2000 00:00:00", "OOOOOOOOOOO")]
        [TestCase("01/01/2000 23:59:59", "YYRYYRYYRYY")]
        [TestCase("01/01/2000 12:04:00", "OOOOOOOOOOO")]
        [TestCase("01/01/2000 12:23:00", "YYRYOOOOOOO")]
        [TestCase("01/01/2000 12:35:00", "YYRYYRYOOOO")]
        public void ParseToFiveMinutes(string dateTime, string expected)
        {
            var berlinClock = new BerlinClockRules();
            Assert.AreEqual(ParseExpected(expected), berlinClock.GetFiveMinuteLamps(DateTime.Parse(dateTime)));
        }

        [TestCase("01/01/2000 00:00:00", "OOOO")]
        [TestCase("01/01/2000 23:59:59", "RRRO")]
        [TestCase("01/01/2000 02:04:00", "RROO")]
        [TestCase("01/01/2000 08:23:00", "RRRO")]
        [TestCase("01/01/2000 14:35:00", "RRRR")]
        public void ParseToSingleHoursRow(string dateTime, string expected)
        {
            var berlinClock = new BerlinClockRules();
            Assert.AreEqual(ParseExpected(expected), berlinClock.GetSingleHourLamps(DateTime.Parse(dateTime)));
        } 
        
        [TestCase("01/01/2000 00:00:00", "OOOO")]
        [TestCase("01/01/2000 23:59:59", "RRRR")]
        [TestCase("01/01/2000 02:04:00", "OOOO")]
        [TestCase("01/01/2000 08:23:00", "ROOO")]
        [TestCase("01/01/2000 16:35:00", "RRRO")]
        public void ParseToFiveHoursRow(string dateTime, string expected)
        {
            var berlinClock = new BerlinClockRules();
            Assert.AreEqual(ParseExpected(expected), berlinClock.GetFiveHourBlockLamps(DateTime.Parse(dateTime)));
        }

        [TestCase("01/01/2000 00:00:00", "Y")]
        [TestCase("01/01/2000 23:59:59", "O")]
        public void ParseToSecondsLight(string dateTime, string expected)
        {
            var berlinClock = new BerlinClockRules();
            Assert.AreEqual(ParseExpected(expected), berlinClock.GetSecondLamps(DateTime.Parse(dateTime)));
        }

        private IEnumerable<LampPower> ParseExpected(string expected)
        {
            return expected.ToList().ConvertAll(@char =>
            {
                switch (@char)
                {
                    case 'Y':
                    case 'R':
                        return LampPower.ON;
                    default:
                        return LampPower.OFF;
                }
            });
        }

    }
}