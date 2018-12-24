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

namespace Bestiary.Beasts
{
  
    public partial class Bear : Page
    {
        public Bear()
        {
            InitializeComponent();
        }

        private void Button_Variation1_Click(object sender, RoutedEventArgs e)
        {
            Cursed.Berserker berserker = new Cursed.Berserker();
            LoadPage.NavigationService.Navigate(berserker);
            Clear();
        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            Beast_Index ind = new Beast_Index();
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
            txt_Variation.Visibility = Visibility.Collapsed;
            button_return.Visibility = Visibility.Collapsed;
            button_Variation1.Visibility = Visibility.Collapsed;
            img_Mob.Visibility = Visibility.Collapsed; 
            img_back.Visibility = Visibility.Collapsed;

        }
    }
}
