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
    /// <summary>
    /// Interaction logic for Bear.xaml
    /// </summary>
    public partial class Toad : Page
    {
        public Toad()
        {
            InitializeComponent();
            txt_Description.Text ="Used to be an Ofieri Prince who'd been cursed by Olgierd von Everec out of anger when the parents of his love, iris, "+
                "intended to hand over her hand in marriage to the visiting prince. The cursed being then took to living in the Oxenfurt sewers, where "+
                "its venom seeped into the city's waters, making many sick. Eventually, long after the cursed was placed,Olgierd decided to end the prince's"+
                "suffering.";
         
            txt_SusceptibilityText.Text = "Northern Wind\nGolden Oriole\nCursed Oil\nYrden";
            

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
