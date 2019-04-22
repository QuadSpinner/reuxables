using System.Windows;

namespace Corporate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(CheckBox2, "InvalidFocused", true);
            VisualStateManager.GoToState(RadioButton2, "InvalidFocused", true);
            VisualStateManager.GoToState(iconRadio2, "InvalidFocused", true);
            VisualStateManager.GoToState(TextBox2, "InvalidFocused", true);
            VisualStateManager.GoToState(ComboBox3, "InvalidFocused", true);
            VisualStateManager.GoToState(ListBox2, "InvalidFocused", true);
            VisualStateManager.GoToState(ListBoxItem4, "InvalidFocused", true);
            VisualStateManager.GoToState(GroupBox1, "InvalidFocused", true);
        }
    }
}

