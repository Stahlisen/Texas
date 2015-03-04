using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.IO;

namespace ConsoleApplication1
{
    public class Gamecontroller
    {
        public Gamewindow gamewindow;
        Game game;
        string guiname;
        double gamechips;
        CardImage cardimage = new CardImage();
        bool isnewgame;
        
        public Gamecontroller(bool newgame, string name = "GUI", double chips = 2000)
        {
            game = new Game(name, chips, this, true);
            gamewindow = new Gamewindow(this);

            if (newgame)
            {
                isnewgame = true;
                guiname = name;
                gamechips = chips;
                gamewindow.ShowDialog();
            }
            else
            {
                isnewgame = false;
                game = new Game(name, chips, this, false);
                //gamewindow = new Gamewindow(this);
                //Gameloader.InitializeGame(game);
                gamewindow.ShowDialog();
            }
            
        }
        
        public void gameStarted()
        {
            if (isnewgame)
            {
                initiateStandardValues(guiname, gamechips);
                gamewindow.determine_button.Visible = false;
                Console.WriteLine("gamestarted");
                game.newRound();
            }
            else if (!isnewgame)
            {
                initiateStandardValues();
                game.prepareDeck();
                game.recoverPlay();
            }
        }
         

        public void attemptBet()
        {
            game.guiplayer.Bet(Convert.ToDouble(gamewindow.bet_amount.Value));

        }

        public void attemptCheck()
        {
            game.guiplayer.Check();
        }

        public void attemptCall()
        {
            game.guiplayer.Call(game.currentbet);
        }
        public void attemptFold()
        {
            game.guiplayer.Fold();
        }

