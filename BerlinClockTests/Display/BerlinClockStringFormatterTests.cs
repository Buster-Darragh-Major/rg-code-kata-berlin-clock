using BerlinClock;
using BerlinClock.Display;
using NUnit.Framework;

namespace BerlinClockTests.Display
{
    public class BerlinClockStringFormatterTests
    {
        [Test]
        public void AllOff()
        {
            var formatter = new BerlinClockStringFormatter();
            var state = new BerlinClockState()
            {
                SecondLamps = new[] { LampPower.OFF },
                MinuteLamps = new[] { LampPower.OFF, LampPower.OFF, LampPower.OFF, LampPower.OFF },
                FiveMinuteLamps = new[] { LampPower.OFF, LampPower.OFF, LampPower.OFF, LampPower.OFF, LampPower.OFF, LampPower.OFF, LampPower.OFF, LampPower.OFF, LampPower.OFF, LampPower.OFF, LampPower.OFF },
                HourLamps = new[] { LampPower.OFF, LampPower.OFF, LampPower.OFF, LampPower.OFF },
                FiveHourLamps = new[] { LampPower.OFF, LampPower.OFF, LampPower.OFF, LampPower.OFF },
            };
            const string expected = "O\nOOOO\nOOOO\nOOOOOOOOOOO\nOOOO";

            Assert.AreEqual(expected, formatter.Format(state));
        }
    }
}