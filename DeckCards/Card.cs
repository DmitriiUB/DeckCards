using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckCards
{
    internal class Card
    {
        public Suit Suit { get; private set; }
        public Values Values { get; private set; }
        public string TheCard { get { return $"{Values} of {Suit}."; } }
        public Card (Suit suit, Values values) { Suit = suit; Values = values; }
    }
}
