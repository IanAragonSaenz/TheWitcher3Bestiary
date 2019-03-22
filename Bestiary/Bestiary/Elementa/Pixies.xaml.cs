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
    /// Interaction logic for Bear.xaml
    /// </summary>
    public partial class Pixies : Page
    {
        public Pixies()
        {
            InitializeComponent();
            txt_Description.Text ="Pixies might look like gentle, harmless creatures, yet in their case, the saying about appearances being deveiving " +
                "fits all too perfectly. The pixies from the Land of a Thousand Fables were created to protect that magic place from" +
                "intruders and ensure the ducal daughters.";
            txt_LootText.Text = "Golem's Heart\nInfused Dust\nMonster Essence\nMonster Saliva\nRunestones";
            txt_SusceptibilityText.Text = "Elementa Oil";
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
    }
}
