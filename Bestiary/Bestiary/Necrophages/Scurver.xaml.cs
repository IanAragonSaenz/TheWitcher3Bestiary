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
    public partial class Scurver : Page
    {
        public Scurver()
        {
            InitializeComponent();
            txt_Description.Text = "Scurvers are rotfiends' larger cousins. The bodies of these hideous" +
                ", vaguely humanoid creatures are covered with rotten scraps of flesh, under which " +
                "lurk even more rotten muscles stretched around a strong, flexible skeleton. " +
                "Scurvers, which feed on old, rotting corpses, prefer to make their hunting grounds " +
                "in abandoned torture sites, forgotten graveyards and old battlefields.";

           
           
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
            
            txt_Susceptibility.Visibility = Visibility.Collapsed;
            txt_SusceptibilityText.Visibility = Visibility.Collapsed;
            txt_Title.Visibility = Visibility.Collapsed;
            button_return.Visibility = Visibility.Collapsed;
            img_Mob.Visibility = Visibility.Collapsed; 
            img_back.Visibility = Visibility.Collapsed;

        }
    }
}
