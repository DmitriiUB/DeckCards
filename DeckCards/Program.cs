using System;
using System.Collections.Generic;

namespace DeckCards
{
    internal class Program
    {        
        static Random random = new Random();
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            ToShuffleTheCards.Shuffle(deck.Cards);
            while (true)
            {  
                Console.Write("How many cards should I give you? ");
                string numberOfCards = Console.ReadLine();

                if (int.TryParse(numberOfCards, out int cardNumber)) 
                {
                    if (cardNumber <= deck.Cards.Count) ToDealTheCard(deck.Cards, cardNumber);
                    else return;
                }
    
            } 
        }

        private static void ToDealTheCard(List<Card> cards, int cardNumber)
        {
          Console.Write($"\nYou the card: ");
            for (int i = 0; i < cardNumber; i++)
            {
                int theCard = random.Next(cards.Count);
                if (i == 0) Console.WriteLine($"{cards[theCard].TheCard}");
                else Console.WriteLine($"\t\t\b\b{cards[theCard].TheCard}");
                cards.RemoveAt(theCard);
            }
            Console.WriteLine($"{cards.Count}");
            Console.WriteLine("");
        }
    }
}
