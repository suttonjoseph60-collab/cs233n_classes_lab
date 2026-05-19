// Joseph Sutton
// cs233n c#
// classes lab problem 2 
// 5/9/2026

// Using the Visual Studio Solution provided in the starting files as a starting point and the Domino class as a model,
// implement and test a class that represents a (Playing) Card. 

// A card has the following attributes:  a integer value in the range of 1 - 13 (ace through king) and an integer suit
// in the range of 1 - 4 (clubs, diamonds, hearts, spades).  A card must be able to report and update each of these attributes.
// Any attempt to update an attribute to a value that is out of range should NOT change the value of the attribute and should
// generate an appropriate error.  The other attributes illustrated on the class diagram are class variables that are used as
// a "utility" in the class. 

// A programmer must be able to create a card without providing any of the attribute information and must be able to create
// a card while providing all of the attribute information.  Any attempt to create an invalid card should result in an
// appropriate error. 

// A card must be able to convert its attributes to a string for displaying on the screen.  The string created should a phrase
// like Ace of Hearts rather than the raw values 1 and 3.

// A card must be able to report each of the following boolean values related to its attributes:  is it red, is it black, is
// it club, is it a diamond, is it a heart, is it a spade, is it an ace and is it a face card

// A card must also be able to compare itself to another card and report each of the following boolean values:  does its
// suit match the other card, does its value match the other card. 

// comment added for testing. 

using System;
using System.ComponentModel.Design;
using System.Runtime.Serialization;

namespace CardClasses
{
    public class Card
    {
        private static string[] values = { "", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        private static string[] suits = { "", "Clubs", "Diamonds", "Hearts", "Spades" };
        private static string[] colors = { "", "Black", "Red" };
        private static Random cardGenerator = new Random();

        private int value;
        private int suit;

        public int Value
        {
            get { return value; }
            set
            {
                if (value < 1 || value > 13)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Value must be between 1 and 13.");
                }
                this.value = value;
            }
        }

        public int Suit
        {
            get { return suit; }
            set
            {
                if (value < 1 || value > 4)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Suit must be between 1 and 4.");
                }
                suit = value;
            }
        }

        public int Getcolor()
        {
            return this.suit == 1 || this.suit == 4 ? 1 : 2; // Clubs and Spades are black (1), Diamonds and Hearts are red (2)
        }

        public Card()
        {
            value = cardGenerator.Next(1, 14);
            suit = cardGenerator.Next(1, 5);
        }

        public Card(int value, int suit)
        {
            if (value < 1 || value > 13)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Value must be between 1 and 13.");
            }

            if (suit < 1 || suit > 4)
            {
                throw new ArgumentOutOfRangeException(nameof(suit), "Suit must be between 1 and 4.");
            }

            this.value = value;
            this.suit = suit;
        }

        public bool IsRed()
        {
            int color = Getcolor();
            if (color == 2)
            {
                return true;
            }
            return false;
        }

        public bool IsBlack()
        {
            int color = Getcolor();
            if (color == 1)
            {
                return true;
            } return false;
        }

        public bool IsClub()
        {
            if (suit == 1)
            {
                return true;
            }
            return false;
        }

        public bool IsDiamond()
        {
            if (suit == 2)
            {
                return true;
            }
            return false;
        }

        public bool IsHeart()
        {
            if (suit == 3)
            {
                return true;
            }
            return false;
        }

        public bool IsSpade()
        {
            if (suit == 4)
            {
                return true;
            }
            return false;
        }

        public bool IsAce()
        {
            if (value == 1)
            {
                return true;
            }
            return false;
        }

        
        public bool IsFaceCard()
        {
            if (value == 11 || value == 12 || value == 13)
            {
                return true;
            }
            return false; 
        }
        
        public bool compareSuit(Card otherCard)
        {
            if (this.suit == otherCard.suit)
            {
                return true;
            }
            return false;
        }

        public bool compareValue(Card otherCard)
        {
            if (this.value == otherCard.value)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{colors[Getcolor()]} {values[value]} of {suits[suit]}.";
        }
    }
}
