using System;
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
        public void SingleMinutesRow(string dateTime, string expected)
        {
            var berlinClock = new BerlinClock.BerlinClock(DateTime.Parse(dateTime));
            Assert.AreEqual(expected, berlinClock.GetSingleMinutes());
        }

        [TestCase("01/01/2000 00:00:00", "OOOOOOOOOOO")]
        [TestCase("01/01/2000 23:59:59", "YYRYYRYYRYY")]
        [TestCase("01/01/2000 12:04:00", "OOOOOOOOOOO")]
        [TestCase("01/01/2000 12:23:00", "YYRYOOOOOOO")]
        [TestCase("01/01/2000 12:35:00", "YYRYYRYOOOO")]
        public void FiveMinutes(string dateTime, string expected)
        {
            var berlinClock = new BerlinClock.BerlinClock(DateTime.Parse(dateTime));
            Assert.AreEqual(expected, berlinClock.GetFiveMinutes());
        }
    }
}