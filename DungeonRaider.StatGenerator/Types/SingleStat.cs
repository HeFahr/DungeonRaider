namespace DungeonRaider.StatGenerator.Types
{
    public class SingleStat
    {
        public double Value { get; private set; }
        public int Percentage { get; private set; }

        public SingleStat(double value, int percentage)
        {
            Value = value;
            Percentage = percentage;
        }
    }
}
