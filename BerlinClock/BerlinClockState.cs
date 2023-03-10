using System.Collections.Generic;

namespace BerlinClock
{
    public class BerlinClockState
    {
        public IEnumerable<LampPower> SecondLamps { get; set; }
        public IEnumerable<LampPower> MinuteLamps { get; set; }
        public IEnumerable<LampPower> FiveMinuteLamps { get; set; }
        public IEnumerable<LampPower> HourLamps { get; set; }
        public IEnumerable<LampPower> FiveHourLamps { get; set; }
    }
}