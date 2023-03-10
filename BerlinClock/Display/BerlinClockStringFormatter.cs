using System.Collections.Generic;
using System.Linq;

namespace BerlinClock.Display
{
    public class BerlinClockStringFormatter: IBerlinClockStringFormatter
    {
        private const char Yellow = 'Y';
        private const char Red = 'R';
        private const char Off = 'O';
        
        public string Format(BerlinClockState state)
        {
            return $"{RenderPatternRow(state.SecondLamps, Yellow.ToString())}\n"
                + $"{RenderPatternRow(state.FiveHourLamps, Red.ToString())}\n"
                + $"{RenderPatternRow(state.HourLamps, Red.ToString())}\n"
                + $"{RenderPatternRow(state.FiveMinuteLamps, new string(new [] {Yellow, Yellow, Red}))}\n"
                + $"{RenderPatternRow(state.MinuteLamps, Yellow.ToString())}";
        }

        private string RenderPatternRow(IEnumerable<LampPower> lamps, string pattern)
        {
            var patternIterator = pattern.ToCharArray().GetEnumerator();
            patternIterator.MoveNext();

            return string.Concat(lamps.Select(lamp =>
            {
                var current = patternIterator.Current;
                if (patternIterator.MoveNext())
                {
                    patternIterator.Reset();
                    patternIterator.MoveNext();
                }

                return lamp == LampPower.ON ? current : Off;
            }));
        }
    }
}