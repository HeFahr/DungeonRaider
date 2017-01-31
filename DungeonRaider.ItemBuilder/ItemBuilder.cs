using DungeonRaider.ItemBuilder.Types;
using DungeonRaider.StatGenerator;
using DungeonRaider.StatGenerator.Types;
using DungeonRaider.Types;
using DungeonRaider.Utils.Math;

namespace DungeonRaider.ItemBuilder
{
    public class ItemBuilder
    {
        public ItemStatGenerator WeaponDamageStatGenerator { get; set; }

        public ItemBuilder()
        {
            WeaponDamageStatGenerator = new ItemStatGenerator(
                new StatFunction(4, 0.4, 1.9),
                new StatFunction(4, 0.6, 1.9),
                StatType.Damage
            );
        }

        public Item BuildWeapon(ItemDegree degree)
        {
            Item item = new Item(RarenessLevel.Common, degree);
            item.AddStat(WeaponDamageStatGenerator.GenerateRangeStat(1));
            return item;
        }

        public Item BuildHelmet(ItemDegree degree)
        {
            Item item = new Item(RarenessLevel.Common, degree);

            return item;
        }

        public Item BuildShoulders(ItemDegree degree)
        {
            Item item = new Item(RarenessLevel.Common, degree);

            return item;
        }

        public Item BuildChest(ItemDegree degree)
        {
            Item item = new Item(RarenessLevel.Common, degree);

            return item;
        }

        public Item BuildBracers(ItemDegree degree)
        {
            Item item = new Item(RarenessLevel.Common, degree);

            return item;
        }

        public Item BuildGauntlets(ItemDegree degree)
        {
            Item item = new Item(RarenessLevel.Common, degree);

            return item;
        }

        public Item BuildBelt(ItemDegree degree)
        {
            Item item = new Item(RarenessLevel.Common, degree);

            return item;
        }

        public Item BuildPants(ItemDegree degree)
        {
            Item item = new Item(RarenessLevel.Common, degree);

            return item;
        }

        public Item BuildBoots(ItemDegree degree)
        {
            Item item = new Item(RarenessLevel.Common, degree);

            return item;
        }
    }
}