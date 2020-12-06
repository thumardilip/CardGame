using System;
using System.Collections.Generic;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();

            List<Card> shuffleDeck = new List<Card>();
            Random r = new Random();
            int p = 0;
            while (myDeck.Cards.Count > 0)
            {
                p = r.Next(0, myDeck.Cards.Count);
                shuffleDeck.Add(myDeck.Cards[p]);
                Console.WriteLine(myDeck.Cards[p].suite +" "+ myDeck.Cards[p].value);
                myDeck.Cards.Remove(myDeck.Cards[p]);
            }
            myDeck.Cards = shuffleDeck;
            Console.ReadLine();
        }
    }
}
