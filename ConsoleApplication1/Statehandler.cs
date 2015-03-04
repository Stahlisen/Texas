using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApplication1
{
    public class Statehandler
    {

        public static void SavePlayerData(Game game)
        {
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("XML tree of player data"),
                new XElement("Players",
                    new XElement("Player", new XAttribute("Type", "Gui"),
                        new XElement("Chips", Convert.ToString(game.guiplayer.CurrentChips)),
                        new XElement("Name", game.guiplayer.Name),
                        new XElement("MyTurn", game.guiplayer.MyTurn),
                        new XElement("Currentbet", Convert.ToString(game.guiplayer.CurrentBet))),
                    new XElement("Player", new XAttribute("Type", "Ai"),
                        new XElement("Chips", Convert.ToString(game.aiplayer.CurrentChips)),
                        new XElement("Name", game.aiplayer.Name),
                        new XElement("MyTurn", game.aiplayer.MyTurn),
                        new XElement("Currentbet", Convert.ToString(game.aiplayer.CurrentBet)))));

            xmlDocument.Save("Playerdata.xml");

        }

        

        public static void SaveGameData(Game game)
        {
            string give = getCurrentGive(game);
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("XML tree of game data"),
                new XElement("Games", 
                new XElement("Game", new XAttribute ("Type", "initial"),
                    new XElement("Currentpot", Convert.ToString(game.currentpot)),
                    new XElement("Currentbet", Convert.ToString(game.currentbet)),
                    new XElement("Round", game.roundcounter),
                    new XElement("Currentgive", give),
                    new XElement("Check", Convert.ToString(game.check)),
                    new XElement("Doneround", game.doneround))));

            xmlDocument.Save("Gamedata.xml");
        }



        public static void SaveCards(Game game)
        {
            if (getCurrentGive(game) == "starthand")
            {
                XDocument xmlDocument = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("XML tree of game data"),
                    new XElement("Cards",
                        new XElement("Playercards",
                            new XElement("Guiplayer",
                                new XElement("Card1",
                                    new XElement("Value", game.guiplayer.Hand[0].getValue()),
                                        new XElement("Suit", game.guiplayer.Hand[0].getSuit())),
                                new XElement("Card2",
                                    new XElement("Value", game.guiplayer.Hand[1].getValue()),
                                        new XElement("Suit", game.guiplayer.Hand[1].getSuit()))),
                            new XElement("Aiplayer",
                                new XElement("Card1",
                                    new XElement("Value", game.aiplayer.Hand[0].getValue()),
                                        new XElement("Suit", game.aiplayer.Hand[0].getSuit())),
                                new XElement("Card2",
                                    new XElement("Value", game.aiplayer.Hand[1].getValue()),
                                        new XElement("Suit", game.aiplayer.Hand[1].getSuit()))))));
                xmlDocument.Save("Cards.xml");
            } if (getCurrentGive(game) == "flop")
            {
                XDocument xmlDocument = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("XML tree of game data"),
                    new XElement("Cards",
                        new XElement("Playercards",
                            new XElement("Guiplayer",
                                new XElement("Card1",
                                    new XElement("Value", game.guiplayer.Hand[0].getValue()),
                                        new XElement("Suit", game.guiplayer.Hand[0].getSuit())),
                                new XElement("Card2",
                                    new XElement("Value", game.guiplayer.Hand[1].getValue()),
                                        new XElement("Suit", game.guiplayer.Hand[1].getSuit()))),
                            new XElement("Aiplayer",
                                new XElement("Card1",
                                    new XElement("Value", game.aiplayer.Hand[0].getValue()),
                                        new XElement("Suit", game.aiplayer.Hand[0].getSuit())),
                                new XElement("Card2",
                                    new XElement("Value", game.aiplayer.Hand[1].getValue()),
                                        new XElement("Suit", game.aiplayer.Hand[1].getSuit())))),
                        new XElement("Flopcards",
                            new XElement("Card1",
                                new XElement("Value", game.dealer.getFlop()[0].getValue()),
                                    new XElement("Suit", game.dealer.getFlop()[0].getSuit())),
                            new XElement("Card2",
                                new XElement("Value", game.dealer.getFlop()[1].getValue()),
                                    new XElement("Suit", game.dealer.getFlop()[1].getSuit())),
                            new XElement("Card3",
                                new XElement("Value", game.dealer.getFlop()[2].getValue()),
                                    new XElement("Suit", game.dealer.getFlop()[2].getSuit())))));
                xmlDocument.Save("Cards.xml");
            } if (getCurrentGive(game) == "turn")
            {
                XDocument xmlDocument = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("XML tree of game data"),
                    new XElement("Cards",
                        new XElement("Playercards",
                            new XElement("Guiplayer",
                                new XElement("Card1",
                                    new XElement("Value", game.guiplayer.Hand[0].getValue()),
                                        new XElement("Suit", game.guiplayer.Hand[0].getSuit())),
                                new XElement("Card2",
                                    new XElement("Value", game.guiplayer.Hand[1].getValue()),
                                        new XElement("Suit", game.guiplayer.Hand[1].getSuit()))),
                            new XElement("Aiplayer",
                                new XElement("Card1",
                                    new XElement("Value", game.aiplayer.Hand[0].getValue()),
                                        new XElement("Suit", game.aiplayer.Hand[0].getSuit())),
                                new XElement("Card2",
                                    new XElement("Value", game.aiplayer.Hand[1].getValue()),
                                        new XElement("Suit", game.aiplayer.Hand[1].getSuit())))),
                        new XElement("Flopcards",
                            new XElement("Card1",
                                new XElement("Value", game.dealer.getFlop()[0].getValue()),
                                    new XElement("Suit", game.dealer.getFlop()[0].getSuit())),
                            new XElement("Card2",
                                new XElement("Value", game.dealer.getFlop()[1].getValue()),
                                    new XElement("Suit", game.dealer.getFlop()[1].getSuit())),
                            new XElement("Card3",
                                new XElement("Value", game.dealer.getFlop()[2].getValue()),
                                    new XElement("Suit", game.dealer.getFlop()[2].getSuit()))),
                       new XElement("Turncard",
                           new XElement("Value", game.dealer.getTurn().getValue()),
                           new XElement("Suit", game.dealer.getTurn().getSuit()))));
                xmlDocument.Save("Cards.xml");
            } if (getCurrentGive(game) == "river")
            {
                XDocument xmlDocument = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("XML tree of game data"),
                    new XElement("Cards",
                        new XElement("Playercards",
                            new XElement("Guiplayer",
                                new XElement("Card1",
                                    new XElement("Value", game.guiplayer.Hand[0].getValue()),
                                        new XElement("Suit", game.guiplayer.Hand[0].getSuit())),
                                new XElement("Card2",
                                    new XElement("Value", game.guiplayer.Hand[1].getValue()),
                                        new XElement("Suit", game.guiplayer.Hand[1].getSuit()))),
                            new XElement("Aiplayer",
                                new XElement("Card1",
                                    new XElement("Value", game.aiplayer.Hand[0].getValue()),
                                        new XElement("Suit", game.aiplayer.Hand[0].getSuit())),
                                new XElement("Card2",
                                    new XElement("Value", game.aiplayer.Hand[1].getValue()),
                                        new XElement("Suit", game.aiplayer.Hand[1].getSuit())))),
                        new XElement("Flopcards",
                            new XElement("Card1",
                                new XElement("Value", game.dealer.getFlop()[0].getValue()),
                                    new XElement("Suit", game.dealer.getFlop()[0].getSuit())),
                            new XElement("Card2",
                                new XElement("Value", game.dealer.getFlop()[1].getValue()),
                                    new XElement("Suit", game.dealer.getFlop()[1].getSuit())),
                            new XElement("Card3",
                                new XElement("Value", game.dealer.getFlop()[2].getValue()),
                                    new XElement("Suit", game.dealer.getFlop()[2].getSuit()))),
                       new XElement("Turncard",
                           new XElement("Value", game.dealer.getTurn().getValue()),
                           new XElement("Suit", game.dealer.getTurn().getSuit())),
                       new XElement("Rivercard",
                           new XElement("Value", game.dealer.getRiver().getValue()),
                            new XElement("Suit", game.dealer.getRiver().getSuit()))));
                xmlDocument.Save("Cards.xml");
            }
        }

        //Method to load playerdata at start up
        public static IEnumerable<XElement> LoadGuiPlayerData()
        {

            XElement playerdata = XElement.Load("Playerdata.xml");
            IEnumerable<XElement> player =
                from x in playerdata.Elements("Player")
                where (string)x.Attribute("Type") == "Gui"
                select x;

           

            return player;
            
        }

        public static IEnumerable<XElement> LoadAiPlayerData()
        {
            XElement playerdata = XElement.Load("Playerdata.xml");
            IEnumerable<XElement> player =
                from x in playerdata.Elements("Player")
                where (string)x.Attribute("Type") == "Ai"
                select x;

            return player;
        }

        public static IEnumerable<XElement> LoadGameData()
        {
            Console.WriteLine("Loadgamedata");
            XElement gamedata = XElement.Load("Gamedata.xml");
            IEnumerable<XElement> game =
                from x in gamedata.Elements("Game")
                where (string)x.Attribute("Type") == "initial"
                select x;

            return game;
            
        }

        public static IEnumerable<XElement> LoadPlayercards()
        {
            XElement carddata = XElement.Load("Cards.xml");
            IEnumerable<XElement> cards =
                from x in carddata.Elements("Playercards")
                select x;

            return cards;
        }

        public static IEnumerable<XElement> LoadFlopcards()
        {
            XElement carddata = XElement.Load("Cards.xml");
            IEnumerable<XElement> cards =
                from x in carddata.Elements("Flopcards")
                select x;

            return cards;
        }

        public static IEnumerable<XElement> LoadTurncard()
        {
            XElement carddata = XElement.Load("Cards.xml");
            IEnumerable<XElement> cards =
                from x in carddata.Elements("Turncard")
                select x;

            return cards;
        }

        public static IEnumerable<XElement> LoadRivercard()
        {
            XElement carddata = XElement.Load("Cards.xml");
            IEnumerable<XElement> cards =
                from x in carddata.Elements("Rivercard")
                select x;

            return cards;
        }


        public static string getCurrentGive(Game game)
        {
            string give;

            if (game.starthand & !game.flop)
            {
                give = "starthand";
            }
            else if (game.starthand & game.flop & !game.turn)
            {
                give = "flop";
            }
            else if (game.starthand & game.flop & game.turn & !game.river)
            {
                give = "turn";
            }
            else if (game.starthand & game.flop & game.turn & game.river)
            {
                give = "river";
            }
            else
            {
                give = "null";
            }

            return give;
        }

       
    }
}

