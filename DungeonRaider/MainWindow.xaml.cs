using DungeonRaider.ItemBuilder.Types;
using DungeonRaider.StatGenerator;
using System.Windows;

namespace DungeonRaider
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ItemBuilder.ItemBuilder ItemBuilder { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            MaximumHealth = 100;
            CurrentHealth = 50;

            ItemBuilder = new ItemBuilder.ItemBuilder();
        }
        
        public int MaximumHealth { get; set; }
        public int CurrentHealth { get; set; }

        private void DungeonButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello Dungeon!");
        }

        private void EnhanceButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello Enhance!");
        }

        private void InventoryButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello Enhance!");
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            var weapon = ItemBuilder.BuildWeapon(ItemDegree.First);
            var stats = weapon.Stats.ToArray()[0] as RangeStat;
            int count = 0;
            while (stats.Percentage != 100)
            {
                weapon = ItemBuilder.BuildWeapon(ItemDegree.First);
                stats = weapon.Stats.ToArray()[0] as RangeStat;
                count++;
            }
            //MessageBox.Show(stats.Percentage.ToString());
            //MessageBox.Show(stats.MinValue + " - " + stats.MaxValue);
            MessageBox.Show(count.ToString());
        }
    }
}
