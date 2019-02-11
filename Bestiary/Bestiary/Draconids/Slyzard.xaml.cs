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
    public partial class Slyzard : Page
    {
        public Slyzard()
        {
            InitializeComponent();
            txt_Description.Text ="Slyzard are often mistaken for wyvern and forktails.Yet make no mistake: slizards are nasty, terribly dangerous beasts," +
                ", and confusing them for wyverns will end very badly for the confuser.\nWhile a wyvern can tear apart and devour an untrained man in seconds," +
                "only a slyzard can first bake him to a crisp with a waft of fiery breath";
            txt_LootText.Text = "Slyzard Scale Plate";
            txt_SusceptibilityText.Text = "Grapeshot\nDraconid oil\nAard\nQuen";
            

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