        public void initiateStandardValues(string name = "guiplayer", double chips = 2000) {

            if (isnewgame)
            {
                Console.WriteLine("Heloo" + name + chips);
                gamewindow.player1_label.Text = name;
                gamewindow.ai_label.Text = "AI";
                gamewindow.player1chips_label.Text = Convert.ToString(chips);
                gamewindow.aiplayerchips_label.Text = Convert.ToString(chips);

                game.aiplayer.CurrentChips = chips;
                game.guiplayer.CurrentChips = chips;
            }
            else if (!isnewgame)
            {
                Console.WriteLine("rendering gui player data");
                gamewindow.player1_label.Text = game.guiplayer.Name;
                gamewindow.ai_label.Text = game.aiplayer.Name;
                gamewindow.player1chips_label.Text = Convert.ToString(game.guiplayer.CurrentChips);
                gamewindow.aiplayerchips_label.Text = Convert.ToString(game.aiplayer.CurrentChips);
                gamewindow.player_bet_amount.Text = Convert.ToString(game.guiplayer.CurrentBet);
                gamewindow.aiplayer_bet_amount.Text = Convert.ToString(game.aiplayer.CurrentBet);
                gamewindow.currentpot.Text = Convert.ToString(game.currentpot);


                if (Statehandler.getCurrentGive(game) == "starthand")
                {
                    gamewindow.player_card1.Image = Image.FromFile(cardimage.getImagePath(game.guiplayer.Hand[0]));
                    gamewindow.player_card2.Image = Image.FromFile(cardimage.getImagePath(game.guiplayer.Hand[1]));

                    gamewindow.ai_card1.Image = Image.FromFile(cardimage.getImagePath(game.aiplayer.Hand[0]));
                    gamewindow.ai_card2.Image = Image.FromFile(cardimage.getImagePath(game.aiplayer.Hand[1]));
                }
                else if (Statehandler.getCurrentGive(game) == "flop")
                {
                    gamewindow.player_card1.Image = Image.FromFile(cardimage.getImagePath(game.guiplayer.Hand[0]));
                    gamewindow.player_card2.Image = Image.FromFile(cardimage.getImagePath(game.guiplayer.Hand[1]));

                    gamewindow.ai_card1.Image = Image.FromFile(cardimage.getImagePath(game.aiplayer.Hand[0]));
                    gamewindow.ai_card2.Image = Image.FromFile(cardimage.getImagePath(game.aiplayer.Hand[1]));

                    gamewindow.flop_1.Image = Image.FromFile(cardimage.getImagePath(game.dealer.flopcards[0]));
                    gamewindow.flop_2.Image = Image.FromFile(cardimage.getImagePath(game.dealer.flopcards[1]));
                    gamewindow.flop_3.Image = Image.FromFile(cardimage.getImagePath(game.dealer.flopcards[2]));
                }
                else if (Statehandler.getCurrentGive(game) == "turn")
                {
                    gamewindow.player_card1.Image = Image.FromFile(cardimage.getImagePath(game.guiplayer.Hand[0]));
                    gamewindow.player_card2.Image = Image.FromFile(cardimage.getImagePath(game.guiplayer.Hand[1]));

                    gamewindow.ai_card1.Image = Image.FromFile(cardimage.getImagePath(game.aiplayer.Hand[0]));
                    gamewindow.ai_card2.Image = Image.FromFile(cardimage.getImagePath(game.aiplayer.Hand[1]));

                    gamewindow.flop_1.Image = Image.FromFile(cardimage.getImagePath(game.dealer.flopcards[0]));
                    gamewindow.flop_2.Image = Image.FromFile(cardimage.getImagePath(game.dealer.flopcards[1]));
                    gamewindow.flop_3.Image = Image.FromFile(cardimage.getImagePath(game.dealer.flopcards[2]));
                    gamewindow.turn.Image = Image.FromFile(cardimage.getImagePath(game.dealer.turncard));
                }
                else if (Statehandler.getCurrentGive(game) == "river")
                {
                    gamewindow.player_card1.Image = Image.FromFile(cardimage.getImagePath(game.guiplayer.Hand[0]));
                    gamewindow.player_card2.Image = Image.FromFile(cardimage.getImagePath(game.guiplayer.Hand[1]));

                    gamewindow.ai_card1.Image = Image.FromFile(cardimage.getImagePath(game.aiplayer.Hand[0]));
                    gamewindow.ai_card2.Image = Image.FromFile(cardimage.getImagePath(game.aiplayer.Hand[1]));

                    gamewindow.flop_1.Image = Image.FromFile(cardimage.getImagePath(game.dealer.flopcards[0]));
                    gamewindow.flop_2.Image = Image.FromFile(cardimage.getImagePath(game.dealer.flopcards[1]));
                    gamewindow.flop_3.Image = Image.FromFile(cardimage.getImagePath(game.dealer.flopcards[2]));
                    gamewindow.turn.Image = Image.FromFile(cardimage.getImagePath(game.dealer.turncard));
                    gamewindow.river.Image = Image.FromFile(cardimage.getImagePath(game.dealer.rivercard));
                }
            }
        }
        public void Guiplayer_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
            
                case "Name":
                gamewindow.changeLabel(gamewindow.player1_label, game.guiplayer.Name);
                Statehandler.SavePlayerData(game);
                break;

                case "CurrentChips" :
                    gamewindow.changeLabel(gamewindow.player1chips_label, Convert.ToString(game.guiplayer.CurrentChips));
                    gamewindow.bet_amount.Maximum = Convert.ToDecimal(game.guiplayer.CurrentChips);
                    Statehandler.SavePlayerData(game);
                    if (game.guiplayer.CurrentChips < 0)
                    {
                        gameEvent("You have run out of chips, AI wins the game", 1);
                        File.Delete("Gamedata.xml");
                        File.Delete("Cards.xml");
                        File.Delete("Playerdata.xml");
                        gamewindow.Close();
                        
                        
                    }
                    
                    
                break;

                case "MyTurn" :
                if (game.guiplayer.MyTurn)
                {
                    PlayerPanel(true);
                }
                else
                {
                    PlayerPanel(false);
                }
                Statehandler.SavePlayerData(game);
                break;

