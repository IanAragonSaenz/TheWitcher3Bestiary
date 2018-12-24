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

    public partial class Lubberkin : Page
    {
        public Lubberkin()
        {

            InitializeComponent();
            txt_Description.Text = "They are friendly household guardian spirits created from a Botchlin trhought Aymm Rhoin, an elven naming ritual, during which " +
                "it is given a proper name and a burial under the hearth of the family estate. A lubberkin looks very similar to a botchling, the main difference being its ghost-like " +
                "glowing, white aura and relatively passive behavior.";
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

