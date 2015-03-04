using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Ruleengine
    {
        Game game;
        public Ruleengine(Game g)
        {
            game = g;
        }

        public bool BetPermitted(double amount, IPlayer player)
        {
            if (game.currentbet > 0 || amount > player.CurrentChips)
            {
                return false;
            }
            else
            {
                if (player == game.guiplayer)
                {
                    game.gamecontroller.gameEvent(" GUIPlayer bets " + amount);
                }
                else
                {
                    game.gamecontroller.gameEvent("AIPlayer bets " + amount, 1);
                }
                game.doneround = 1;
                game.currentbet = amount;
                Statehandler.SaveGameData(game);
            return true;       
            }
            
        }

        public bool CheckPermitted(IPlayer player)
        {
            if (game.currentbet > 0)
            {
                return false;
            }
            else
            {
                if (game.check)
                {
                    Console.WriteLine("Someone checked before");
                    if (player == game.guiplayer)
                    {
                        game.gamecontroller.gameEvent(" GUIPlayer checks");
                        Console.WriteLine("GUIPLAYER CHECKS");
                    }
                    else
                    {
                        game.gamecontroller.gameEvent("AI checks", 1);
                        Console.WriteLine("AIPLAYER CHECKS");
                    }
                    game.check = false;
                    game.doneround = 2;
                    Statehandler.SaveGameData(game);
                    return true;
                }
                else
                {
                Console.WriteLine("Noone checked before");
                if (player == game.guiplayer)
                {
                    game.gamecontroller.gameEvent(" GUIPlayer checks");
                    Console.WriteLine("GUIPLAYER CHEKS");
                }
                else
                {
                    game.gamecontroller.gameEvent("AI checks", 1);
                    Console.WriteLine("AIPLAYER CHEKS");
                }
                game.check = true;
                game.doneround = 1;
                Statehandler.SaveGameData(game);
                    return true;
                }
               
                
                
            }
        }

        public void FoldPermitted(IPlayer player)
        {
            if (player == game.guiplayer)
            {
                game.gamecontroller.gameEvent("You folded, AI player wins" + game.currentpot, 1);
            }
            else
            {
                game.gamecontroller.gameEvent("AI Player decided to fold, you win " + game.currentpot, 1);
            }
            game.playerDidFold(player);
            game.doneround = 0;
            Statehandler.SaveGameData(game);
        }

        public bool CallPermitted(double amount, IPlayer player)
        {
            if (game.currentbet == 0)
            {
                return false;
            }
            else
            {
                if (player == game.guiplayer)
                {
                    game.gamecontroller.gameEvent("GUIPlayer calls" + amount);
                    
                }
                else
                {
                    game.gamecontroller.gameEvent("AI calls " + amount, 1);
                    
                }
               
                game.currentbet = game.currentbet + amount;
                game.doneround = 2;
                Statehandler.SaveGameData(game);
                return true;
                
            }
        }
    }
}
