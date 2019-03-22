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
    public partial class SilverBask : Page
    {
        public SilverBask()
        {
            InitializeComponent();
            txt_Description.Text ="Silver Basilisks were once a dominating species, especially in the region of Toussaint where they were very common" +
                "around the year 1100. Their extirpation in the duchy, and possibly near-exctinction in the world as a whole, is chiefly due to hunting by humans for the monster's " +
                "silver-colored hides.";
         
            txt_SusceptibilityText.Text = "Golden Oriole\nDraconid Oil\nAard\nIgni";
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

        private void Btn_Variation_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            Shrieker shriek = new Shrieker();
            LoadPage.NavigationService.Navigate(shriek);
        }
    }
}
