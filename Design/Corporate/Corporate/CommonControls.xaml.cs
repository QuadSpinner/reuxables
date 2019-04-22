using System.Windows;

namespace Corporate
{
    /// <summary>
    /// Interaction logic for CommonControls.xaml
    /// </summary>
    public partial class CommonControls
    {
        public CommonControls()
        {
            InitializeComponent();
            Loaded += CommonControls_Loaded;
        }

        private void CommonControls_Loaded(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(ListViewItem2, "InvalidFocused", true);
            VisualStateManager.GoToState(ListView2, "InvalidFocused", true);
            VisualStateManager.GoToState(PasswordBox2, "InvalidFocused", true);
            VisualStateManager.GoToState(RichTextBox2, "InvalidFocused", true);
            VisualStateManager.GoToState(Slider2, "InvalidFocused", true);
            VisualStateManager.GoToState(MenuItem1, "InvalidFocused", true);
            VisualStateManager.GoToState(TreeViewItem2, "InvalidFocused", true);
            VisualStateManager.GoToState(TabItem2, "InvalidFocused", true);
            VisualStateManager.GoToState(TabItem1, "InvalidFocused", true);
        }
    }
}
