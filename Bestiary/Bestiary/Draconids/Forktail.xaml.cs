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
    public partial class Forktail : Page
    {
        public Forktail()
        {
            InitializeComponent();
            txt_Description.Text ="Their massive size does not stop them from quickly flying up and then counter-attacking from the air." +
                "They are able to use their weight and height to their advantage as they attack from the air knocking their prey over with their wings.";
            txt_LootText.Text = "Dragon Scales\nForktail Mutagen\nForktail Hide\nForktail Trophy\nMonster Bone\nMonster Heart\nMonster Tongue";
            txt_SusceptibilityText.Text = "Golden Oriole\nGrapeshot\nDraconid Oil\nAard";
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
            txt_variation.Visibility = Visibility.Collapsed;
            btn_Variation.Visibility = Visibility.Collapsed;

        }

        private void Btn_Variation_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            TheDragon mahdragon = new TheDragon();
            LoadPage.NavigationService.Navigate(mahdragon);
        }
    }
}
