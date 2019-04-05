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
    public partial class Fogler : Page
    {
        public Fogler()
        {
            InitializeComponent();
            txt_Description.Text = "Foglets can appear wherever thick fog arises: swamplands, mountain " +
                "passes or the shores of rivers and lakes. If no fog is forthcoming, they can " +
                "create or summon it themselves. ";
            txt_LootText.Text = "Foglet teeth\nFoglet mutagen\nLesser blue mutagen\nEmerald dust\n" +
                "Infused dust";
           
            txt_SusceptibilityText.Text = "Moon dust\nNecrophage oil\nQuen";
            

        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            Necrophages_Index ind = new Necrophages_Index();
            Clear();
            LoadPage.NavigationService.Navigate(ind);
        }

        private void Clear()
        {
            txt_Description.Visibility = Visibility.Collapsed;
            txt_Loot.Visibility = Visibility.Collapsed;
            txt_LootText.Visibility = Visibility.Collapsed;
            
            txt_Susceptibility.Visibility = Visibility.Collapsed;
            txt_SusceptibilityText.Visibility = Visibility.Collapsed;
            txt_Title.Visibility = Visibility.Collapsed;
            button_return.Visibility = Visibility.Collapsed;
            img_Mob.Visibility = Visibility.Collapsed; 
            img_back.Visibility = Visibility.Collapsed;

        }
    }
}
