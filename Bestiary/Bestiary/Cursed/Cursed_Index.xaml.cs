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
   
    public partial class Cursed_Index : Page
    {
        public Cursed_Index()
        {
            InitializeComponent();
            
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
            Cursed.Archespores arch = new Cursed.Archespores();
            LoadPage.NavigationService.Navigate(arch);
            

        }

        private void Button_Return_Click(object sender, RoutedEventArgs e)
        {
            Index ind = new Index();
            ChangePage();
            LoadPage.NavigationService.Navigate(ind);

        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            Cursed.Berserker berserker = new Cursed.Berserker();
            ChangePage();
            LoadPage.NavigationService.Navigate(berserker);
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            Cursed.Toad toad = new Cursed.Toad();
            ChangePage();
            LoadPage.NavigationService.Navigate(toad);
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            Cursed.Lubberkin lubber = new Cursed.Lubberkin();
            ChangePage();
            LoadPage.NavigationService.Navigate(lubber);
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            Cursed.Ulfhedinn ulf = new Cursed.Ulfhedinn();
            ChangePage();
            LoadPage.NavigationService.Navigate(ulf);
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            Cursed.Werewolf wolf = new Cursed.Werewolf();
            ChangePage();
            LoadPage.NavigationService.Navigate(wolf);
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            Cursed.Botchling botch = new Cursed.Botchling();
            ChangePage();
            LoadPage.NavigationService.Navigate(botch);
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
            button_Return.Visibility = Visibility.Collapsed;
            img_Back.Visibility = Visibility.Collapsed; 
          
        }
    }
}
