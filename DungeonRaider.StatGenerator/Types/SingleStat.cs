namespace DungeonRaider.StatGenerator.Types
{
    public class SingleStat : Stat
    {
        public double Value { get; private set; }

        public SingleStat(double value, int percentage, StatType type) : base(percentage, type)
        {
            Value = value;
        }
    }
}
