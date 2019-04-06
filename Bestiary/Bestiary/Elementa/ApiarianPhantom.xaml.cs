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

    public partial class ApiarianPhantom : Page
    {
        public ApiarianPhantom()
        {
            InitializeComponent();
            txt_Description.Text ="A powerful Hound of the Wild Hunt who strayed from its pack during one of their numerous raids.";
            txt_LootText.Text = "Wild Hunt Hound Thropy\nSulfur";
            txt_SusceptibilityText.Text = "Dimeritium Bomb\nElementa Oil\nIgni\nAxii";
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
            txt_Variation.Visibility = Visibility.Collapsed;
            button_variation.Visibility = Visibility.Collapsed;
        }

        private void Button_variation_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            HoundWildHunt mydoggo = new HoundWildHunt();
            LoadPage.NavigationService.Navigate(mydoggo);

        }
    }
}
