using System;
using BerlinClock;
using NUnit.Framework;

namespace BerlinClockTests
{
    [TestFixture]
    public class Tests
    {
        [TestCase("01/01/2000 00:00:00", "OOOO")]
        [TestCase("01/01/2000 23:59:59", "YYYY")]
        [TestCase("01/01/2000 12:32:00", "YYOO")]
        [TestCase("01/01/2000 12:34:00", "YYYY")]
        [TestCase("01/01/2000 12:35:00", "OOOO")]
        public void ParseToSingleMinutesRow(string dateTime, string expected)
        {
            var berlinClock = new BerlinClockRules();
            Assert.AreEqual(expected, berlinClock.GetSingleMinutes(DateTime.Parse(dateTime)));
        }

        [TestCase("01/01/2000 00:00:00", "OOOOOOOOOOO")]
        [TestCase("01/01/2000 23:59:59", "YYRYYRYYRYY")]
        [TestCase("01/01/2000 12:04:00", "OOOOOOOOOOO")]
        [TestCase("01/01/2000 12:23:00", "YYRYOOOOOOO")]
        [TestCase("01/01/2000 12:35:00", "YYRYYRYOOOO")]
        public void ParseToFiveMinutes(string dateTime, string expected)
        {
            var berlinClock = new BerlinClockRules();
            Assert.AreEqual(expected, berlinClock.GetFiveMinutes(DateTime.Parse(dateTime)));
        }

        [TestCase("01/01/2000 00:00:00", "OOOO")]
        [TestCase("01/01/2000 23:59:59", "RRRO")]
        [TestCase("01/01/2000 02:04:00", "RROO")]
        [TestCase("01/01/2000 08:23:00", "RRRO")]
        [TestCase("01/01/2000 14:35:00", "RRRR")]
        public void ParseToSingleHoursRow(string dateTime, string expected)
        {
            var berlinClock = new BerlinClockRules();
            Assert.AreEqual(expected, berlinClock.GetSingleHours(DateTime.Parse(dateTime)));
        } 
        
        [TestCase("01/01/2000 00:00:00", "OOOO")]
        [TestCase("01/01/2000 23:59:59", "RRRR")]
        [TestCase("01/01/2000 02:04:00", "OOOO")]
        [TestCase("01/01/2000 08:23:00", "ROOO")]
        [TestCase("01/01/2000 16:35:00", "RRRO")]
        public void ParseToFiveHoursRow(string dateTime, string expected)
        {
            var berlinClock = new BerlinClockRules();
            Assert.AreEqual(expected, berlinClock.GetFiveHourBlocks(DateTime.Parse(dateTime)));
        }

        [TestCase("01/01/2000 00:00:00", "Y")]
        [TestCase("01/01/2000 23:59:59", "O")]
        public void ParseToSecondsLight(string dateTime, string expected)
        {
            var berlinClock = new BerlinClockRules();
            Assert.AreEqual(expected, berlinClock.GetSecondsLight(DateTime.Parse(dateTime)));
        }

        [TestCase("01/01/2000 00:00:00", "YOOOOOOOOOOOOOOOOOOOOOOO")]
        [TestCase("01/01/2000 23:59:59", "ORRRRRRROYYRYYRYYRYYYYYY")]
        [TestCase("01/01/2000 16:50:06", "YRRROROOOYYRYYRYYRYOOOOO")]
        [TestCase("01/01/2000 11:37:01", "ORROOROOOYYRYYRYOOOOYYOO")]
        public void CompleteClockTest(string dateTime, string expected)
        {
            var rules = new BerlinClockRules();
            var date = DateTime.Parse(dateTime);
            var clock = new BerlinClock.BerlinClock(rules, date);
            
            Assert.AreEqual(expected, clock.DisplayTime());
        }
        
    }
}