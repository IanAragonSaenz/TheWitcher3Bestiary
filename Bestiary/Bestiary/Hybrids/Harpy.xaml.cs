﻿using System;
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
    public partial class Harpy : Page
    {
        public Harpy()
        {
            InitializeComponent();
            txt_Description.Text = "There are many harpy species, and all are kleptomaniacs, though some steal dreams instead "
                + "of baubles. They especially like dreams laden with strong emotions, such as nightmares that " +
                "recur time and again.";
            txt_LootText.Text = "Harpy egg\nHarpy eyes\nHarpy feathers\nHarpy saliva\nHarpy claws\n" +
                "Cloth\nRobust cloth\nTwine\nLeather\nHardened leather\nOrens";
           
            txt_SusceptibilityText.Text = "Harpy trap\nIgni sign";
            

        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            Hybrids_Index ind = new Hybrids_Index();
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
