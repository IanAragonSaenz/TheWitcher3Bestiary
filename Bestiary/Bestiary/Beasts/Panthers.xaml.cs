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

namespace Bestiary.Beasts
{
    /// <summary>
    /// Interaction logic for Bear.xaml
    /// </summary>
    public partial class Panthers : Page
    {
        public Panthers()
        {
            InitializeComponent();
            txt_Title.Text = "Panthers";
            txt_Description.Text = ("Dangerous predators found in forests and other woodlands.  They are quick, agile and, like all cats, "+
                "diabolically cunning. In many less-than-thoroughlt-urbanized areas, folk still bealive panthers are the stranded souls of those who "+
                "die in their sleep. Supersition thus holds anyone perishing in this way should be dragged to the nearest woods and left there without a burial"+
                ". The panther-spirit of deceased may then devour its own body, thereby passing on to the nether realms.");
            txt_LootText.Text = "Fur Scrap\nCured Leather\nRaw Meat";
            

        }

        private void Button_Variation1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            Beast_Index ind = new Beast_Index();
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
