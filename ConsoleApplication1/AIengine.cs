using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class AIengine
    {
        IPlayer aiplayer;
        Gameanalyzer analyzer;
        Game game;

        public AIengine(IPlayer ai, Gameanalyzer ga, Game g)
        {
            aiplayer = ai;
            analyzer = ga;
            game = g;
        }

        public void takeAction()
        {
        int scorecounter = 0;
        foreach (var x in aiplayer.Hand)
        {
            scorecounter = scorecounter + valueToNumber(x.getValue());

        }

            if (game.currentbet == 0 && scorecounter < 9)
            {
                Thread.Sleep(1300);
                aiplayer.Check();

            }
            else if (game.currentbet == 0 && scorecounter >= 8)
            {
                    Thread.Sleep(1300);
                    double betamount = aiplayer.CurrentChips / 20;
                    aiplayer.Bet(Math.Truncate(betamount));
            }
         
            
            else if (game.currentbet > 0 && game.currentbet <= aiplayer.CurrentChips/5) {

                Console.WriteLine(scorecounter);
                if (scorecounter > 14)
                {
                    Thread.Sleep(1300);
                    aiplayer.Call(game.currentbet);
                }
                else
                {
                    Thread.Sleep(1300);
                    aiplayer.Fold();
                }
            }
            else
            {
                Thread.Sleep(1300);
                aiplayer.Fold();
            }
        }

        public int valueToNumber(string value)
        {
            int digit = 0;
            switch (value)
            {
                case "Ace":
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
