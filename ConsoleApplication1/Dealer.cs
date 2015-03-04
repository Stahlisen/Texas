using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    public class Dealer 
    {

       CardDeck deck = new CardDeck();
       Game currentgame;
       public List <Card> flopcards = new List<Card>();
       public Card turncard;
       public Card rivercard;

        public Dealer(Game _game)
        {
            currentgame = _game;

        }
        public CardDeck getDeck()
        {
            return deck;
        }

        public void resetCards()
        {
            Console.WriteLine("Reset");
            currentgame.aiplayer.Hand.Clear();
            currentgame.guiplayer.Hand.Clear();
            currentgame.gamecontroller.resetCards();
        }

        public void restoreCards(List<Card> playercards)
        {
            List<Card> cardstoremove = new List<Card>();

            foreach (var card in playercards)
            {
                cardstoremove.Add(card);
            }

            if (flopcards.Count() > 0)
            {
            foreach (var card in flopcards)
            {
                cardstoremove.Add(card);
            }}
            if (turncard != null)
            {
                cardstoremove.Add(turncard);
            }
            if (rivercard != null)
            {
                cardstoremove.Add(rivercard);
            }

            deck.RestoreDeck(cardstoremove);
        }
       
        public void startHand()
        {
            //Shuffle the deck on starthand
            getDeck().shuffleDeck();
            //Pick two cards from the top of the deck and give them to the players
            List<Card> playerhand = new List<Card>();
            List<Card> aihand = new List<Card>();
            playerhand.Add(getDeck().getTopCard());
            playerhand.Add(getDeck().getTopCard());
            aihand.Add(getDeck().getTopCard());
            aihand.Add(getDeck().getTopCard());

            currentgame.aiplayer.Hand = aihand;
            currentgame.guiplayer.Hand = playerhand;

            //Get the two cards from the starthand of the player
            Card playercard1 = currentgame.guiplayer.Hand[0];
            Card playercard2 = currentgame.guiplayer.Hand[1];
            Console.WriteLine("Human player cards:");
            Console.WriteLine(playercard1.getValue() + playercard1.getSuit());
            Console.WriteLine(playercard2.getValue() + playercard2.getSuit());
            Card aiplayercard1 = currentgame.aiplayer.Hand[0];
            Card aiplayercard2 = currentgame.aiplayer.Hand[1];
            Console.WriteLine("AI player cards: ");
            Console.WriteLine(aiplayercard1.getValue() + aiplayercard1.getSuit());
            Console.WriteLine(aiplayercard2.getValue() + aiplayercard2.getSuit());
            currentgame.gamecontroller.displayStarthand();
        }

        public void flop()
        {
            Console.WriteLine("Flop");
            flopcards.Clear();
            //Pick three cards from the top of the deck and put them in the flop List
            flopcards.Add(getDeck().getTopCard());
            flopcards.Add(getDeck().getTopCard());
            flopcards.Add(getDeck().getTopCard());
            currentgame.gamecontroller.displayFlop(flopcards);
        }

        public void turn()
        {
            //Pick a card from the top of the deck and set the turncard as that card so we can access it later.
            turncard = getDeck().getTopCard();
            currentgame.gamecontroller.displayTurn(turncard);

        }

        public void river()
        {
            //Pick a card from the top of the deck and set rivercard as that card so we can access it later.
            rivercard = getDeck().getTopCard();
            currentgame.gamecontroller.displayRiver(rivercard);
        }

        public List<Card> getFlop()
        {

            return flopcards;
        }

        public Card getTurn()
        {
            return turncard;
        }

        public Card getRiver()
        {
            return rivercard;
        }

        }
    }

