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
    public partial class Boar : Page
    {
        public Boar()
        {
            InitializeComponent();
            txt_Description.Text = "They are quite dangerous natural beasts appearing in the Northern Realms"+
                ". They feature prominently in Skellige and Nordling cultures, many of which saw the animals as embodying warrior virtues."+
                "Actual attacks on humans are rare, but can be serious, resulting in multiple piercing injuries to the lower part of the"+
                "body. Regardless, the animal is not considered dangerous enough for a witcher to be called; folks usually manage to hunt down the beast"+
                "or pay crowns to a hunter for removal. The domesticated breed is called a pig.";
            
            txt_OcurrenceText.Text = "Eastern Velen\nToussaint";
            txt_SusceptibilityText.Text = "Northern Wind\nBeast Oil\nIgni\nYrden";
            txt_LootText.Text = "Boar Tusks\nBoar Pelt\nRaw Meat";
            

        }

        private void Button_Variation1_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            Pigs piggo = new Pigs();
            LoadPage.NavigationService.Navigate(piggo);
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
