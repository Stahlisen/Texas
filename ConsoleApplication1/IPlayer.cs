using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ConsoleApplication1
{
    public interface IPlayer : INotifyPropertyChanged
    {
        void Check();
        void Bet(double amount);
        void Call(double amount);
        void Fold();
        double CurrentChips { get; set;}
        string Name { get; set;}
        bool MyTurn { get; set; }
        double CurrentBet { get; set; }
        List<Card> Hand { get; set;}
        void PayBlind(double blind);


    }
}
