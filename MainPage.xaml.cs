using Windows.UI.Xaml.Controls;

namespace LibVLCSharp.UWP.Sample
{
    /// <summary>
    /// The main page of the application
    /// </summary>
    public sealed partial class MainPage : Page
    {
        /// <summary>
        /// Initializes a new instance of <see cref="MainPage"/> class
        public MainPage()
        {
            InitializeComponent();
        }

        private void HyperlinkButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SubPage));
        }
    }
}
