using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class PlayerHand
    {
        List<string> cards = new List<string>();

        public PlayerHand () {

    }

        public List<string> getCards() {

            return cards;
        }

    }
}
