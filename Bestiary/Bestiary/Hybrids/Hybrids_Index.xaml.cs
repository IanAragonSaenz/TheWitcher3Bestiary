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
   
    public partial class Hybrids_Index : Page
    {
        public Hybrids_Index()
        {
            InitializeComponent();
            
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
            Djinn djinn = new Djinn();
            LoadPage.NavigationService.Navigate(djinn);
            

        }

        private void Button_Return_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
            Index ind = new Index();
            LoadPage.NavigationService.Navigate(ind);
       

        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            Golem golem = new Golem();
            ChangePage();
            LoadPage.NavigationService.Navigate(golem);
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            Pixies pixie = new Pixies();
            LoadPage.NavigationService.Navigate(pixie);
            ChangePage();
         
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            Ekhidna ekhidna = new Ekhidna();
            ChangePage();
            LoadPage.NavigationService.Navigate(ekhidna);
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            //Hound of the wild Hunt
            HoundWildHunt houndwildhunt = new HoundWildHunt();
            ChangePage();
            LoadPage.NavigationService.Navigate(houndwildhunt);
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            SilverBask silvb = new SilverBask();
            ChangePage();
            LoadPage.NavigationService.Navigate(silvb);

        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            Harpy harpy = new Harpy();
            ChangePage();
            LoadPage.NavigationService.Navigate(harpy);
        }

        private void ChangePage()
        {
            pageTurn.Play();
            txt_Description.Visibility = Visibility.Collapsed;
            txt_Title.Visibility = Visibility.Collapsed;
            button_1.Visibility = Visibility.Collapsed;
            button_2.Visibility = Visibility.Collapsed;
            button_3.Visibility = Visibility.Collapsed;
            button_4.Visibility = Visibility.Collapsed;
            button_5.Visibility = Visibility.Collapsed;
            button_6.Visibility = Visibility.Collapsed;
            button_7.Visibility = Visibility.Collapsed;
            button_8.Visibility = Visibility.Collapsed;
            button_9.Visibility = Visibility.Collapsed;
            button_Return.Visibility = Visibility.Collapsed;
            img_Back.Visibility = Visibility.Collapsed; 
          
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
            Salma salma = new Salma();
            LoadPage.NavigationService.Navigate(salma);
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            TheDragon mahdragon = new TheDragon();
            ChangePage();
            LoadPage.NavigationService.Navigate(mahdragon);
        }
    }
}
