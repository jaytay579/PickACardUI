using System;
using System.Collections.Generic;
using System.Text;

namespace PickACardUI
{
    class CardPicker
    {
        static Random random = new Random();

        /* Page 108, Step 1: What lines of the below code are needed to get rid of the red squiggly under PickSomeCards? What lines cause more red squigglies? */
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        /* p. 108 Step 2: These methods may appear in reverse order, depending how you asked them to be generated. That is ok. Method order generally does not matter, since the program is compiled before running! */

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }

        /* p. 109: Why don't we have to test for value == 4? What are some other ways we could write this code, using other structures that you know? */
        private static string RandomSuit()
        {
            // get a random number from 1 to 4
            int value = random.Next(1, 5);
            // if it's 1 return the string Spades
            if (value == 1) return "Spades";
            // if it's 2 return the string Hearts
            if (value == 2) return "Hearts";
            // if it's 3 return the string Clubs
            if (value == 3) return "Clubs";
            // if we haven't returned yet, return the string Diamonds
            return "Diamonds";
        }

        /* p. 132: The book says to put this code into any method, but we already have a class variable random being used in the other methods. So, I made this method separate. However, notice that above the method (in Visual Studio, anyway) i says "0 references". This means nothing is calling this function. How could we test it? */

        private static void RandomDoublesDemo()
        {
            // this is a local random
            Random random = new Random();
            double[] randomDoubles = new double[20];
            for (int i=0; i<20; i++)
            {
                double value = random.NextDouble();
                randomDoubles[i] = value;
            }
        }
    }
}
