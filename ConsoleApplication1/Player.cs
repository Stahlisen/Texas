using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Player
    {

        public string Name;
        public double CurrentChips;
        public double CurrentBet;
        public List<Card> Hand = new List<Card>();
        public bool MyTurn;

        public Player ()
        {

            
        }



    }
}
