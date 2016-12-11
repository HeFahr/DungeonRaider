using DungeonRaider.StatGenerator.Types;
using DungeonRaider.Types;
using System.Collections.Generic;
using System.Linq;

namespace DungeonRaider.ItemBuilder.Types
{
    public class Item
    {
        public RarenessLevel RarenessLevel { get; private set; }
        public ItemDegree Degree { get; private set; }
        public List<Stat> Stats { get; private set; } = new List<Stat>();

        public Item(RarenessLevel rarenesslevel, ItemDegree degree)
        {
            RarenessLevel = rarenesslevel;
            Degree = degree;
        }

        public bool AddStat(Stat stat)
        {
            bool result = false;
            if (!Stats.FirstOrDefault(s => s.StatType.Equals(stat.StatType)).Equals(default(Stat)))
            {
                Stats.Add(stat);
                result = true;
            }
            return result;                
        }

        public Stat GetStat(StatType type)
        {
            return Stats.First(s => s.StatType.Equals(type));
        }
    }
}