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
    public partial class Succubus : Page
    {
        public Succubus()
        {
            InitializeComponent();
            txt_Description.Text = "Opinicus is a very powerful archgriffin living in the forests east of " +
                "Oxenfurt. Many mercenary companies in the past have tried to take down this beast, " +
                "but to no avail.";
            txt_LootText.Text = "Archgriffin mutagen\nGriffin's egg\nGriffin feathers\nGriffin trophy\n" +
                "Monster brain";
           
            txt_SusceptibilityText.Text = "Grapeshot\nHhybrid oil\nAard";
            

        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            Hybrids_Index ind = new Hybrids_Index();
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
