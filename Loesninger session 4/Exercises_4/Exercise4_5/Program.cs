using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CardGame game = new CardGame();
            game.AddCard(Suit.Clubs, CardNumber.Jack);
            game.AddCard(Suit.Spades, CardNumber.Two);
            game.AddCard(Suit.Clubs, CardNumber.Four);
            game.AddCard(Suit.Spades, CardNumber.Ten);
            game.AddCard(Suit.Clubs, CardNumber.Ace);
            game.AddCard(Suit.Spades, CardNumber.Ace);
            game.AddCard(Suit.Spades, CardNumber.Queen);
            List<Card> cards = game.filterCardGame(FilterByKlør);
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
            Console.ReadLine();

            cards = game.filterCardGame(card => card.Number > CardNumber.Ten);
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
            Console.ReadLine();
        }
        static public bool FilterByKlør(Card card)
        {
            return card.Suit == Suit.Clubs;
        }

    }
}
