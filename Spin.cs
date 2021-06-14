
using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Assignment1App
{
    class Spin
    {
        public void SpinWheel(int wheel, Image imageWheel)
        {

            if (wheel == 1) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/lose.png",
                                                             UriKind.RelativeOrAbsolute));
            else if (wheel == 2) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice.png",
                                                                       UriKind.RelativeOrAbsolute));
            else if (wheel == 3) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/Lotto.png",
                                                                       UriKind.RelativeOrAbsolute));
            else if (wheel == 4) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/Clove.png",
                                                                       UriKind.RelativeOrAbsolute));
            else if (wheel == 5) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/luckyCatsLogo.png",
                                                                       UriKind.RelativeOrAbsolute));
            else imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/win.png",
                                                              UriKind.RelativeOrAbsolute));
        }
        public void SpinWheel(Boolean wheelClicked, int wheel, Image imageWheel)
        {
            if (wheelClicked == false)
            {
                if (wheel == 1) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/lose.png",
                                                             UriKind.RelativeOrAbsolute));
                else if (wheel == 2) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice.png",
                                                                           UriKind.RelativeOrAbsolute));
                else if (wheel == 3) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/Lotto.png",
                                                                           UriKind.RelativeOrAbsolute));
                else if (wheel == 4) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/Clove.png",
                                                                           UriKind.RelativeOrAbsolute));
                else if (wheel == 5) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/luckyCatsLogo.png",
                                                                           UriKind.RelativeOrAbsolute));
                else imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/win.png",
                                                                  UriKind.RelativeOrAbsolute));
            }
        }

        public void RollDice(Boolean diceClicked, int dice, Image imageDice)
        {
            if (diceClicked == false)
            {
                if (dice == 1) imageDice.Source = new BitmapImage(new Uri("ms-appx:///Assets/One.png",
                                                             UriKind.RelativeOrAbsolute));
                else if (dice == 2) imageDice.Source = new BitmapImage(new Uri("ms-appx:///Assets/Two.png",
                                                                           UriKind.RelativeOrAbsolute));
                else if (dice == 3) imageDice.Source = new BitmapImage(new Uri("ms-appx:///Assets/Three.png",
                                                                           UriKind.RelativeOrAbsolute));
                else if (dice == 4) imageDice.Source = new BitmapImage(new Uri("ms-appx:///Assets/Four.png",
                                                                           UriKind.RelativeOrAbsolute));
                else if (dice == 5) imageDice.Source = new BitmapImage(new Uri("ms-appx:///Assets/Five.png",
                                                                           UriKind.RelativeOrAbsolute));
                else imageDice.Source = new BitmapImage(new Uri("ms-appx:///Assets/Six.png",
                                                                  UriKind.RelativeOrAbsolute));
            }
        }
    }
}
