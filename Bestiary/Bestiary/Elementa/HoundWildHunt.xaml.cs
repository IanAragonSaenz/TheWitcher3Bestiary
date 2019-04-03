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
    public partial class HoundWildHunt: Page
    {
        public HoundWildHunt()
        {
            InitializeComponent();
            txt_Description.Text ="Born, or so some experts believe, of magic ice crystal, the Hounds of the" +
                "Wild Hunt race alongside their spectral masters. Like ravenous, feral dogs they are capable" +
                "only of mindleslly attacking whatever crosses their path.";
            txt_LootText.Text = "Monster Bone\nMonster Brain\nMonster Saliva\nRotting Flesh\nSulfur";
            txt_SusceptibilityText.Text = "Dimeritium Bomb\nElementa Oil\nIgni\nAxii";
            txt_Ocurrence.Text = "Always with Wild Hunt";
        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            Elementa_Index elementa = new Elementa_Index();
            Clear();
            LoadPage.NavigationService.Navigate(elementa);
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
