using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CardImage
    {
        string path = @"..\new_cards\";
        public string getImagePath(Card card)
        {
            string filename = card.getValue() + "of" + card.getSuit() + ".png";
            string filepath = Path.Combine(path, filename);
            return filepath;
        }

        public string TurnedCard()
        {
            string backcard = "BackofCard.png";
            string path_backcard = Path.Combine(path, backcard);
            return path_backcard;
        }
    }
}
