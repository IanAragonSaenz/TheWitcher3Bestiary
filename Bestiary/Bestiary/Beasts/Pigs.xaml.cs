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
    /// <summary>
    /// Interaction logic for Bear.xaml
    /// </summary>
    public partial class Pigs : Page
    {
        public Pigs()
        {
            InitializeComponent();
            txt_Description.Text = "Originally creates by Artorius Vigo as part of the Fablesphere, an illusory realm intended to serve as entertainment for "+
                "Anna Henrietta and Syanna when they were children. However, over time, the Pigs ceased to be docile fairy tale characters"+
                " and transformed into hostile beast as the spells supporting the Fablesphere became unstable in the absence of Artorius Vigo's supervision.";
            button_Variation1.Content = "Wild Boar";
            
           
            txt_LootText.Text = "Magic Dust";
            

        }

        private void Button_Variation1_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            Boar boar = new Boar();
            LoadPage.NavigationService.Navigate(boar);

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
