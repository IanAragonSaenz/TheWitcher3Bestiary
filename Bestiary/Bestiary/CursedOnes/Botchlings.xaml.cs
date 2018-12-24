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
    public partial class Beau : Page
    {
        public Beau()
        {
            InitializeComponent();
            
            txt_Description.Text = "Eyewitnesses to gruesome monster attacks always have a hard time describing the creature in question."+
                "The beasts move quickly and often attack at night, while the witnesses are terrified and primarily concernes with fleeing for their lives."+
                "As a result, witchers quite often have no inkling what creature they face until they find tracks or otherwise establish something for"+
                " themselves. Such was the case with the Beast tormenting Beauclair.";
          
            txt_SusceptibilityText.Text = "Vampire oil\nBlack Blood\nQuen";
            

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
