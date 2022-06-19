using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckCards
{
    static class ToShuffleTheCards
    {
        
        private static Random random = new Random();
      
       public static void Shuffle(List<Card> cards)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                int indexA=random.Next(cards.Count);
                int indexB = random.Next(cards.Count);
                var cardA = cards[indexA];
                var cardB = cards[indexB];
                cards[indexA] = cardB;
                cards[indexB] = cardA;
            }
        }
    }
}
