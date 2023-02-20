using System;
using System.Collections.Generic;

namespace Stacks_Hamilton_Dakota
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stack Array
            Card[] myCardsArray = new Card[]
            {
                new Card("Ace", "Spades"),
                new Card("Jack", "Clubs"),
                new Card("Queen", "Diamonds"),
                new Card("Queen", "Hearts"),
                new Card("10", "Hearts"),
                new Card("2", "Diamonds"),
                new Card("6", "Spades"),
                new Card("9", "Clubs"),
                new Card("Ace", "Diamonds")
            };

            // Creates a new initialization of the Stack
            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);

            // Shows the Objects in the new Stack
            Console.WriteLine("Cards in Deck:");
            foreach (Card card in startingDeck)
            {
                // Defines each of the Objects in the new Stack
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }
            
            // Counts the Objects in the new Stack
            Console.WriteLine($"Cards in the stack: {startingDeck.Count}");

            // Object List
            List<Card> myHand = new List<Card>();
            myHand.Add(new Card("Jack", "Diamonds"));
            myHand.Add(new Card("8", "Hearts"));
            myHand.Add(new Card("3", "Diamonds"));

            // Determines the Object from the List
            Console.WriteLine("Got any 8's?");
            if(startingDeck.Count > 0)
            {
                myHand.Add(startingDeck.Pop());
            }

            // Recounts the new Stack
            Console.WriteLine($"Cards in the stack: {startingDeck.Count}");

            // Inserts new Object at the top of the new Stack
            startingDeck.Push(myHand[0]);

            // Removes the old Object at the Top in favor of the new
            myHand.RemoveAt(0);

            // Recounts the new Stack again 
            Console.WriteLine("Cards in Deck:");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }


        }
    }
}
