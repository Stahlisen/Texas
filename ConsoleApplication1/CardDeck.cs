using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class CardDeck
    {

        private Card[] deck;
        private int currentCard;
        private Random rand;
        private const int maxcards = 52;
        


        public CardDeck()
        {
            

        }

        public int countCards()
        {

            return deck.Length;

        }
        public void buildDeck()
        {
            
            string[] values = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            deck = new Card[maxcards];
            rand = new Random();

            for (int i = 0; i < deck.Length; i++)
                deck[i] = new Card(values[i % 13], suits[i / 13]);
        }

        public void shuffleDeck()
        {
            buildDeck();
            currentCard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = rand.Next(maxcards);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
            
        }

        public Card getTopCard()
        {

            
                return deck[currentCard++].getCard();

        }

        public void RestoreDeck(List<Card> cardstodelete)
        {
            List<Card> restorelist = new List<Card>();
            restorelist = deck.ToList();
            foreach (var card in cardstodelete)
            {
                restorelist.RemoveAll((x) => x.getValue() == card.getValue() && x.getSuit() == card.getSuit());
                Console.WriteLine("Deleting card: " + card.getValue() + "of " + card.getSuit());
            }
            deck = restorelist.ToArray();    
        }
    }
}
