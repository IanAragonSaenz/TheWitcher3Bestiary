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
    public partial class Melusine : Page
    {
        public Melusine()
        {
            InitializeComponent();
            txt_Description.Text ="Ekhidnae are a longer, stronger, breed of sirens."
                +"They make bodies of water a dangerous place.";
            txt_LootText.Text = "Ekhidna Mutagen\nLock of lamia hair\nMonster brain\nMonster blood\nMonster bone\n"
                + "Monster claw\nmonster ear\nMonster eye\nMonster heart\nMonster liver\nMonster saliva\nMonster tongue\nMonster tooth\n"
                + "Sea shell\nWater essence";
           
            txt_SusceptibilityText.Text = "Grapeshot\nHhybrid oil\nIgni\nAard";
            

        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            Hybrids_Index ind = new Hybrids_Index();
            Clear();
            LoadPage.NavigationService.Navigate(ind);
        }

        private void Clear()
        {
            txt_Description.Visibility = Visibility.Collapsed;
            txt_Loot.Visibility = Visibility.Collapsed;
            txt_LootText.Visibility = Visibility.Collapsed;
            
            txt_Susceptibility.Visibility = Visibility.Collapsed;
            txt_SusceptibilityText.Visibility = Visibility.Collapsed;
            txt_Title.Visibility = Visibility.Collapsed;
            button_return.Visibility = Visibility.Collapsed;
            img_Mob.Visibility = Visibility.Collapsed; 
            img_back.Visibility = Visibility.Collapsed;

        }
    }
}
