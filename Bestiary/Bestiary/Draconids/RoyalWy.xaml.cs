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
    public partial class RoyalWy : Page
    {
        public RoyalWy()
        {
            InitializeComponent();
            txt_Description.Text ="A hunters knows his prey's habits, however, some monsters also prossess such knowledge" +
                ".\nRoyal Wyverns from Velen had learned the danger of exposing itself to human eyes and arrows by " +
                "flying high to pick out its prey from afar. Instead, it would lurk by the roadside and wait for military transports." +
                "in this way it grew fat on salted pork and beer, expanding until it resembled a dragon more than other," +
                "lesser members of its own kind. ";
            txt_LootText.Text = "Wyvern Trophy\nWyvern Mutagen\nWyvern Egg\nAnathema";
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
            btn_Variation.Visibility = Visibility.Collapsed;
            txt_variation.Visibility = Visibility.Collapsed;
            
        }
        
        private void Btn_Variation_Click(object sender,RoutedEventArgs e)
        {
            Clear();
            Wyverns wyv = new Wyverns();
            LoadPage.NavigationService.Navigate(wyv);
        }
    }
}
