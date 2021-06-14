using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Assignment1App
{
     public sealed partial class LottoPage : Page
    {
        public LottoPage()
        {
            this.InitializeComponent();
        }

        private void HomePage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }        

        private void ButtonSelect_Click(object sender, RoutedEventArgs e)
        {
            int luckyDips;
            Lotto row = new Lotto();

            try
            {
                // Get the number from the use - default number is 1
                luckyDips = Convert.ToInt32(TextBoxTickets.Text);

                if (luckyDips < 1 || luckyDips > 20) // Limit range of tickets 1 to 20
                {
                    luckyDips = 1;
                    //Ticket header
                    TextBlockTicket.Text = "Number of row must be from 1 to 20!\n\nFor invalid inputs, 1 (one) row is generated:\n\n";
                    TextBlockTicket.Text = TextBlockTicket.Text + "----------------------------------------\n";
                    TextBlockTicket.Text = TextBlockTicket.Text + "Lotto Ticket\n";
                    TextBlockTicket.Text = TextBlockTicket.Text + "----------------------------------------\n";
                }
                else
                {
                    //Ticket header
                    TextBlockTicket.Text = "";
                    TextBlockTicket.Text = TextBlockTicket.Text + "----------------------------------------\n";
                    TextBlockTicket.Text = TextBlockTicket.Text + "Lotto Ticket\n";
                    TextBlockTicket.Text = TextBlockTicket.Text + "----------------------------------------\n";
                }
            }

            catch
            {
                luckyDips = 1;
                //Ticket header
                TextBlockTicket.Text = "Number of row must be from 1 to 20!\n\nFor invalid inputs, 1 (one) row is generated:\n\n";
                TextBlockTicket.Text = TextBlockTicket.Text + "----------------------------------------\n";
                TextBlockTicket.Text = TextBlockTicket.Text + "Lotto Ticket\n";
                TextBlockTicket.Text = TextBlockTicket.Text + "----------------------------------------\n";
            }

            //Loop to generate and display the rows
            for (int i = 0; i < luckyDips; i++)
            {
                TextBlockTicket.Text = TextBlockTicket.Text + "----      ";

                row.SetNumbersToZero();
                row.GenerateNumbers();
                row.SortNumbers();
                row.PrintNumbers(TextBlockTicket);

                TextBlockTicket.Text = TextBlockTicket.Text + "    ----\n";
            }

            //Ticket footer
            TextBlockTicket.Text = TextBlockTicket.Text + "----------------------------------------\n";
        }

        private void ButtonSelectNZ_Click(object sender, RoutedEventArgs e)
        {
            int luckyDips;
            NZLotto row = new NZLotto();

            try
            {
                // Get the number from the use - default number is 1
                luckyDips = Convert.ToInt32(TextBoxTickets.Text);

                if (luckyDips < 1 || luckyDips > 20) // Limit range of tickets 1 to 20
                {
                    luckyDips = 1;
                    //Ticket header
                    TextBlockTicket.Text = "Number of row must be from 1 to 20!\n\nFor invalid inputs, 1 (one) row is generated:\n\n";
                    TextBlockTicket.Text = TextBlockTicket.Text + "--------------------------------------------\n";
                    TextBlockTicket.Text = TextBlockTicket.Text + "NZ Lotto Ticket |Bonus Number|\n";
                    TextBlockTicket.Text = TextBlockTicket.Text + "--------------------------------------------\n";
                }
                else
                {
                    //Ticket header
                    TextBlockTicket.Text = "";
                    TextBlockTicket.Text = TextBlockTicket.Text + "--------------------------------------------\n";
                    TextBlockTicket.Text = TextBlockTicket.Text + "NZ Lotto Ticket |Bonus Number|\n";
                    TextBlockTicket.Text = TextBlockTicket.Text + "--------------------------------------------\n";
                }
            }

            catch
            {
                luckyDips = 1;
                //Ticket header
                TextBlockTicket.Text = "Number of row must be from 1 to 20!\n\nFor invalid inputs, 1 (one) row is generated:\n\n";
                TextBlockTicket.Text = TextBlockTicket.Text + "--------------------------------------------\n";
                TextBlockTicket.Text = TextBlockTicket.Text + "NZ Lotto Ticket |Bonus Number|\n";
                TextBlockTicket.Text = TextBlockTicket.Text + "--------------------------------------------\n";
            }

            //Loop to generate and display the rows
            for (int i = 0; i < luckyDips; i++)
            {
                TextBlockTicket.Text = TextBlockTicket.Text + "----      ";

                row.SetNumbersToZero();
                row.GenerateNumbers();
                row.SortNumbers();
                row.PrintNZTicket(TextBlockTicket);

                TextBlockTicket.Text = TextBlockTicket.Text + "    ----\n";
            }

            //Ticket footer
            TextBlockTicket.Text = TextBlockTicket.Text + "--------------------------------------------\n";
        }
    }
}
