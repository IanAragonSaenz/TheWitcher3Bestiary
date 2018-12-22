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
    public partial class BigWolf : Page
    {
        public BigWolf()
        {
            InitializeComponent();
            txt_Title.Text = "Panthers";
            txt_Description.Text = "Created by Artorius Vigo based on a figure from folk tales. Once he served as a playmate to the duke's" +
                " daughets, acting out scenes with a certain red-hooded girl and her grandmother, but as the fable land slowly degenerated," +
                " so did he.";
            txt_LootText.Text = "Magic Dust\nRed Mutagen\nFake Tooth\nCorkscew\nBottle Caps";
            txt_SusceptibilityText.Text = "Beast Oil\nDevil's Puffball";
            

        }

        private void Button_Variation1_Click(object sender, RoutedEventArgs e)
        {

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
            button_return.Visibility = Visibility.Collapsed;
            img_Mob.Visibility = Visibility.Collapsed; 
            img_back.Visibility = Visibility.Collapsed;

        }
    }
}
