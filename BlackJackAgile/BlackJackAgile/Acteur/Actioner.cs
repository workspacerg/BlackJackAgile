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

        public virtual int GetPoints()
        {
            int currentPts = 0;
            int nbAs = 0;

            foreach (Card card in Cards.Where(x=>x.Visible))
            {
                if (card.Value != 1)
                    currentPts += card.Value;
                else
                    nbAs++;
            }

            while (nbAs > 0)
            {
                if (currentPts + 11 > 21)
                    currentPts++;
                else
                    currentPts += 11;

                nbAs--;
            }

            return currentPts;
        }

    }
}
