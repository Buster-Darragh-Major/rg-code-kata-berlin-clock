namespace BerlinClock.Display
{
    public interface IBerlinClockFormatter
    {
        string Format(BerlinClockState state);
    }
}