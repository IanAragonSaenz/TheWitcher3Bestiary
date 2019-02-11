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
    public partial class Werewolf : Page
    {
        public Werewolf()
        {
            InitializeComponent();
            txt_Description.Text = "Neither animal, nor man, the Werewolf takes the worst from both species: the bloodlust and primal nature of a wolf,"+
                " and the ruthlessness and cruelty of a human. One becomes a Werewolf as a result of a curse thrown by a witch. The change itself is uncontrollable and unwilling."+
                " A man who transforms back to his human form can't usually remember the atrocious acts commited as a werewolf.";
            txt_LootText.Text = "Werewolf Hide\nWerewolf Mutagen\nWerewolf Saliva";
            txt_SusceptibilityText.Text = "Moon Dust\nDevil's Puffball\nCursed Oil\nIgni";
            

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
            button_Variation1.Visibility = Visibility.Collapsed;
            txt_Variation.Visibility = Visibility.Collapsed;

        }

        private void Button_Variation1_Click(object sender, RoutedEventArgs e)
        {
            Ulfhedinn ulf = new Ulfhedinn();
            LoadPage.NavigationService.Navigate(ulf);
            Clear();
        }
    }
}
