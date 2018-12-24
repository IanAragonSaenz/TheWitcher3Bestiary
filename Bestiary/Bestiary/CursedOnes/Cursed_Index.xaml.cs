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
    /// Interaction logic for Beast_Index.xaml
    /// </summary>
    public partial class Beast_Index : Page
    {
        public Beast_Index()
        {
            InitializeComponent();
            
        }

        private void Button_Bear_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
            Bestiary.Beasts.Bear bear = new Beasts.Bear();
            LoadPage.NavigationService.Navigate(bear);
        }

        private void Button_Dogs_Click(object sender, RoutedEventArgs e)
        {
            Beasts.Dog dog = new Beasts.Dog();
            ChangePage();
            LoadPage.NavigationService.Navigate(dog);
        }

        private void Button_Panthers_Click(object sender, RoutedEventArgs e)
        {
            Beasts.Panthers panther = new Beasts.Panthers();
            ChangePage();
            LoadPage.NavigationService.Navigate(panther);
        }

        private void Button_Beauclair_Click(object sender, RoutedEventArgs e)
        {
            Beasts.Beau beau = new Beasts.Beau();
            ChangePage();
            LoadPage.NavigationService.Navigate(beau);
        }

        private void Button_Pigs_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
            Beasts.Pigs pigs =new Beasts.Pigs();
            LoadPage.NavigationService.Navigate(pigs);
            
        }

        private void Button_Boars_Click(object sender, RoutedEventArgs e)
        {
            Beasts.Boar boar = new Beasts.Boar();
            ChangePage();
            LoadPage.NavigationService.Navigate(boar);
        }

        private void Button_Wolves_Click(object sender, RoutedEventArgs e)
        {
            Beasts.Wolf wolf = new Beasts.Wolf();
            ChangePage();
            LoadPage.NavigationService.Navigate(wolf);
        }

        private void Button_Return_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
            Index ind = new Index();
            LoadPage.NavigationService.Navigate(ind);
        }

        private void ChangePage()
        {
            pageTurn.Play();
            txt_Description.Visibility = Visibility.Collapsed;
            txt_Title.Visibility = Visibility.Collapsed;
            img_Back.Visibility = Visibility.Collapsed;
            button_Bear.Visibility = Visibility.Collapsed;
            button_Beauclair.Visibility = Visibility.Collapsed;
            button_Boars.Visibility = Visibility.Collapsed;
            button_Dogs.Visibility = Visibility.Collapsed;
            button_Panthers.Visibility = Visibility.Collapsed;
            button_Pigs.Visibility = Visibility.Collapsed;
            button_Return.Visibility = Visibility.Collapsed; 
            button_Wolves.Visibility = Visibility.Collapsed;
            button_BadWolf.Visibility = Visibility.Collapsed;
            
        }

        private void Button_BadWolf_Click(object sender, RoutedEventArgs e)
        {
            Beasts.BigWolf bwolf = new Beasts.BigWolf();
            ChangePage();
            LoadPage.NavigationService.Navigate(bwolf);
        }
    }
}
