using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.Media.SpeechSynthesis;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Assignment1App
{
    public sealed partial class PredictionPage : Page
    {
        SpeechSynthesizer reader;
        string name;        
        public PredictionPage()
        {
            this.InitializeComponent();
            try
            {
                reader = new SpeechSynthesizer(); //Configure the audio output
            }

            catch (System.IO.FileNotFoundException)
            {
                var messageDialog = new Windows.UI.Popups.MessageDialog("Media player components unavailable.\nPlease install an English Voice Package." +
                    "\n\nSettings > Time & Language > Speech > Manage Voices > Add Voices");

                _ = messageDialog.ShowAsync();
            } 
            catch (Exception)
            {
                media.AutoPlay = false;
                var messageDialog = new Windows.UI.Popups.MessageDialog("Unable to synthesize text");
                _ = messageDialog.ShowAsync();
            }
        }

        public string[] catsNickname = new string[]
        {
            "Amazing",
            "Marvellous",
            "Awesome",
            "Incredible",
            "Phenomenal",
            "Stupendous",
            "Spectacular",
            "Sensational",
            "Astonishing",
            "Splendid",
            "Magnificent",
            "Fantastic",
            "Fabulous"
        };

        public string[] timeArray = new string[] 
        {   
            "thirty minutes", 
            "an hour", 
            "eight hours", 
            "twelve hours", 
            "a day", 
            "a week", 
            "a month", 
            "a year", 
            "a decade" 
        };

        public string[] aspectArray = new string[]
        {
            "finances",
            "love life",
            "career prospects",
            "travel plans",
            "spiritual beliefs",
            "social relationships",
            "studies plans",
            "family relationships"
        };

        public string[] effectArray = new string[]
        {
            "fall apart",
            "fell short of your expectation",
            "become awkward in an unexpected way",
            "become unmanageable",
            "become kind of tragic",
            "come to a negative outcome",
            "become terrible"
        };

        public string[] catCoat = new string[]
        {
            "black",
            "white",
            "calico",
            "gray",
            "spotted tabby",
            "hairless",
            "tortoiseshell",
            "brown",
            "ginger",
            "tuxedo",
            "bicolor",
            "tricolor"
        };

        public string[] eyesColor = new string[]
        {
            "blue",
            "green",
            "golden yellow",
            "lemon yellow",
            "orange",
            "hazel",
            "amber",
            "copper",

        };

        public string[] catTail = new string[]
        {
            "full",
            "longy",
            "stumpy",
            "curved",
            "bob",
            "corkscrew",
            "kinked",
            "no"
        };

        public string[] consequenceArray = new string[]
        {
            "buy a magazine",
            "buy a can of tuna",
            "stop and talk to", 
            "dance with",
            "tell a secret",
            "buy a cup of milk",
            "go to the cinema with",
            "watch a movie with",
            "go shopping with",
            "give a ride",
            "live with",
            "sing a song",
            "read a story",
            "play hide and seek with"            
        };

        public string[] catBreed = new string[]
        {
            "Short Hair Domestic",
            "Bengal",
            "Burmese",
            "Maine Coon",
            "Persian",
            "Ragdoll",
            "Siamese",
            "Birman",
        };

        private void HomePage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void ButtonPrediction_Click(object sender, RoutedEventArgs e)
        {
            Random number = new Random();
            name = TextBoxName.Text;

            TextBlockPrediction.Text = $"Hello {name}. The {catsNickname[number.Next(0, catsNickname.Length)]} Twin Cats predict that over a period of {timeArray[number.Next(0, timeArray.Length)]} your {aspectArray[number.Next(0, aspectArray.Length)]} will {effectArray[number.Next(0, effectArray.Length)]}. " +
                $"This will come to pass after you meet a {catCoat[number.Next(0, catCoat.Length)]} cat with {eyesColor[number.Next(0, eyesColor.Length)]} eyes and {catTail[number.Next(0, catTail.Length)]} tail who for some " +
                $"reason you find yourself obliged to {consequenceArray[number.Next(0, consequenceArray.Length)]}. To have more luck in your life, you must urgently adopt {number.Next(3,6)} {catBreed[number.Next(0, catBreed.Length)]} cats!";

            Talk(TextBlockPrediction.Text);            
        }

        private async void Talk(string message)
        {
            try
            {
                var stream = await reader.SynthesizeTextToStreamAsync(message); // Get the text          
                                                                            // Setup the stream for the player
                media.SetSource(stream, stream.ContentType);
                // Play the message
                media.Play();
            }

            catch (System.IO.FileNotFoundException)
            {
                var messageDialog = new Windows.UI.Popups.MessageDialog("Media player components unavailable.\nPlease install an English Voice Package." +
                    "\n\nSettings > Time & Language > Speech > Manage Voices > Add Voices");
                
                await messageDialog.ShowAsync();
            }
            catch (Exception)
            {
                media.AutoPlay = false;
                
                var messageDialog = new Windows.UI.Popups.MessageDialog("Unable to synthesize text");
                
                await messageDialog.ShowAsync();
            }                       
        }

    }
}
