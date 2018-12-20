using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i=0;
        public MainWindow()
        {
           
            
            InitializeComponent();
            Hi.Play();
            

          
            


        }

        private void Image_AnimationCompleted(object sender, RoutedEventArgs e)
        {
            img_Logo.Visibility = Visibility.Visible;
            
            button_Start.Visibility = Visibility.Visible;

            WpfAnimatedGif.ImageBehavior.SetRepeatBehavior(img_Logo, System.Windows.Media.Animation.RepeatBehavior.Forever);
            
        }


        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            pageTurn.Play();
            Index ind = new Index();
            LoadFrame.NavigationService.Navigate(ind);
            gif_Background.Visibility = Visibility.Collapsed;
            button_Start.Visibility = Visibility.Collapsed;
            img_Logo.Visibility = Visibility.Collapsed;
            
        }
    }
}
