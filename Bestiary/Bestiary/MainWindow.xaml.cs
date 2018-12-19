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
        int i = 0;
        public MainWindow()
        {
           
            Timer timer = new Timer(TimerCallBack,null,0,1000);
            InitializeComponent();
            Hi.Play();
        
           

                
        }
        private void TimerCallBack(object o)
        {
          
        }

        private void Image_AnimationCompleted(object sender, RoutedEventArgs e)
        {
            img_Logo.Visibility = Visibility.Visible;
           

        }
    }
}
