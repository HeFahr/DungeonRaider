namespace DungeonRaider.StatGenerator
{
    public class RangeStat
    {
        public double MinValue { get; private set; }
        public double MaxValue { get; private set; }
        public int Percentage { get; private set; }

        public RangeStat(double minValue, double maxValue, int percentage)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            Percentage = percentage;
        }
    }
}
