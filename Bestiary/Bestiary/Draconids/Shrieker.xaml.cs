using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bestiary
{
    /// <summary>
    /// Interaction logic for Bear.xaml
    /// </summary>
    public partial class Shrieker : Page
    {
        public Shrieker()
        {
            InitializeComponent();
            txt_Description.Text ="A powerful Cockatrice living inside a cave located on the outskirts of Crow's Peach.\n" +
                "It has a surgical precision on its strikes, which slice open arteries a d provoke an outpouring of blood only" +
                "the Swallow potion could hope to stop.";
            txt_LootText.Text = "Cockatrice Egg\nCockatrice Mutagen\nCockatrice Stomach\nCockatrice Trophy\nDwarven Axe" +
                "\nDwarven Axe\nMonster Carapace\nMonster Feather\nMonster Saliva";
            txt_SusceptibilityText.Text = "Grapeshot\nDraconid Oil\nAard";
            

        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            Draco_Index ind = new Draco_Index();
            Clear();
            LoadPage.NavigationService.Navigate(ind);
        }

        private void Clear()
        {
            txt_Description.Visibility = Visibility.Collapsed;
            txt_Loot.Visibility = Visibility.Collapsed;
            txt_LootText.Visibility = Visibility.Collapsed;
            txt_Ocurrence.Visibility = Visibility.Collapsed;
            txt_OcurrenceText.Visibility = Visibility.Collapsed;
            txt_Susceptibility.Visibility = Visibility.Collapsed;
            txt_SusceptibilityText.Visibility = Visibility.Collapsed;
            txt_Title.Visibility = Visibility.Collapsed;
            button_return.Visibility = Visibility.Collapsed;
            img_Mob.Visibility = Visibility.Collapsed; 
            img_back.Visibility = Visibility.Collapsed;

        }
    }
}
