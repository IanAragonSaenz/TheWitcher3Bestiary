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
    public partial class Djinn : Page
    {
        public Djinn()
        {
            InitializeComponent();
            txt_Description.Text ="They are elemental genie of Air. They are powerful creatures that are capable "
                +"of great feats. Once captures, they are then bound to the captor and have to fulfull three wishes. " +
                "Following their completion, they are free once more.";
           
            txt_SusceptibilityText.Text = "Dimerintium Bomb\nElementa Oil";
            

        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            Elementa_Index ind = new Elementa_Index();
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
