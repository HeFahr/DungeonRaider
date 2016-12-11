using DungeonRaider.StatGenerator.Types;

namespace DungeonRaider.StatGenerator
{
    public class RangeStat : Stat
    {
        public double MinValue { get; private set; }
        public double MaxValue { get; private set; }

        public RangeStat(double minValue, double maxValue, int percentage, StatType type) : base(percentage, type)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }
    }
}
