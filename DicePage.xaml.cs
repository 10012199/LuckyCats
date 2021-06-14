using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Assignment1App
{
    public sealed partial class DicePage : Page
    {
        Random number;                          // Set up the random number generator

        Boolean dice1Clicked = false;          // Variable to store if the dice was clicked
        Boolean dice2Clicked = false;
        Boolean dice3Clicked = false;
        Boolean dice4Clicked = false;
        Boolean dice5Clicked = false;
        Boolean dice6Clicked = false;
        Boolean dice7Clicked = false;
        Boolean dice8Clicked = false;
        Boolean dice9Clicked = false;
        Boolean dice10Clicked = false;

        int dice1;			                    // Variable to store the dice roll
        int dice2;
        int dice3;
        int dice4;
        int dice5;
        int dice6;
        int dice7;
        int dice8;
        int dice9;
        int dice10;
        
        Spin mySpin = new Spin();               

        public DicePage()
        {
            this.InitializeComponent();
            number = new Random(DateTime.Now.Millisecond); // Switch on random number generator
        }

        private void HomePage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void player1Roll_Click(object sender, RoutedEventArgs e)
        {
            // Generate a random number between 1 and 6
            if (dice1Clicked == false) dice1 = number.Next(1, 7);            
            if (dice2Clicked == false) dice2 = number.Next(1, 7);            
            if (dice3Clicked == false) dice3 = number.Next(1, 7);
            if (dice4Clicked == false) dice4 = number.Next(1, 7);
            if (dice5Clicked == false) dice5 = number.Next(1, 7);

            mySpin.RollDice(dice1Clicked, dice1, imageDice1);
            mySpin.RollDice(dice2Clicked, dice2, imageDice2);
            mySpin.RollDice(dice3Clicked, dice3, imageDice3);
            mySpin.RollDice(dice4Clicked, dice4, imageDice4);
            mySpin.RollDice(dice5Clicked, dice5, imageDice5);            
        }

        private void imageDice1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (dice1Clicked == false)
            {
                dice1Clicked = true;
                imageDice1.Opacity = 0.5f;
            }
            else
            {
                dice1Clicked = false;
                imageDice1.Opacity = 1f;
            }
        }

        private void imageDice2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (dice2Clicked == false)
            {
                dice2Clicked = true;
                imageDice2.Opacity = 0.5f;
            }
            else
            {
                dice2Clicked = false;
                imageDice2.Opacity = 1f;
            }
        }

        private void imageDice3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (dice3Clicked == false)
            {
                dice3Clicked = true;
                imageDice3.Opacity = 0.5f;
            }
            else
            {
                dice3Clicked = false;
                imageDice3.Opacity = 1f;
            }
        }

        private void imageDice4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (dice4Clicked == false)
            {
                dice4Clicked = true;
                imageDice4.Opacity = 0.5f;
            }
            else
            {
                dice4Clicked = false;
                imageDice4.Opacity = 1f;
            }
        }

        private void imageDice5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (dice5Clicked == false)
            {
                dice5Clicked = true;
                imageDice5.Opacity = 0.5f;
            }
            else
            {
                dice5Clicked = false;
                imageDice5.Opacity = 1f;
            }
        }

        private void player2Roll_Click(object sender, RoutedEventArgs e)
        {
            // Generate a random number between 1 and 6
            if (dice6Clicked == false) dice6 = number.Next(1, 7);
            if (dice7Clicked == false) dice7 = number.Next(1, 7);
            if (dice8Clicked == false) dice8 = number.Next(1, 7);
            if (dice9Clicked == false) dice9 = number.Next(1, 7);
            if (dice10Clicked == false) dice10 = number.Next(1, 7);

            mySpin.RollDice(dice6Clicked, dice6, imageDice6);
            mySpin.RollDice(dice7Clicked, dice7, imageDice7);
            mySpin.RollDice(dice8Clicked, dice8, imageDice8);
            mySpin.RollDice(dice9Clicked, dice9, imageDice9);
            mySpin.RollDice(dice10Clicked, dice10, imageDice10);           
        }

        private void imageDice6_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            if (dice6Clicked == false)
            {
                dice6Clicked = true;
                imageDice6.Opacity = 0.5f;
            }
            else
            {
                dice6Clicked = false;
                imageDice6.Opacity = 1f;
            }
        }

        private void imageDice7_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            if (dice7Clicked == false)
            {
                dice7Clicked = true;
                imageDice7.Opacity = 0.5f;
            }
            else
            {
                dice7Clicked = false;
                imageDice7.Opacity = 1f;
            }
        }

        private void imageDice8_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            if (dice8Clicked == false)
            {
                dice8Clicked = true;
                imageDice8.Opacity = 0.5f;
            }
            else
            {
                dice8Clicked = false;
                imageDice8.Opacity = 1f;
            }
        }

        private void imageDice9_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            if (dice9Clicked == false)
            {
                dice9Clicked = true;
                imageDice9.Opacity = 0.5f;
            }
            else
            {
                dice9Clicked = false;
                imageDice9.Opacity = 1f;
            }
        }               

        private void imageDice10_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            if (dice10Clicked == false)
            {
                dice10Clicked = true;
                imageDice10.Opacity = 0.5f;
            }
            else
            {
                dice10Clicked = false;
                imageDice10.Opacity = 1f;
            }
        }        
    }
}
