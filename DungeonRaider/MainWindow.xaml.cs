using System.Windows;

namespace DungeonRaider
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MaximumHealth = 100;
            CurrentHealth = 50;
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
        
    }
}
