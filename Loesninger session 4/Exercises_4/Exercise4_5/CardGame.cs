using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_3
{
    internal class CardGame
    {
        private List<Card> cards = new List<Card>();

        public void AddCard(Suit suit, CardNumber number)
        {
            cards.Add(new Card(suit, number));
        }
        public List<Card> filterCardGame(FilterCardDelegate filter)
        {
            List<Card> result = new List<Card>();
            foreach(Card card in cards)
            {
                if(filter(card))
                {
                    result.Add(card);
                }
            }
            return result;
        }
    }
}
