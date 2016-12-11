namespace DungeonRaider.StatGenerator.Types
{
    public abstract class Stat
    {
        public virtual int Percentage { get; private set; }
        public virtual StatType StatType { get; private set; }

        public Stat(int percentage, StatType type)
        {
            Percentage = percentage;
            StatType = type;
        }
    }
}
