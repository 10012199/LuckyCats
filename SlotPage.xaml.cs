using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;


namespace Assignment1App
{
    public sealed partial class SlotPage : Page
    {
        int funDollars = 0;                     // Variable to store the dollars

        Random number;                          // Set up the random number generator

        Boolean wheel1Clicked = false;          // Variable to store if the wheel was clicked
        Boolean wheel2Clicked = false;
        Boolean wheel3Clicked = false;

        int wheel1;			                    // Variable to store the dice roll
        int wheel2;
        int wheel3;

        Boolean loadUp = true;                  // Sets the startup of the game 

        Spin mySpin = new Spin();

        public SlotPage()
        {
            this.InitializeComponent();
            number = new Random(DateTime.Now.Millisecond); // Switch on random number generator

            // Sets the startup of the game
            buttonPlay.Visibility = Visibility.Collapsed;

        }

        private void HomePage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void buttonAddCash_Click(object sender, RoutedEventArgs e)
        {
            funDollars = funDollars + 10;                // Add $10k to the total

            ShowDollars();   // Display the dollars

            // Only allow the user to play if they have credit
            if (funDollars > 0) buttonPlay.Visibility = Visibility.Visible;

        }

        private void buttonPlay_Click(object sender, RoutedEventArgs e)
        {
            // Sets the startup of the game
            if (loadUp == true)
            {
                wheel1Clicked = false;
                wheel2Clicked = false;
                wheel3Clicked = false;
                loadUp = false;
            }

            // Generate a random number between 1 and 6
            if (wheel1Clicked == false) wheel1 = number.Next(1, 7);
            // Generate a random number between 1 and 6
            if (wheel2Clicked == false) wheel2 = number.Next(1, 7);
            // Generate a random number between 1 and 6
            if (wheel3Clicked == false) wheel3 = number.Next(1, 7);

            funDollars = funDollars - 1;        // It costs $1k fun dollars to play

            if (wheel1Clicked == true) funDollars = funDollars - 10;      // Charge $10k to hold           
            if (wheel2Clicked == true) funDollars = funDollars - 10;      // Charge $10k to hold            
            if (wheel3Clicked == true) funDollars = funDollars - 10;      // Charge $10k to hold            

            ShowDollars();     // Display the dollars

            mySpin.SpinWheel(wheel1Clicked, wheel1,imageWheel1);
            mySpin.SpinWheel(wheel2Clicked, wheel2, imageWheel2);
            mySpin.SpinWheel(wheel3Clicked, wheel3, imageWheel3);
            
            // Set up the following game rules for the pay-outs
            imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/SlotMachine.jpg",
                                                  UriKind.RelativeOrAbsolute));

            // Six – six – six: Win $60 display win image.
            if ((wheel1 == 6) && (wheel2 == 6) && (wheel3 == 6))
            {
                funDollars = funDollars + 60;
                ShowDollars();
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinSlotGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Five – five – five: Win $50 display win image.
            if ((wheel1 == 5) && (wheel2 == 5) && (wheel3 == 5))
            {
                funDollars = funDollars + 50;
                ShowDollars();
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinSlotGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Four – four – four: Win $40 display win image.
            if ((wheel1 == 4) && (wheel2 == 4) && (wheel3 == 4))
            {
                funDollars = funDollars + 40;
                ShowDollars();
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinSlotGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Three – three – three: Win $30 display win image.
            if ((wheel1 == 3) && (wheel2 == 3) && (wheel3 == 3))
            {
                funDollars = funDollars + 30;
                ShowDollars();
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinSlotGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Two – two – two: Win $20 display win image.
            if ((wheel1 == 2) && (wheel2 == 2) && (wheel3 == 2))
            {
                funDollars = funDollars + 20;
                ShowDollars();
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinSlotGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }


            // Five – five – six: Win $10 display win image.
            if ((wheel1 == 5) && (wheel2 == 5) && (wheel3 == 6))
            {
                funDollars = funDollars + 10;
                ShowDollars();
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinSlotGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Four – four – six: Win $8 display win image.
            if ((wheel1 == 4) && (wheel2 == 4) && (wheel3 == 6))
            {
                funDollars = funDollars + 8;
                ShowDollars();
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinSlotGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Three – three – six: Win $6 display win image.
            if ((wheel1 == 3) && (wheel2 == 3) && (wheel3 == 6))
            {
                funDollars = funDollars + 6;
                ShowDollars();
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinSlotGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Two – two – six: Win $4 display win image.
            if ((wheel1 == 2) && (wheel2 == 2) && (wheel3 == 6))
            {
                funDollars = funDollars + 4;
                ShowDollars();
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinSlotGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Lose $2 for every one rolled on a wheel and display lose image.
            if (wheel1 == 1)
            {
                funDollars = funDollars - 2;
                ShowDollars();
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/LoseSlotGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Lose $2 for every one rolled on a wheel and display lose image.
            if (wheel2 == 1)
            {
                funDollars = funDollars - 2;
                ShowDollars();
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/LoseSlotGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Lose $2 for every one rolled on a wheel and display lose image.
            if (wheel3 == 1)
            {
                funDollars = funDollars - 2;
                ShowDollars();
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/LoseSlotGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }


            wheel1Clicked = false;                 // Reset the hold after play
            imageWheel1.Opacity = 1f;              // Reset the hold brightness after play    

            wheel2Clicked = false;                 // Reset the hold after play
            imageWheel2.Opacity = 1f;              // Reset the hold brightness after play

            wheel3Clicked = false;                 // Reset the hold after play
            imageWheel3.Opacity = 1f;              // Reset the hold brightness after play

            if (funDollars <= 0)
            {
                buttonPlay.Visibility = Visibility.Collapsed;
                funDollars = 0;
            }
            ShowDollars();  // Display the dollars
        }

        private void imageWheel1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (wheel1Clicked == false)
            {
                wheel1Clicked = true;
                imageWheel1.Opacity = 0.5f;
            }
            else
            {
                wheel1Clicked = false;
                imageWheel1.Opacity = 1f;
            }
        }

        private void imageWheel2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (wheel2Clicked == false)
            {
                wheel2Clicked = true;
                imageWheel2.Opacity = 0.5f;
            }
            else
            {
                wheel2Clicked = false;
                imageWheel2.Opacity = 1f;
            }
        }

        private void imageWheel3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (wheel3Clicked == false)
            {
                wheel3Clicked = true;
                imageWheel3.Opacity = 0.5f;
            }
            else
            {
                wheel3Clicked = false;
                imageWheel3.Opacity = 1f;
            }
        }

        //Method to display how much fun dollars available to play     
        private void ShowDollars()
        {
            textBlockDollars.Text = "$ FUN DOLLARS\n" + funDollars + "k Dollars";
        }       
        
    }
}
