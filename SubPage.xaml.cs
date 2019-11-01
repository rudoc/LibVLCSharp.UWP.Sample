using Windows.UI.Xaml.Controls;

namespace LibVLCSharp.UWP.Sample
{
    /// <summary>
    /// The main page of the application
    /// </summary>
    public sealed partial class SubPage : Page
    {
        /// <summary>
        /// Initializes a new instance of <see cref="SubPage"/> class
        public SubPage()
        {
            InitializeComponent();
        }

        private void HyperlinkButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
