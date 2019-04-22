using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Odyssey
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        void OpenInterruptScreen(object sender, System.Windows.RoutedEventArgs e) 
        {
            Interrupt.Visibility = Visibility.Visible;

            BlurEffect b = new BlurEffect();
            b.Radius = 0.0;
            // Change to Guassian for better quality
            // at the expense of performance
            // (NOT RECOMMENDED!)
            b.KernelType = KernelType.Box;
            DoubleAnimation blurIn = new DoubleAnimation(5.0, TimeSpan.FromMilliseconds(50));

            LayoutRoot.Effect = b;
            LayoutRoot.IsEnabled = false;
            LayoutRoot.Effect.BeginAnimation(BlurEffect.RadiusProperty, blurIn);
        }

        void CloseInterruptScreen(object sender, RoutedEventArgs e)
        {
            Interrupt.Visibility = Visibility.Hidden;
            LayoutRoot.Effect = null;
            LayoutRoot.IsEnabled = true;
        }

        void ShowCustomMessageBox(object sender, RoutedEventArgs e)
        {
            AlphaMessageBoxHandler customMessageHandler = new AlphaMessageBoxHandler();
            customMessageHandler.Show("This is a custom Message Box. To launch it, all you have to do is create a new instance of the AlphaMessageBoxHandler class, and call the 'Show' method and use it like the normal MessageBox.Show() function.", "Odyssey Dog UX Kit - Custom Message Box", MessageBoxButton.YesNoCancel);
        }

    }
}
