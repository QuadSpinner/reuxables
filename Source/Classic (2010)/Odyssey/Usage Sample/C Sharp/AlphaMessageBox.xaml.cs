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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Odyssey
{
    /// <summary>
    /// Interaction logic for AlphaMessageBox.xaml
    /// </summary>
    public partial class AlphaMessageBox : Window
    {
        public AlphaMessageBox()
        {
            InitializeComponent();
        }

        public MessageBoxButton alphaMessageBoxStyle { get; set; }
        public MessageBoxResult MessageResult { get; set; }

        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {
            this.MessageResult = MessageBoxResult.Cancel;
            this.Hide();
        }

        private void buttonYes_Click(object sender, RoutedEventArgs e)
        {
            this.MessageResult = MessageBoxResult.Cancel;
            this.Hide();
        }

        private void buttonNo_Click(object sender, RoutedEventArgs e)
        {
            this.MessageResult = MessageBoxResult.Cancel;
            this.Hide();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.MessageResult = MessageBoxResult.Cancel;
            this.Hide();
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            this.MessageResult = MessageBoxResult.Cancel;
            this.Hide();
        }

        private void thumbDragWindow_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            this.Left = this.Left + e.HorizontalChange;
            this.Top = this.Top + e.VerticalChange;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            switch (alphaMessageBoxStyle)
            {
                case MessageBoxButton.OK:
                    buttonCancel.Visibility = Visibility.Collapsed;
                    buttonYes.Visibility = Visibility.Collapsed;
                    buttonNo.Visibility = Visibility.Collapsed;
                    break;
                case MessageBoxButton.OKCancel:
                    buttonYes.Visibility = Visibility.Collapsed;
                    buttonNo.Visibility = Visibility.Collapsed;
                    break;
                case MessageBoxButton.YesNo:
                    buttonOK.Visibility = Visibility.Collapsed;
                    buttonCancel.Visibility = Visibility.Collapsed;
                    break;
                case MessageBoxButton.YesNoCancel:
                    buttonOK.Visibility = Visibility.Collapsed;
                    buttonCancel.Style = (Style)(FindResource("ButtonBlue"));
                    break;
                default:
                    break;
            }
        }


    }
}
