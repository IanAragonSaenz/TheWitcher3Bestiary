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

namespace Bestiary.Cursed
{
    /// <summary>
    /// Interaction logic for Bear.xaml
    /// </summary>
    public partial class Botchling : Page
    {
        public Botchling()
        {
            InitializeComponent();
            txt_Description.Text = "Small creatures resembling a highly deformed fetus created from the improper burial of unwanted, "+
                " stillborn infants that preys on pregnant women. While hiding beneath beds, botchlings sap the expectant mother of strength "+
                " and once she is completely defenseless it will latch on and directly feed off blood, killing both her and the unborn child." ;
            txt_LootText.Text = "Archespore Juice\nArchespore Tendril\nMonster Spore";
            txt_SusceptibilityText.Text = "Cursed Oil\nAard\nIgni";
            

        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            Cursed_Index ind = new Cursed_Index();
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
