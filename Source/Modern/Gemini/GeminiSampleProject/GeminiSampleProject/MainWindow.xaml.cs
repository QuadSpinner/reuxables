using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GeminiSampleProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            // Insert code required on object creation below this point.
        }

        private void txtDate_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtDate.Text == "Date")
            {
                txtDate.Text = "";
            }
        }

        private void txtDate_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtDate.Text.Length < 1)
            {
                txtDate.Text = "Date";
            }
        }

        private void txtYear_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtYear.Text == "Year")
            {
                txtYear.Text = "";
            }
        }

        private void txtYear_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtYear.Text.Length < 1)
            {
                txtYear.Text = "Year";
            }
        }

        private void tcMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tcMain != null)
            {
                switch (tcMain.SelectedIndex)
                {
                    case 0:
                        tcMain.Background = (Brush)FindResource("BlueSpreadBrush");
                        tcMain.BorderBrush = (Brush)FindResource("BlueBorderBrush");
                        break;
                    case 1:
                        tcMain.Background = (Brush)FindResource("GreenSpreadBrush");
                        tcMain.BorderBrush = (Brush)FindResource("GreenBorderBrush");
                        break;
                    case 2:
                        tcMain.Background = (Brush)FindResource("OrangeSpreadBrush");
                        tcMain.BorderBrush = (Brush)FindResource("OrangeBorderBrush");
                        break;
                    case 3:
                        tcMain.Background = (Brush)FindResource("MagentaSpreadBrush");
                        tcMain.BorderBrush = (Brush)FindResource("MagentaBorderBrush");
                        break;
                    case 4:
                        tcMain.Background = (Brush)FindResource("PurpleRedSpreadBrush");
                        tcMain.BorderBrush = (Brush)FindResource("PurpleRedBorderBrush");
                        break;
                    case 5:
                        tcMain.Background = (Brush)FindResource("BlueVioletSpreadBrush");
                        tcMain.BorderBrush = (Brush)FindResource("BlueVioletBorderBrush");
                        break;
                    case 6:
                        tcMain.Background = (Brush)FindResource("RedBrownSpreadBrush");
                        tcMain.BorderBrush = (Brush)FindResource("RedBrownBorderBrush");
                        break;


                }

            }
        }
    }
}