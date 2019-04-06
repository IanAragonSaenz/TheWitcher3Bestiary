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
    public partial class Siren : Page
    {
        public Siren()
        {
            InitializeComponent();
            txt_Description.Text = "Like skilled hunters setting out wooden ducks to lure in drakes, " +
                "sirens and lamias lure men near - using their own bodies as decoys.";
            txt_LootText.Text = "Monster tooth\nSiren vocal cords\nWater essence";
           
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
