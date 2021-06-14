using System;

namespace Assignment1App
{
    class Lotto
    {
        public int[] numArray;
        public Random randomNumber;

        //Constructor
        public Lotto()
        {
            numArray = new int[6];
            randomNumber = new Random(DateTime.Now.Millisecond);
        }

        //Method to generate and populate the array with six unique numbers
        public void GenerateNumbers()
        {
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = randomNumber.Next(1, 50);
                for (int j = 0; j < i; j++)
                {
                    if (numArray[j] == numArray[i])
                    {
                        i--;
                    }
                }
            }            
        }

        //Method to display the array on the text block
        public void PrintNumbers(Windows.UI.Xaml.Controls.TextBlock OutputTextBlock)
        {
            for (int i = 0; i < numArray.Length; i++)
            {
                // Format and displays 6 numbers to the screen
                if (numArray[i] < 10)
                {
                    OutputTextBlock.Text = OutputTextBlock.Text + "  " + numArray[i] + "  ";
                }
                else
                {
                    OutputTextBlock.Text = OutputTextBlock.Text + numArray[i] + "  ";
                }
            }
        }

        //Method to set all the numbers zero
        public void SetNumbersToZero()
        {
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = 0;
            }
        }

        //Method to sort the numbers in ascending order - bubble sort algorithm
        public void SortNumbers()
        {
            int temp;
            for (int i = 0; i < numArray.Length; i++)
			{
                for (int j = 0; j < i; j++)
                {
                    if (numArray[j] > numArray[i])
                    {
                        temp = numArray[j];
                        numArray[j] = numArray[i];
                        numArray[i] = temp;
                    }
                }
			}
        }
    }

    //Extended derived class
    class NZLotto : Lotto
    {
        int bonusNumber; 

        //Method to display the array + bonus number
        public void PrintNZTicket(Windows.UI.Xaml.Controls.TextBlock OutputTextBlock)
        {            
            bonusNumber = randomNumber.Next(1, 50); //Generate bonus number 

            for (int i = 0; i < numArray.Length; i++)
            {
                // Format and displays 6 numbers to the screen + bonus number
                if (numArray[i] < 10)
                {
                    OutputTextBlock.Text = OutputTextBlock.Text + "  " + numArray[i] + "  ";
                }
                else
                {
                    OutputTextBlock.Text = OutputTextBlock.Text + numArray[i] + "  ";
                }                
            }
            if (bonusNumber < 10)
            {
                OutputTextBlock.Text = OutputTextBlock.Text + "|  " + bonusNumber + "|";
            }
            else
            {
                OutputTextBlock.Text = OutputTextBlock.Text + "|" + bonusNumber + "|";
            }

            
        }       
    } 
}
