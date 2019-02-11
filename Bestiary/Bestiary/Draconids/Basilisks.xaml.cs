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
    public partial class Basilisks : Page
    {
        public Basilisks()
        {
            InitializeComponent();
            txt_Description.Text ="Contrary to popular belief, basilisks cannot turn anything to stone wit htheir gaze.\n" +
                "However, given that their acid, venom, claws and teeeth provide them many other ways to kill.";
            txt_LootText.Text = "Basilisk venom\nBasilisk hide\nBasilisk mutagen";
            txt_SusceptibilityText.Text = "Golden Oriole\nGrapeshot\nDraconid oil\nAard";
            

        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            Draco_Index ind = new Draco_Index();
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
