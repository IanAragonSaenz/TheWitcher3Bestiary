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
    public partial class Wyverns : Page
    {
        public Wyverns()
        {
            InitializeComponent();
            txt_Description.Text ="Wyverns are often mistaken for dragons, and, though they are much smaller than their more famous kin and do" +
                "not breathe fire, they are likewise extremely dangerous monsters. Especially feared are the so-called royal wyverns who, " +
                " like their namesake monarchs, are excceptionally ornery and extremely deadly.";
            txt_LootText.Text = "Dragon Scales\nMonster Blood\nMonster Bone\nMonster Brain\nMonster Claw\nMonster Eye\nWyvern Egg\nWyvern Hide\nWyvern Mutagen\nWyvern Trophy";
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
            RoyalWy rowy = new RoyalWy();
            LoadPage.NavigationService.Navigate(rowy);
        }
    }
}
