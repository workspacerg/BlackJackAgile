using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackAgile
{
    public class Player : Actioner
    {
        public int MyBet
        {
            get;
            set;
        }

        public Player()
            : base()
        {
            Cards = new List<Card>();
            MyBet = 200;
        }

        public override void Reset()
        {
            MyBet = 200;
            Cards.Clear();
        }
        
    }
}
