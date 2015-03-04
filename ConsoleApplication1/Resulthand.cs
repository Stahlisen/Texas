using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Resulthand
    {
        bool pair;
        bool twopair;
        bool triplet;
        bool straight;
        bool flush;
        bool fullhouse;
        bool four;
        bool straightflush;
        public Resulthand()
        {
            pair = false;
            twopair = false;
            triplet = false;
            straight = false;
            flush = false;
            fullhouse = false;
            four = false;
            straightflush = false;

        }

        public bool getPair()
        {
            return pair;
        }
        public void setPair(bool set) 
        {
            pair = set;

        }

        public bool getTwoPair()
        {
            return twopair;
        }

        public void setTwoPair(bool set)
        {
            twopair = set;
        }
        public bool getTriplet()
        {
            return triplet;
        }
        public void setTriplet(bool set)
        {
            triplet = set;
        }
        public bool getStraight()
        {
            return straight;
        }
        public void setStraigth(bool set)
        {
            straight = set;
        }
        public bool getFlush()
        {
            return flush;
        }
        public void setFlush(bool set)
        {
            flush = set;
        }
        public bool getFullHouse() 
        {
           
            return fullhouse;
        }
        public void setFullHouse(bool set) 
        {
            fullhouse = set;
        }
        public bool getFour() 
        {
            return four;
        }
        public void setFour(bool set) 
        {
            four = set;
        }

        public bool getStraightFlush() 
        {
            return straightflush;
        }
        public void setStraightFlush(bool set) 
        {
            straightflush = set;
        }

        public int getResult()
        {
            int resulthand = 0;

        if (pair)
        {
            resulthand = 1;
        }
        if (twopair)
        {
            resulthand = 2;
        }
        if (triplet)
        {
            resulthand = 3;
        }
        if (straight)
        {
            resulthand = 4;
        }
        if (flush)
        {
            resulthand = 5;
        }
        if (fullhouse)
        {
            resulthand = 6;
        }
        if (four)
        {
            resulthand = 7;
        }
        if (straightflush)
        {
            resulthand = 8;
        }
        return resulthand;

        }

        public void reset()
        {
            pair = false;
            twopair = false;
            triplet = false;
            straight = false;
            flush = false;
            fullhouse = false;
            four = false;
            straightflush = false;
        }
    }
}
