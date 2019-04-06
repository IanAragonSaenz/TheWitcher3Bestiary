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

    public partial class FireElemental : Page
    {
        public FireElemental()
        {
            InitializeComponent();
            txt_Description.Text ="Fire is the most destructive of the elements, thus the aggressive lethality of the creature" +
                "that embodies its essence should come as no surprise. Fire elementals are forged" +
                " in complicated magic rituals for one purpose: destruction. And they pursue this with murderous determination.";
            txt_LootText.Text = "Greater Dazhbog Runestone";
            txt_SusceptibilityText.Text = "Dimeritium Bomb\nNorthern Wind\nElementa Oil\nAard";
        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            Elementa_Index ind = new Elementa_Index();
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

        private void Button_variation_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            HoundWildHunt mydoggo = new HoundWildHunt();
            LoadPage.NavigationService.Navigate(mydoggo);

        }
    }
}
