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

namespace Bestiary.Cursed
{

    public partial class Berserker : Page
    {
        public Berserker()
        {
            InitializeComponent();
            txt_Description.Text = "Skellige legends speak of men known as berserkers who transform into bears when overwhelmed by battle rage. In doing so, "+
                "they lose all self-awareness and are driven by a bloodlust which they must satiate in order to return to human form. Few bealive these blood-curdling tales,"+
                ",however, not even in Skellige, where the inhabitants usually treat even the least probable legend with most utmost gravity."+
                " This indicates either that berserkers are in fact mere figments of mead-sodden imaginations, or else, that they have learned to hide their abilities from the rest of the islanders.";
            txt_LootText.Text = "Bear Fat\nBerserker Hide\nRaw Meat";
            txt_SusceptibilityText.Text = "Devil's Puffball\nCursed Oil\nQuen\nIgni";
        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            Cursed_Index ind = new Cursed_Index();
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
            button_Variation1.Visibility = Visibility.Collapsed;
            txt_Variation.Visibility = Visibility.Collapsed;

        }

        private void Button_Variation1_Click(object sender, RoutedEventArgs e)
        {
            
            Beasts.Bear bear = new Beasts.Bear();
            LoadPage.NavigationService.Navigate(bear);
            Clear();
        }
    }
}
