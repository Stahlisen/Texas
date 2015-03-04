using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;



namespace ConsoleApplication1
{

    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        public double smallBlind, bigBlind;
        public Dealer dealer;
        public IPlayer guiplayer;
        public IPlayer aiplayer;
        public AIengine aiengine;
        public int roundcounter = 0;
        public double currentpot = 0;
        public double currentbet = 0;
        public bool starthand = false;
        public bool flop = false;
        public bool turn = false;
        public bool river = false;
        string path = @"..\cards\";
        Gameanalyzer gameanalyzer;
        public Gamecontroller gamecontroller;
        Ruleengine ruleengine;
        public bool check = false;
        public int doneround = 0;

        public Game(string name, double chips, Gamecontroller controller, bool newgame)
        {
            if (newgame)
            {
                gamecontroller = controller;
                ruleengine = new Ruleengine(this);
                guiplayer = new Guiplayer(ruleengine);
                aiplayer = new AIplayer(ruleengine);
                aiengine = new AIengine(aiplayer, gameanalyzer, this);
                guiplayer.Name = name;
                aiplayer.Name = "AI";
                guiplayer.PropertyChanged += new PropertyChangedEventHandler(gamecontroller.Guiplayer_PropertyChanged);
                guiplayer.PropertyChanged += new PropertyChangedEventHandler(GUIturn_PropertyChanged);
                aiplayer.PropertyChanged += new PropertyChangedEventHandler(gamecontroller.Aiplayer_PropertyChanged);
                PropertyChanged += new PropertyChangedEventHandler(gamecontroller.game_PropertyChanged);

                smallBlind = chips / 10;
                bigBlind = chips / 10 * 2;
                dealer = new Dealer(this);
                gameanalyzer = new Gameanalyzer(this);
            }
            else
            {
                gamecontroller = controller;
                ruleengine = new Ruleengine(this);
                guiplayer = new Guiplayer(ruleengine);
                aiplayer = new AIplayer(ruleengine);
                aiengine = new AIengine(aiplayer, gameanalyzer, this);
                smallBlind = 2000 / 10;
                bigBlind = 2000 / 10 * 2;
                dealer = new Dealer(this);
                gameanalyzer = new Gameanalyzer(this);
                Gameloader.InitializeGame(this);
                
               
                guiplayer.PropertyChanged += new PropertyChangedEventHandler(gamecontroller.Guiplayer_PropertyChanged);
                guiplayer.PropertyChanged += new PropertyChangedEventHandler(GUIturn_PropertyChanged);
                aiplayer.PropertyChanged += new PropertyChangedEventHandler(gamecontroller.Aiplayer_PropertyChanged);
                PropertyChanged += new PropertyChangedEventHandler(gamecontroller.game_PropertyChanged);
              
                
            }
        }

        //Method that calculates who gets small blind
        public string getSmallBlindTurn()
        {

            if (roundcounter % 2 == 0)
            {
                
                return "guiplayer";

            }
            else
            {
                
                return "aiplayer";
            }
        }

        public void newRound()
        {
            doneround = 0;
            Console.WriteLine("Newround");
            resetPlayerBets();
            currentbet = 0;
            currentpot = 0;
            roundcounter++;
            resetPlayerBets();
            starthand = false;
            flop = false;
            turn = false;
            river = false;
            payBlinds();
            dealer.resetCards();
            Statehandler.SaveGameData(this);
            nextCards();
           
            
        }

        public void payBlinds()
        {
            
            if (getSmallBlindTurn() == "guiplayer")
            {
                Console.WriteLine("guiplayer smallblind");
                guiplayer.PayBlind(smallBlind);
                aiplayer.PayBlind(bigBlind);
                currentbet = smallBlind + bigBlind;
                gatherPot();
            }
            else
            {
                guiplayer.MyTurn = true;
                Console.WriteLine("player smallblind");
                guiplayer.PayBlind(bigBlind);
                aiplayer.PayBlind(smallBlind);
                currentbet = smallBlind + bigBlind;
                gatherPot();
            }
        }

        public void gatherPot()
        {
            currentpot = currentpot + currentbet;
            currentbet = 0;
            Statehandler.SaveGameData(this);
            NotifyPropertyChanged("currentpot");
        }