                case "CurrentBet":
                if (game.guiplayer.CurrentBet > 0)
                {
                    gamewindow.player_bet_amount.Text = Convert.ToString(game.guiplayer.CurrentBet);
                    gamewindow.showEvent("GUIPLAYER BETTED " + game.guiplayer.CurrentBet);
                }
                else
                {
                    gamewindow.player_bet_amount.Text = "";
                }
                Statehandler.SavePlayerData(game);
                break;
        }
        }

        public void Aiplayer_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {

                case "Name":
                    gamewindow.changeLabel(gamewindow.ai_label, game.aiplayer.Name);
                    Statehandler.SavePlayerData(game);
                    break;

                case "CurrentChips":
                    gamewindow.changeLabel(gamewindow.aiplayerchips_label, Convert.ToString(game.aiplayer.CurrentChips));
                    Statehandler.SavePlayerData(game);
                    if (game.aiplayer.CurrentChips < 0)
                    {
                        gameEvent("AIPlayer has run out of chips, Player wins the game", 1);
                        File.Delete("Gamedata.xml");
                        File.Delete("Cards.xml");
                        File.Delete("Playerdata.xml");
                        gamewindow.Close();
                        
                    }
                    
                    break;

                case "CurrentBet" :
                    if (game.aiplayer.CurrentBet > 0)
                    {
                        gamewindow.check_button.Enabled = false;
                        gamewindow.bet_button.Enabled = false;
                        gamewindow.call_button.Text = "Call " + game.aiplayer.CurrentBet;
                        gamewindow.aiplayer_bet_amount.Text = Convert.ToString(game.aiplayer.CurrentBet);

                    }
                    else
                    {
                        gamewindow.aiplayer_bet_amount.Text = "";
                    }
                    Statehandler.SavePlayerData(game);
                    break;
            }
        }

        public void game_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {

                case "currentpot":
                    gamewindow.changeLabel(gamewindow.currentpot, Convert.ToString(game.currentpot));
                    break;

            }
        }

        public void resetCards()
        {
            gamewindow.flop_1.Image = Image.FromFile(cardimage.TurnedCard());
            gamewindow.flop_2.Image = Image.FromFile(cardimage.TurnedCard());
            gamewindow.flop_3.Image = Image.FromFile(cardimage.TurnedCard());
            gamewindow.turn.Image = Image.FromFile(cardimage.TurnedCard());
            gamewindow.river.Image = Image.FromFile(cardimage.TurnedCard());
        }

        public void displayStarthand()
        {
            gamewindow.player_card1.Image = Image.FromFile(cardimage.getImagePath(game.guiplayer.Hand[0]));
            gamewindow.player_card2.Image = Image.FromFile(cardimage.getImagePath(game.guiplayer.Hand[1]));
            gamewindow.ai_card1.Image = Image.FromFile(cardimage.getImagePath(game.aiplayer.Hand[0]));
            gamewindow.ai_card2.Image = Image.FromFile(cardimage.getImagePath(game.aiplayer.Hand[1]));
        }

        public void displayFlop(List<Card> flop)
        {
            gamewindow.flop_1.Image = Image.FromFile(cardimage.getImagePath(flop[0]));
            gamewindow.flop_2.Image = Image.FromFile(cardimage.getImagePath(flop[1]));
            gamewindow.flop_3.Image = Image.FromFile(cardimage.getImagePath(flop[2]));
        }

        public void displayTurn(Card turn)
        {
            gamewindow.turn.Image = Image.FromFile(cardimage.getImagePath(turn));
        }

        public void displayRiver(Card river)
        {
            gamewindow.river.Image = Image.FromFile(cardimage.getImagePath(river));
        }

        public void PlayerPanel(bool value)
        {
            if (value)
            {
                if (game.currentbet > 0)
                {
                    gamewindow.call_button.Enabled = true;
                }
                gamewindow.bet_button.Enabled = true;
                gamewindow.bet_amount.Enabled = true;
                gamewindow.check_button.Enabled = true;
                gamewindow.fold_button.Enabled = true;
            }
            else
            {
                gamewindow.call_button.Enabled = false;
                gamewindow.bet_button.Enabled = false;
                gamewindow.bet_amount.Enabled = false;
                gamewindow.check_button.Enabled = false;
                gamewindow.fold_button.Enabled = false;

            }
        }

        public void gameEvent(string text, int choice = 0)
        {
            if (choice == 1)
            {
                gamewindow.showMessage(text);
            }
            else
            {
                gamewindow.showEvent(text);
            }
                
            
        }

    }
}
