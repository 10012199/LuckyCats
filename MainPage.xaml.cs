
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Assignment1App
{   
    public sealed partial class MainPage : Page
    {        
        public MainPage()
        {
            this.InitializeComponent();            
            OnlineGames.Visibility = Visibility.Collapsed;
        }

        private void PredictionPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PredictionPage));
        }

        private void DrinksPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DrinksPage));
        }

        private void SlotPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SlotPage));
        }

        private void DicePage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DicePage));
        }

        private void LottoPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LottoPage));
        }

        private void AgeCheckBox_Checked(object sender, RoutedEventArgs e)
        {          
            OnlineGames.Visibility = Visibility.Visible;
        }

        private void AgeCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            OnlineGames.Visibility = Visibility.Collapsed;
        }
    }
}
