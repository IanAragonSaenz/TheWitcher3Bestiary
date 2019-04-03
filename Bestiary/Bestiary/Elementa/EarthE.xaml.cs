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
    public partial class EarthE: Page
    {
        public EarthE()
        {
            InitializeComponent();
            txt_Description.Text ="Golems are mindless matter brought to life by a spell." +
                "They obet  their creator's orders without question. Their boundless strength, ability" +
                " to withstand pain, endless patience and the fact that neet not one jot of food or drink makes them the best" +
                "servants or guards anyone could ask for. Once provoked, they will not tire of battle until they have either crushed their " +
                "opponent or themseleves crumbled to dust.";
            txt_LootText.Text = "Golem's Heart\nInfused Dust\nMonster Essence\nMonster Saliva\nRunestones";
            txt_SusceptibilityText.Text = "Dimeritium Bomb\nElementa Oil";
        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            Elementa_Index elementa = new Elementa_Index();
            Clear();
            LoadPage.NavigationService.Navigate(elementa);
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
