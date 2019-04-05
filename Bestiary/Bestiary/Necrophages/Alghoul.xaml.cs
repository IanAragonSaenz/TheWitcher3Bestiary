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
    public partial class Alghoul : Page
    {
        public Alghoul()
        {
            InitializeComponent();
            txt_Description.Text = "Alghouls differ from normal ghouls in size, strength, " +
                "coloring and, most importantly, intelligence. Whereas ghouls and graveirs " +
                "are primitive creatures unfit to plan even the simplest ambush, alghouls and " +
                "their kindred are capable of forethought, and are thus much more " +
                "dangerous.";
            txt_LootText.Text = "Alghoul bone marrow\nAlghoul claw\nAlghoul mutagen";
           
            txt_SusceptibilityText.Text = "Necrophage oil\nAxii";
            

        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            Necrophages_Index ind = new Necrophages_Index();
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
