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
    public partial class TheDragon : Page
    {
        public TheDragon()
        {
            InitializeComponent();
            txt_Description.Text ="It is a powerful forktail living in the ruins of a destroyed assault tower near the village of its nickname." +
                "It's inaccuretaly referred to as the dragon on account of the villagers mistakenly believing it is one.";
            txt_LootText.Text = "Dragon Scales\nForktail Mutagen\nForktail Hide\nForktail Trophy\nMonster Bone\nMonster Heart\nMonster Tongue";
            txt_SusceptibilityText.Text = "Golden Oriole\nGrapeshot\nDraconid Oil\nAard";
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
            txt_variation.Visibility = Visibility.Collapsed;
            btn_Variation.Visibility = Visibility.Collapsed;

        }

        private void Btn_Variation_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            Forktail forkTail = new Forktail();
            LoadPage.NavigationService.Navigate(forkTail);
        }
    }
}
