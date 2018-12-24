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
    public partial class Archespores : Page
    {
        public Archespores()
        {
            InitializeComponent();
            txt_Description.Text = "They look like gigantic, aesthetically unpleainsg flowers with some of the traits of exceptionally cruel and "+
                "bloodthirsty sundews. They are, however, far more dangerous that even the most colossal sundew. Their peculiar appearance makes them "+
                "practically impossible to discern amidsts other plants. By the time one draws close enough to realize what they are, it is often too late.";
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
