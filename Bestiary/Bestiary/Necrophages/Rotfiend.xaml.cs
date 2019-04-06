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
    public partial class Rotfiend : Page
    {
        public Rotfiend()
        {
            InitializeComponent();
            txt_Description.Text = "Rotfiends resemble decomposing human bodies that have been " +
                "stripped of their skin. Their presence is given away by the overwhelming " +
                "stench of the rot which gives them their name.";
            txt_LootText.Text = "Rotfiend blood\nNecrophage hide\nMonster brain\nMonster bone\n" +
                "Monster heart";
           
            txt_SusceptibilityText.Text = "Necrophage oil";
            

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
