﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ConsoleApplication1
{
    public class Guiplayer : IPlayer
    {
        public string name;
        public double currentchips;
        public bool myturn = false;
        public double currentbet = 0;
        public List<Card> hand = new List<Card>();
        Ruleengine reg;
        

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public Guiplayer(Ruleengine rule)
        {
            reg = rule;
            
        }

        public void Bet(double amount)
        {
            if (reg.BetPermitted(amount, this))
            {
                CurrentChips = currentchips - amount;
                CurrentBet = amount;
                Console.WriteLine("GUIPLAYER BETTED " + amount);
                MyTurn = false;
                
            }
            else
            {
                Console.WriteLine("Not permitted");
            }

        }

        public void Check()
        {
            if (reg.CheckPermitted(this))
            {
                MyTurn = false;
            }
            else
            {
                Console.WriteLine("Not permitted");
            }
        }

        public void Call(double amount)
        {
            if (reg.CallPermitted(amount, this))
            {
                CurrentChips = currentchips - amount;
                Console.WriteLine("GUIPLAYER CALLED " + amount);
                MyTurn = false;
                
                
            }
            else
            {
                Console.WriteLine("Not permitted");
            }
        }

        public void Fold()
        {
            reg.FoldPermitted(this);

        }
     
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public double CurrentChips
        {
            get
            {
                return currentchips;
            }
            set
            {
                currentchips = value;
                NotifyPropertyChanged("CurrentChips");
            }
        }

        public double CurrentBet
        {
            get
            {
                return currentbet;
            }
            set
            {
                currentbet = value;
                Console.WriteLine("Players currentbet changed to " + value);
                NotifyPropertyChanged("CurrentBet");
            }
        }

        public bool MyTurn
        {
            get
            {
                return myturn;
            }
            set
            {
                myturn = value;
                NotifyPropertyChanged("MyTurn");
                Console.WriteLine("players turn Changed to" + value);
            }
        }

        public List<Card> Hand
        {
            get
            {
                return hand;
            }
            set
            {
                hand = value;
            }
        }
        public void PayBlind(double blind)
        {
            CurrentChips = currentchips - blind;
        }
 
    }
}
