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
        
        public int getPtsPlayer(){
        	int currentPts = 0;
        	int nbAs = 0;
        	
        	foreach(Card card in Cards)
        	{
        		if(card.Value != 1)
        			currentPts += card.Value;
        		else
        			nbAs++;
        	}
        	
        	while(nbAs > 0)
        	{
        		if(currentPts+11 >21)
        			currentPts++;
        		else
        			currentPts+=11;
        		
        		nbAs --;
        	}
        	
        	return currentPts;
        }
    }
}
