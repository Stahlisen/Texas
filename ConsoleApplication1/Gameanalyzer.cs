using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Gameanalyzer
    {

        string winner;
        Game game;
        List<Card> playerCards = new List<Card>();
        List<Card> AiCards = new List<Card>();
        Resulthand playerhand;
        Resulthand aihand;
        int winninghandvalue = 0;

        public Gameanalyzer(Game g)
        {
            game = g;
            playerhand = new Resulthand();
            aihand = new Resulthand();

        }
        public string determineWinner()
        {
            
            evaluateHands();
            return winner;
        }

        public string winningHand() {
            string hand = null;

            switch (winninghandvalue)
            {
                case 1:
                    hand = "Pair";
                    break;
                case 2:
                    hand = "Two Pair";
                    break;
                case 3:
                    hand = "Three of a kind";
                    break;
                case 4:
                    hand = "Straight";
                    break;
                case 5:
                    hand = "Flush";
                    break;
                case 6:
                    hand = "Full House";
                    break;
                case 7:
                    hand = "Four of a kind";
                    break;
                case 8:
                    hand = "Straight flush";
                    break;
            }


            return hand;
        }

        public void gatherHands()
        {
            
            playerCards.Clear();
            AiCards.Clear();
            //Add card combination for the player
            foreach (var x in game.guiplayer.Hand) {
                playerCards.Add(x);
            }
            foreach (var x in game.dealer.flopcards) {

                playerCards.Add(x);
            }
            playerCards.Add(game.dealer.turncard);
            playerCards.Add(game.dealer.rivercard);

            //Add card combination for the AIplayer
            foreach (var x in game.aiplayer.Hand) {
                AiCards.Add(x);
            }
            foreach (var x in game.dealer.flopcards) {

                AiCards.Add(x);
            }

            AiCards.Add(game.dealer.turncard);
            AiCards.Add(game.dealer.rivercard);

        }

        public void evaluateHands() {
            aihand.reset();
            playerhand.reset();
            gatherHands();
            checkForHands("player");
            checkForHands("aiplayer");

            Console.WriteLine("Ai result: " + aihand.getResult());
            Console.WriteLine("Player result: " + playerhand.getResult());

            if (playerhand.getResult() > aihand.getResult())
            {
                Console.WriteLine("Player wins");
                winninghandvalue = playerhand.getResult(); 
                winner = "player";
            }
            else if (playerhand.getResult() < aihand.getResult())
            {
                Console.WriteLine("AiPlayer wins");
                winninghandvalue = aihand.getResult();
                winner = "aiplayer";
            }
            else if (playerhand.getResult() == aihand.getResult())
            {
                Console.WriteLine("Match is even");
                winninghandvalue = playerhand.getResult();
                winner = "even";
            }
        }

        public void checkForHands(string player)
        {
            List<string> values = new List<string>();
            List<string> suits = new List<string>();
            List<Card> cards;
            values.Clear();
            suits.Clear();

            if (player == "player")
            {
                cards = playerCards;
            }
            else
            {
                cards = AiCards;
            }

            foreach (Card element in cards)
            {
                values.Add(element.getValue().ToString());
                suits.Add(element.getSuit().ToString());
            }

            checkForDuplicates(values, player);
            checkForStraight(values, suits, player);
            checkForFlush(suits, player);
        }

        public void checkForDuplicates(List<string> values, string player)
        {
            Resulthand hand;
            if (player == "player")
            {
                hand = playerhand;
            }
            else
            {
                hand = aihand;
            }
            List<string> pairs = new List<string>();
            List<int> paircounts = new List<int>();
            var paircards = from x in values
                        group x by x into grouped
                        where grouped.Count() > 1
                        select grouped.Key;

            var paircount = from x in values
                            group x by x into grouped
                            where grouped.Count() > 1
                            select grouped.Count();

            int paircounter = 0;
            int overtwo = 0;

            //If there was any duplicates we add each value of the pair into a List (pairs) and we return it from the method.
            if (paircards.Any())
            {
                foreach (var x in paircount)
                {
                    
                    paircounts.Add(x);
                    if (x == 3)
                    {
                        hand.setTriplet(true);
                        
                    }
                    else if (x == 4)
                    {
                        hand.setFour(true);
                        
                    }

                    var fullhousecheck = from y in paircounts
                                         where y > 2
                                         orderby y ascending
                                         select y;

                    foreach (var y in fullhousecheck)
                    {
                        overtwo++;
                    }

                    if (overtwo > 0 && paircounts.ToArray().Length > 1)
                    {
                        hand.setFullHouse(true);
                        
                    }
                }
                
                foreach (var x in paircards) {
                    
                    
                    paircounter++;
                    pairs.Add(x);
                }

                if (paircounter > 1)
                {
                    
                    hand.setTwoPair(true);
                }
                else
                {
                    hand.setPair(true);
                }
            } else
            {
                
            }
        }

        public void checkForStraight(List<string> values, List<string> suits, string player)
        {
            Resulthand hand;
            if (player == "player")
            {
                hand = playerhand;
            }
            else
            {
                hand = aihand;
            }
            List<int> straightlist = new List<int>();
            foreach (var x in values)
            {
                straightlist.Add(valueToNumber(x));

            }
            straightlist.Sort();
            int i = 0;
            int straightcounter = 0;

            foreach (var x in straightlist)
            {
                
                if (straightlist.IndexOf(x+1) == i+1) 
                {
                    straightcounter++;
                    i++;
                }
            }
            
            if (straightcounter == 4)
            {
                
                hand.setStraigth(true);
                if (hand.getFlush())
                {
                    hand.setStraightFlush(true);
                }
            }
            else
            {
                
            }
        }

        public void checkForFlush(List<string> suits, string player)
        {
            Resulthand hand;
            if (player == "player")
            {
                hand = playerhand;
            }
            else
            {
                hand = aihand;
            }

            var suitcount = from x in suits
                            group x by x into grouped
                            where grouped.Count() > 4
                            select grouped.Count();

            if (suitcount == null || suitcount.Count() == 0)
            {
                
            }
            else
            {
                
                hand.setFlush(true);
            }
           

        }

        public int valueToNumber(string value)
        {
            int digit = 0;
            switch (value) 
            {
                case "Ace" :
                    digit = 14;
                    break;
                
                case "Two":
                    digit = 2;
                    break;

                case "Three":
                    digit = 3;
                    break;

                case "Four":
                    digit = 4;
                    break;

                case "Five":
                    digit = 5;
                    break;

                case "Six":
                    digit = 6;
                    break;

                case "Seven":
                    digit = 7;
                    break;

                case "Eight":
                    digit = 8;
                    break;

                case "Nine":
                    digit = 9;
                    break;

                case "Ten":
                    digit = 10;
                    break;

                case "Jack":
                    digit = 11;
                    break;

                case "Queen":
                    digit = 12;
                    break;

                case "King":
                    digit = 13;
                    break;
            }
            return digit;
        }

        
    }
}
