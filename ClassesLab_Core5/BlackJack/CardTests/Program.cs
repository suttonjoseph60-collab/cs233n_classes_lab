using System;
using CardClasses;

namespace CardTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCardConstructors();
            TestCardPropertyGetters();
            TestCardPropertySetters();
            TestBooleanProperties();
        }

        static void TestCardConstructors()
        {
            // Test default constructor
            Card defaultCard = new Card();
            Console.WriteLine("Default card ToString return: " + defaultCard);
            Console.WriteLine(" ");

            // Test parameterized constructor with valid values
            Card validCard = new Card(10, 2); // Ten of Diamonds
            Console.WriteLine("Valid card ToString return: " + validCard);
            Console.WriteLine(" ");

            defaultCard.compareSuit(validCard);
            defaultCard.compareValue(validCard);

            // Test parameterized constructor with invalid value
            try
            {
                Card invalidValueCard = new Card(0, 2);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Caught exception for invalid value: " + ex.Message);
                Console.WriteLine(" ");
            }
            // Test parameterized constructor with invalid suit
            try
            {
                Card invalidSuitCard = new Card(10, 5);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Caught exception for invalid suit: " + ex.Message);
                Console.WriteLine(" ");
            }
            // Test parameterized constructor with invalid color
            try
            {
                Card invalidColorCard = new Card(10, 2);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Caught exception for invalid color: " + ex.Message);
                Console.WriteLine(" ");
            }
        }

        static void TestCardPropertyGetters()
        {
            Card card1 = new Card(1, 3); // Ace of Hearts

            Console.WriteLine("Testing Getters ");
            Console.WriteLine("Card1 value: " + card1.Value);
            Console.WriteLine("Card1 suit: " + card1.Suit);
            Console.WriteLine("Card1 color: " + card1.Getcolor());
            Console.WriteLine(" ");
        }

        static void TestCardPropertySetters()
        {
            Card card2 = new Card(5, 2); // 5 of Diamonds
            Console.WriteLine("Testing Setters ");
            Console.WriteLine("original card2: " + card2);

            // Test setting valid values
            card2.Value = 10; // Ten
            card2.Suit = 4;   // Ten of Spades
            // card2.Color = 2;  // Black Ten of Spades
            Console.WriteLine("Updated card2: " + card2);
            Console.WriteLine(" ");

            // Test setting invalid values
            try
            {
                Console.WriteLine("Attempting to set invalid value...");
                card2.Value = 0;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Caught exception for invalid value: " + ex.Message);
                Console.WriteLine(" ");
            }

            try
            {
                Console.WriteLine("Attempting to set invalid suit...");
                card2.Suit = 5;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Caught exception for invalid suit: " + ex.Message);
                Console.WriteLine(" ");
            }
        }

        static void TestBooleanProperties()
        {
            Card card3 = new Card(1, 3); // Ace of Hearts
            Console.WriteLine("Testing Boolean Properties ");
            Console.WriteLine("Card3: " + card3);
            Console.WriteLine($"Is Red: {card3.IsRed()}");
            Console.WriteLine($"Is Black: {card3.IsBlack()}");
            Console.WriteLine($"Is Club: {card3.IsClub()}");
            Console.WriteLine($"Is Diamond: {card3.IsDiamond()}");
            Console.WriteLine($"Is Heart: {card3.IsHeart()}");
            Console.WriteLine($"Is Spade: {card3.IsSpade()}");
            Console.WriteLine(" ");
        }

        // ideas for modifications
        // generate deck. for each loop? 
        // console.ReadLine() enter a custom card. 
        // shuffle deck. 
        // are we making a full blackjack game? 
    }
}