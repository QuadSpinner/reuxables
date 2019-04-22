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

namespace Designer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(RadioButton2, "InvalidFocused", true);
            VisualStateManager.GoToState(CheckBox2, "InvalidFocused", true);
            VisualStateManager.GoToState(TextBox2, "InvalidFocused", true);
            VisualStateManager.GoToState(ListBoxItem2, "InvalidFocused", true);
            VisualStateManager.GoToState(ComboBox2, "InvalidFocused", true);
            VisualStateManager.GoToState(ComboBoxItem2, "InvalidFocused", true);
            VisualStateManager.GoToState(toggleradio2, "InvalidFocused", true);
            VisualStateManager.GoToState(togglecheck2, "InvalidFocused", true);
            VisualStateManager.GoToState(group2, "InvalidFocused", true);
            VisualStateManager.GoToState(exp3, "InvalidFocused", true);
            VisualStateManager.GoToState(exp6, "InvalidFocused", true);
            VisualStateManager.GoToState(rtb2, "InvalidFocused", true);

        }
    }
}
