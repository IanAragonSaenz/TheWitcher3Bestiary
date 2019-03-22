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
    public partial class Cockatrices : Page
    {
        public Cockatrices()
        {
            InitializeComponent();
            txt_Description.Text ="Foolish superstitions claim cockatrices, like basilisks, can kill with their gaze alone\n" +
                "That is utter nonsense, however, a cockatrice's gaze being no more dangerous than that of an angry goose." +
                "\nOne should instead watch out for it's sharp beak and long tail, which it can whip to murderous effect.";
            txt_LootText.Text = "Cockatrice Egg\nCockatrice Mutagen\nCockatrice Stomach\nCockatrice Trophy\nMonster Carapace";
            txt_SusceptibilityText.Text = "Grapeshot\nDraconid Oil\nAard";
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
            Shrieker shriek = new Shrieker();
            LoadPage.NavigationService.Navigate(shriek);
        }
    }
}
