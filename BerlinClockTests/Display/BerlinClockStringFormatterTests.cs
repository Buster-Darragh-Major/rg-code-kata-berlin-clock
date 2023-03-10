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
        
        [Test]
        public void AllOn()
        {
            var formatter = new BerlinClockStringFormatter();
            var state = new BerlinClockState()
            {
                SecondLamps = new[] { LampPower.ON },
                MinuteLamps = new[] { LampPower.ON, LampPower.ON, LampPower.ON, LampPower.ON },
                FiveMinuteLamps = new[] { LampPower.ON, LampPower.ON, LampPower.ON, LampPower.ON, LampPower.ON, LampPower.ON, LampPower.ON, LampPower.ON, LampPower.ON, LampPower.ON, LampPower.ON },
                HourLamps = new[] { LampPower.ON, LampPower.ON, LampPower.ON, LampPower.ON },
                FiveHourLamps = new[] { LampPower.ON, LampPower.ON, LampPower.ON, LampPower.ON },
            };
            const string expected = "Y\nRRRR\nRRRR\nYYRYYRYYRYY\nYYYY";

            Assert.AreEqual(expected, formatter.Format(state));
        }
        
        [Test]
        public void SomeOn()
        {
            var formatter = new BerlinClockStringFormatter();
            var state = new BerlinClockState()
            {
                SecondLamps = new[] { LampPower.ON },
                MinuteLamps = new[] { LampPower.ON, LampPower.ON, LampPower.OFF, LampPower.OFF },
                FiveMinuteLamps = new[] { LampPower.ON, LampPower.ON, LampPower.ON, LampPower.ON, LampPower.ON, LampPower.OFF, LampPower.OFF, LampPower.OFF, LampPower.OFF, LampPower.OFF, LampPower.OFF },
                HourLamps = new[] { LampPower.ON, LampPower.ON, LampPower.OFF, LampPower.OFF },
                FiveHourLamps = new[] { LampPower.ON, LampPower.ON, LampPower.OFF, LampPower.OFF },
            };
            const string expected = "Y\nRROO\nRROO\nYYRYYOOOOOO\nYYOO";

            Assert.AreEqual(expected, formatter.Format(state));
        }
    }
}