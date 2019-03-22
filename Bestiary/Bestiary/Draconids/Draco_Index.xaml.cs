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
   
    public partial class Draco_Index : Page
    {
        public Draco_Index()
        {
            InitializeComponent();
            
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
            Basilisks basilisks = new Basilisks();
            LoadPage.NavigationService.Navigate(basilisks);
            

        }

        private void Button_Return_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
            Index ind = new Index();
            LoadPage.NavigationService.Navigate(ind);
       

        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            Cockatrices cocka = new Cockatrices();
            ChangePage();
            LoadPage.NavigationService.Navigate(cocka);
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            Forktail forkTail = new Forktail();
            LoadPage.NavigationService.Navigate(forkTail);
            ChangePage();
         
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            RoyalWy royal = new RoyalWy();
            ChangePage();
            LoadPage.NavigationService.Navigate(royal);
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            Shrieker shrieker = new Shrieker();
            ChangePage();
            LoadPage.NavigationService.Navigate(shrieker);
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            SilverBask silvb = new SilverBask();
            ChangePage();
            LoadPage.NavigationService.Navigate(silvb);

        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            Slyzard sly = new Slyzard();
            ChangePage();
            LoadPage.NavigationService.Navigate(sly);
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
            button_10.Visibility = Visibility.Collapsed;
            button_Return.Visibility = Visibility.Collapsed;
            img_Back.Visibility = Visibility.Collapsed; 
          
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
            SlyMatriarch seviper = new SlyMatriarch();
            LoadPage.NavigationService.Navigate(seviper);
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            TheDragon mahdragon = new TheDragon();
            ChangePage();
            LoadPage.NavigationService.Navigate(mahdragon);
        }

        private void Button_10_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
            Wyverns wyvern = new Wyverns();
            LoadPage.NavigationService.Navigate(wyvern);
        }
    }
}
