using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApplication1
{
   public class Gameloader
    {

       public static void InitializeGame(Game game)
       {
           //Loading guiplayer data
           IEnumerable<XElement> guiplayer = Statehandler.LoadGuiPlayerData();

           foreach (XElement x in guiplayer) {

               game.guiplayer.Name = x.Element("Name").Value;
               game.guiplayer.CurrentChips = Convert.ToDouble(x.Element("Chips").Value);
               game.guiplayer.CurrentBet = Convert.ToDouble(x.Element("Currentbet").Value);
               game.guiplayer.MyTurn = Convert.ToBoolean(x.Element("MyTurn").Value);
               
           }


           //Loading aiplayer data
           IEnumerable<XElement> aiplayer = Statehandler.LoadAiPlayerData();
         
           foreach (XElement x in aiplayer)
           {
              
               game.aiplayer.Name = x.Element("Name").Value;
               game.aiplayer.CurrentChips = Convert.ToDouble(x.Element("Chips").Value);
               game.aiplayer.CurrentBet = Convert.ToDouble(x.Element("Currentbet").Value);
               game.aiplayer.MyTurn = Convert.ToBoolean(x.Element("MyTurn").Value);

           }

           if (game.aiplayer.CurrentBet > 0)
           {
               game.currentbet = game.aiplayer.CurrentBet;
           }
           else if (game.guiplayer.CurrentBet > 0)
           {
               game.currentbet = game.guiplayer.CurrentBet;
           }
           else
           {
               game.currentbet = 0;
           }
           

           IEnumerable<XElement> gamedata = Statehandler.LoadGameData();

           
           foreach (XElement x in gamedata) {
               Console.WriteLine(x);
               
               game.currentpot = Convert.ToDouble(x.Element("Currentpot").Value);
               game.roundcounter = Convert.ToInt32(x.Element("Round").Value);
               setCurrentGive(x.Element("Currentgive").Value, game);
               game.check = Convert.ToBoolean(x.Element("Check").Value);
               game.doneround = Convert.ToInt32(x.Element("Doneround").Value);
               
            }
           if (Statehandler.getCurrentGive(game) == "starthand")
           {

               initiateStarthand(game);

           } else if (Statehandler.getCurrentGive(game) == "flop") {

               initiateStarthand(game);
               initiateFlop(game);
           }
           else if (Statehandler.getCurrentGive(game) == "turn")
           {
               initiateStarthand(game);
               initiateFlop(game);
               initiateTurn(game);
           }
           else if (Statehandler.getCurrentGive(game) == "river")
           {
               initiateStarthand(game);
               initiateFlop(game);
               initiateTurn(game);
               initiateRiver(game);
           }  
       }


       public static void initiateStarthand(Game game)
       {
           IEnumerable<XElement> cards = Statehandler.LoadPlayercards();
           foreach (XElement x in cards)
           {
               Console.WriteLine(x.Element("Guiplayer").Element("Card1").Element("Value").Value);
               Card guicard1 = new Card(x.Element("Guiplayer").Element("Card1").Element("Value").Value, x.Element("Guiplayer").Element("Card1").Element("Suit").Value);
               Card guicard2 = new Card(x.Element("Guiplayer").Element("Card2").Element("Value").Value, x.Element("Guiplayer").Element("Card2").Element("Suit").Value);
               Card aicard1 = new Card(x.Element("Aiplayer").Element("Card1").Element("Value").Value, x.Element("Aiplayer").Element("Card1").Element("Suit").Value);
               Card aicard2 = new Card(x.Element("Aiplayer").Element("Card2").Element("Value").Value, x.Element("Aiplayer").Element("Card2").Element("Suit").Value);

               game.guiplayer.Hand.Add(guicard1);
               game.guiplayer.Hand.Add(guicard2);

               game.aiplayer.Hand.Add(aicard1);
               game.aiplayer.Hand.Add(aicard2);


           }

       }

       public static void initiateFlop(Game game)
       {
           IEnumerable<XElement> cards = Statehandler.LoadFlopcards();
           foreach (XElement x in cards)
           {
               Console.WriteLine(x);
               Card flopcard1 = new Card(x.Element("Card1").Element("Value").Value, x.Element("Card1").Element("Suit").Value);
               Card flopcard2 = new Card(x.Element("Card2").Element("Value").Value, x.Element("Card2").Element("Suit").Value);
               Card flopcard3 = new Card(x.Element("Card3").Element("Value").Value, x.Element("Card3").Element("Suit").Value);

               game.dealer.flopcards.Add(flopcard1);
               game.dealer.flopcards.Add(flopcard2);
               game.dealer.flopcards.Add(flopcard3);
           }

       }
       public static void initiateTurn(Game game)
       {
           IEnumerable<XElement> cards = Statehandler.LoadTurncard();
           foreach (XElement x in cards)
           {
               Card turncard = new Card(x.Element("Value").Value, x.Element("Suit").Value);

               game.dealer.turncard = turncard;
           }
       }
       public static void initiateRiver(Game game)
       {
           IEnumerable<XElement> cards = Statehandler.LoadRivercard();
           foreach (XElement x in cards)
           {
               Card rivercard = new Card(x.Element("Value").Value, x.Element("Suit").Value);
               game.dealer.rivercard = rivercard;
           }

       }

       public static void setCurrentGive(string give, Game game)
       {
           if (give == "starthand")
           {
               game.starthand = true;
           }
           else if (give == "flop")
           {
               game.starthand = true;
               game.flop = true;
           }
           else if (give == "turn")
           {
               game.starthand = true;
               game.flop = true;
               game.turn = true;
           }
           else if (give == "river")
           {
               game.starthand = true;
               game.flop = true;
               game.turn = true;
               game.river = true;
           }
       }
    }
}