        public void nextCards()
        {
            check = false;
            if (!starthand)
            {
                Console.WriteLine(doneround);
                resetPlayerBets();
                gatherPot();
                currentbet = 0;
                Console.WriteLine("Current give is: Starthand");
                dealer.startHand();
                starthand = true;
                Statehandler.SaveGameData(this);
                Statehandler.SaveCards(this);
            }
            else if (starthand & !flop)
            {
                Console.WriteLine(doneround);
                resetPlayerBets();
                gatherPot();
                currentbet = 0;
                Console.WriteLine("Current give is: Flop");
                dealer.flop();
                flop = true;
                Statehandler.SaveGameData(this);
                Statehandler.SaveCards(this);
            } 
            else if (starthand & flop & !turn) 
            {
                Console.WriteLine(doneround);
                resetPlayerBets();
                gatherPot();
                currentbet = 0;
                Console.WriteLine("Current give is: Turn");
                dealer.turn();
                turn = true;
                Statehandler.SaveGameData(this);
                Statehandler.SaveCards(this);
            }
            else if (starthand & flop & turn & !river)
            {
                Console.WriteLine(doneround);
                resetPlayerBets();
                gatherPot();
                currentbet = 0;
                Console.WriteLine("Current give is: River");
                dealer.river();
                river = true;
                Statehandler.SaveGameData(this);
                Statehandler.SaveCards(this);
            }
            else if (starthand & flop & turn & river)
            {
                Console.WriteLine(doneround);
                Statehandler.SaveGameData(this);
                Statehandler.SaveCards(this);
                result();
            }
        }

        public void playerDidFold(IPlayer player)
        {
            if (player == aiplayer)
            {
                gamecontroller.gameEvent("AI folded, player wins " + currentpot);
                guiplayer.CurrentChips = guiplayer.CurrentChips + currentpot + guiplayer.CurrentBet;
                currentpot = 0;
                newRound();

            }
            else if (player == guiplayer)
            {
                gamecontroller.gameEvent("Player folded, AI wins " + currentpot);
                aiplayer.CurrentChips = aiplayer.CurrentChips + currentpot + aiplayer.CurrentBet;
                currentpot = 0;
                newRound();
            }
        }

        public void GUIturn_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName) {
            case "MyTurn" :
                if (guiplayer.MyTurn)
                {
                    if (doneround == 2)
                    {
                        nextCards();
                    }
                    Console.WriteLine("Players turn");
                }
                else if (!guiplayer.MyTurn)
                {
                    if (doneround == 2)
                    {
                        nextCards();
                    }
                    aiplayer.MyTurn = true;
                    aiengine.takeAction();
                    guiplayer.MyTurn = true;

                }
                break;
            }
        }

        public void resetPlayerBets()
        {
            aiplayer.CurrentBet = 0;
            guiplayer.CurrentBet = 0;
        }

        public void result()
        {
            string winner = gameanalyzer.determineWinner();
            string resulthand = gameanalyzer.winningHand();

            if (winner == "player")
            {
                gamecontroller.gameEvent("GUIPlayer wins with " + resulthand , 1);
                guiplayer.CurrentChips = guiplayer.CurrentChips + currentpot;

                newRound();
            }
            else if (winner == "aiplayer")
            {
                gamecontroller.gameEvent("AIPlayer wins with " + resulthand , 1);
                aiplayer.CurrentChips = aiplayer.CurrentChips + currentpot;

                newRound();
            }
            else if (winner == "even")
            {
                gamecontroller.gameEvent("Match is even, both players have " + resulthand, 1);
                aiplayer.CurrentChips = aiplayer.CurrentChips + currentpot / 2;
                guiplayer.CurrentChips = guiplayer.CurrentChips + currentpot / 2;

                newRound();
            }
        }

        public void recoverPlay()
        {
            if (guiplayer.MyTurn)
            {
                guiplayer.MyTurn = true;
            }
            else
            {
                
                aiplayer.MyTurn = true;
            }
        }

        public void prepareDeck()
        {
            dealer.getDeck().shuffleDeck();
            List<Card> Playercards = new List<Card>();
            foreach (var card in guiplayer.Hand)
            {
                Playercards.Add(card);
            }
            foreach (var card in aiplayer.Hand)
            {
                Playercards.Add(card);
            }
            dealer.restoreCards(Playercards);
           
        }
       
       
    }
}