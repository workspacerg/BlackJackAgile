using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackAgile
{
    public class Player
    {
        public List<Card> MyCards { get; set; }

        public int MyBet
        {
            get;
            set;
        }

        public Player()
            : base()
        {
            MyCards = new List<Card>();
            MyBet = 200;
        }
    }
}
