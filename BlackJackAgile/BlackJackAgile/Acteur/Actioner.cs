using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackAgile
{
    public abstract class Actioner
    {
        public List<Card> Cards { get; set; }

        public Actioner() {
            Cards = new List<Card>();
        }

        public abstract void Reset();

    }
}
