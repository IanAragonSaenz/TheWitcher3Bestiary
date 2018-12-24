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
    /// Interaction logic for Index.xaml
    /// </summary>
    public partial class Index : Page
    {
        public Index()
        {
            InitializeComponent();
            
        }
        private void Button_Beast_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
            Beast_Index beastInd = new Beast_Index();
            LoadPage.NavigationService.Navigate(beastInd);
        }

        private void Button_CursedOnes_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
            Cursed_Index cursedInd = new Cursed_Index();
            LoadPage.NavigationService.Navigate(cursedInd);

        }

        private void Button_Draconoids_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
        }

        private void Button_Elementa_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
        }

        private void Button_Insectoids_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
        }

        private void Button_Necrophages_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
        }

        private void Button_Hybrids_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
        }

        private void Button_Ogroids_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
        }

        private void Button_Relicts_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
        }

        private void Button_Specters_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
        }

        private void Button_Vampires_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
        }

        private void ChangePage()
        {
            pageTurn.Play();
            img_background.Visibility = Visibility.Collapsed;
            img_symbol.Visibility = Visibility.Collapsed;
            button_Beast.Visibility = Visibility.Collapsed;
            button_CursedOnes.Visibility = Visibility.Collapsed;
            button_Draconoids.Visibility = Visibility.Collapsed;
            button_Elementa.Visibility = Visibility.Collapsed;
            button_Hybrids.Visibility = Visibility.Collapsed;
            button_Insectoids.Visibility = Visibility.Collapsed;
            button_Necrophages.Visibility = Visibility.Collapsed;
            button_Ogroids.Visibility = Visibility.Collapsed;
            button_Relicts.Visibility = Visibility.Collapsed;
            button_Specters.Visibility = Visibility.Collapsed;
            button_Vampires.Visibility = Visibility.Collapsed;
            border_Text.Visibility = Visibility.Collapsed;
        }
    }
}
