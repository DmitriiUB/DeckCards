using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DeckCards
{
     class Deck
     {
        public List<Card> Cards = new List<Card>();

        public Deck()
        {
            StandardDeck(Cards);
        }
                
        private void StandardDeck(List<Card> Cards)
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach(Values values in Enum.GetValues(typeof(Values)))
                {
                    Card card = new Card(suit, values);
                    Cards.Add(card);
                }
            }
        }
        
     }
}
