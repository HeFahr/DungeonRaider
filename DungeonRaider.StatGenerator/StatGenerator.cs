using System;

namespace DungeonRaider.StatGenerator
{
    public interface IStatGenerator
    {
        int GenerateHighStat(int itemDegree, RarityLevel rarityLevel);
        int GenerateLowStat(int itemDegree, RarityLevel rarityLevel);
    }
}
