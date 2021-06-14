using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Assignment1App
{
    class Utils
    {
        public static void spinWheel(int wheel, Image imageWheel)
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

        public static void spinWheel(Boolean wheelClicked, int wheel, Image imageWheel)
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
    }
}
