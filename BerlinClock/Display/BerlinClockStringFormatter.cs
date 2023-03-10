using System.Linq;

namespace BerlinClock.Display
{
    public class BerlinClockStringFormatter: IBerlinClockStringFormatter
    {
        public string Format(BerlinClockState state)
        {
            return $"{string.Concat(state.SecondLamps.Select(lamp => lamp == LampPower.ON ? 'Y' : 'O'))}\n"
                + $"{string.Concat(state.FiveHourLamps.Select(lamp => lamp == LampPower.ON ? 'R' : 'O'))}\n"
                + $"{string.Concat(state.HourLamps.Select(lamp => lamp == LampPower.ON ? 'R' : 'O'))}\n"
                + $"{string.Concat(state.FiveMinuteLamps.Select(lamp => lamp == LampPower.ON ? 'Y' : 'O'))}\n"
                + $"{string.Concat(state.MinuteLamps.Select(lamp => lamp == LampPower.ON ? 'Y' : 'O'))}";
        }
    }
}